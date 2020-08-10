using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verde_Oliva.Entidad;

namespace Verde_Oliva
{
    public partial class Pedido : Form
    {
        private string CostoU;
        private int CostoT;
        

        public Pedido()
        {
            InitializeComponent();
            txtCantidad.Text = "1";
            txtCodigo.Text = "0";
        }

        //Boton para buscar el producto
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }

        //Metodo para obtener un producto de la Base de Datos
        private void buscarProducto()
        {

            try
            {
                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese un CODIGO de producto");
                }
                else
                {
                    DataTable resultado = AccesoADatos.Producto.ObtenerProductoId(int.Parse(txtCodigo.Text));
                    if (resultado.Rows.Count > 0)
                    {
                        txtDescripcion.Text = resultado.Rows[0][0].ToString();
                        CostoU = resultado.Rows[0][1].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Error no existen productos con ese codigo");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Boton para agregar los contenidos de TextBox a la grilla
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals("") || txtCantidad.Text.Equals("") || txtCodigo.Text.Equals("") || (int.Parse(txtCantidad.Text) == 0))
            {
                MessageBox.Show("Los campos: Codigo, Descripcion de Comida, Cantidad, son obligatorios!");
            }
            else
            {
                CostoT = int.Parse(CostoU) * int.Parse(txtCantidad.Text);
                //Agregamos valores a la grilla
                grilla.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtCantidad.Text, CostoU, CostoT);
                LimpiarCampos();
                calcularMontoTotal();
                txtMonto.Text = calcularMontoTotal().ToString();
            }

        }

        //Boton para limpiar los campos
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Metodo que limpia los campos de TextBox
        private void LimpiarCampos()
        {
            txtCodigo.Text = "0";
            txtDescripcion.Text = "";
            txtCantidad.Text = "1";
            txtCodigo.Focus();
        }
        private void LimpiarCamposFinalizar()
        {
            txtCodigo.Text = "0";
            txtDescripcion.Text = "";
            txtCantidad.Text = "1";
            txtDireccion.Text = "";
            txtNroTelefono.Text = "";
            txtMonto.Text = "";
            txtNroTelefono.Text = "";
            txtMonto.Text = "";
            grilla.Rows.Clear();
            txtCodigo.Focus();
        }

        //Valida si el CODIGO es numerico
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            {
                int myInt;
                bool isNumerical = int.TryParse(txtCodigo.Text, out myInt);
                if (!isNumerical)
                {
                    txtCodigo.Focus();
                    MessageBox.Show("No es un codigo valido");
                    txtCodigo.Text = "";
                }
            }
        }

        //Boton de borrar fila seleccionada en la tabla
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (grilla.Rows.Count > 0)
            {
                grilla.Rows.RemoveAt(grilla.CurrentRow.Index);
                calcularMontoTotal();
                txtMonto.Text = calcularMontoTotal().ToString();
            }
            else
            {
                MessageBox.Show("No existen mas filas para borrar!");
            }

        }

        //Obtener y mostrar Fecha y Hora Actual
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            lblFechaHora.Text = dia+"/"+mes+"/"+año+"       "+hora+":"+minuto;
        }

        //calcula el MontoTotal de los productos para el ticket
        private int calcularMontoTotal()
        {
            int MontoTotal = 0;
            for (int i = 0; i < grilla.Rows.Count; i++)
            {

                MontoTotal = grilla.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["CostoTotal"].Value));

            }
            return MontoTotal;

        }

        //FINALIZAR PEDIDO TRANSACCION
        private void BtnFinalizar_Click_1(object sender, EventArgs e)
        {
            List<DetallePedido> listaDT = new List<DetallePedido>();
            int iddetalle = 0;
            int idpedido = AccesoADatos.Pedido.obtenerIdPedido() + 1;
            foreach (DataGridViewRow dr in grilla.Rows)
            {
                DetallePedido dt = new DetallePedido();
                dt.IdDetallePedido = iddetalle;
                dt.Comida = Convert.ToString(dr.Cells["Comida"].Value);
                dt.Cantidad = Convert.ToInt32(dr.Cells["Cantidad"].Value);
                dt.CostoUnitario = Convert.ToInt32(dr.Cells["CostoUnitario"].Value);
                dt.CostoTotal = Convert.ToInt32(dr.Cells["CostoTotal"].Value);
                listaDT.Add(dt);
                iddetalle++;
            }

            bool resultado = AccesoADatos.Pedido.InsertarPedido(txtDireccion.Text, calcularMontoTotal(), listaDT);

            if (resultado)
            {
                MessageBox.Show("El pedido se cargo con exito");

                //*********************IMPRESION DE TICKET ********************//
                imprimirTicket(idpedido, listaDT);
                imprimirTicket(idpedido, listaDT);
                LimpiarCamposFinalizar();

            }
            else
            {
                MessageBox.Show("Error al cargar pedido");
            }

        }

        private void imprimirTicket(int idpedido, List<DetallePedido> lista)
        {
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.TextoCentro("Verde Oliva");// imprime en el centro "Verde Oliva"
            Ticket1.TextoIzquierda("  ");
            Ticket1.TextoIzquierda("Av. Olivares y Esq. Molle - Mi Valle Golf");
            Ticket1.TextoIzquierda("351 - 3881552");
            Ticket1.TextoIzquierda("351 - 2408897");
            Ticket1.TextoIzquierda("  ");
            Ticket1.TextoIzquierda("Nro Pedido: " + idpedido);
            Ticket1.TextoExtremos("FECHA: " + DateTime.Now.Date, "HORA: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            //HORA DE SALIDA
            DateTime horaactual = DateTime.Now;
            DateTime horasalida = horaactual.AddMinutes(40) ;

            Ticket1.TextoDerecha("HORA SALIDA: " + horasalida.Hour + ":" + horasalida.Minute);
            Ticket1.TextoIzquierda("  ");
            Ticket1.TextoIzquierda("CLIENTE:");
            Ticket1.TextoCentro(txtDireccion.Text);
            Ticket1.TextoCentro(txtNroTelefono.Text);
            Ticket1.TextoIzquierda("  ");
            Ticket1.LineasGuion();
            Ticket1.EncabezadoVenta(); // imprime encabezados
            foreach (var item in lista)
            {
                Ticket1.AgregaArticulo(item.Comida, item.Cantidad, item.CostoUnitario, item.CostoTotal); //imprime una linea de descripcion
            }
            Ticket1.LineasTotales(); // imprime linea
            Ticket1.AgregaTotales("Total", calcularMontoTotal()); // imprime linea con total
            Ticket1.LineasGuion();
            Ticket1.CortaTicket(); // corta el ticket

        }

        private void recordarDirecciones()
        {
            AutoCompleteStringCollection direccion = new AutoCompleteStringCollection();

            DataTable tabla = AccesoADatos.Pedido.obtenerDireccion();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    direccion.Add(Convert.ToString(fila["Direccion"]));
                }
            }
            
            txtDireccion.AutoCompleteCustomSource = direccion;
            txtDireccion.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDireccion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            recordarDirecciones();
        }
    }
}

