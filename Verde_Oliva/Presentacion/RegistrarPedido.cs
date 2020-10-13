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
        private float CostoT;
        private DateTime horasalida;
        private string BuscaEnvia;
        PedidoController pcontroller = new PedidoController();

        public Pedido()
        {
            InitializeComponent();
            txtCantidad.Text = "1";
            cargarCombo();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            recordarDirecciones();
        }

        //Metodo para obtener un producto de la Base de Datos
        private void cargarCombo()
        {
            try
            {
                DataTable lomo = AccesoADatos.Producto.ObtenerProductoLomo();
                DataTable pizza = AccesoADatos.Producto.ObtenerProductoPizza();
                DataTable mediaPizza = AccesoADatos.Producto.ObtenerProductoMediaPizza();
                DataTable emp = AccesoADatos.Producto.ObtenerProductoEmpanada();
                DataTable hamburguesa = AccesoADatos.Producto.ObtenerProductoHamb();
                DataTable promo = AccesoADatos.Producto.ObtenerProductoPromo();
                DataTable otros = AccesoADatos.Producto.ObtenerProductoOtros();

                cmbLomo.DataSource = lomo;
                cmbLomo.ValueMember = "CostoUnitario";
                cmbLomo.DisplayMember = "Comida";
                cmbLomo.SelectedIndex = -1;

                cmbPizza.DataSource = pizza;
                cmbPizza.ValueMember = "CostoUnitario";
                cmbPizza.DisplayMember = "Comida";
                cmbPizza.SelectedIndex = -1;

                cmbMediaPizza.DataSource = mediaPizza;
                cmbMediaPizza.ValueMember = "CostoUnitario";
                cmbMediaPizza.DisplayMember = "Comida";
                cmbMediaPizza.SelectedIndex = -1;

                cmbEmp.DataSource = emp;
                cmbEmp.ValueMember = "CostoUnitario";
                cmbEmp.DisplayMember = "Comida";
                cmbEmp.SelectedIndex = -1;

                cmbHamb.DataSource = hamburguesa;
                cmbHamb.ValueMember = "CostoUnitario";
                cmbHamb.DisplayMember = "Comida";
                cmbHamb.SelectedIndex = -1;

                cmbPromo.DataSource = promo;
                cmbPromo.ValueMember = "CostoUnitario";
                cmbPromo.DisplayMember = "Comida";
                cmbPromo.SelectedIndex = -1;

                cmbOtros.DataSource = otros;
                cmbOtros.ValueMember = "CostoUnitario";
                cmbOtros.DisplayMember = "Comida";
                cmbOtros.SelectedIndex = -1;
            }
            catch (Exception e)
            {
               MessageBox.Show("Error al cargar combos" + e.Message.ToString());
            }
        }

        //Boton para agregar los contenidos de los ComboBox a la grilla
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            
            if (cmbLomo.Text.Equals("") && cmbPizza.Text.Equals("") && cmbMediaPizza.Text.Equals("") && cmbEmp.Text.Equals("") && cmbPromo.Text.Equals("") && cmbHamb.Text.Equals("") && cmbOtros.Text.Equals("") && txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Los campos PRODUCTOS son obligatorios!");
            }
            else
            {

                //Agregamos valores a la grilla
                if (!string.IsNullOrEmpty(cmbLomo.Text))
                {
                    CostoT = int.Parse(cmbLomo.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbLomo.Text,cmbLomo.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbPizza.Text))
                {
                    CostoT = int.Parse(cmbPizza.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbPizza.Text, cmbPizza.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbMediaPizza.Text))
                {
                    CostoT = int.Parse(cmbMediaPizza.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbMediaPizza.Text, cmbMediaPizza.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbEmp.Text)) {
                    CostoT = int.Parse(cmbEmp.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbEmp.Text, cmbEmp.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbPromo.Text))
                {
                    CostoT = int.Parse(cmbPromo.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbPromo.Text, cmbPromo.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbHamb.Text))
                {
                    CostoT = int.Parse(cmbHamb.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbHamb.Text, cmbHamb.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }
                if (!string.IsNullOrEmpty(cmbOtros.Text))
                {
                    CostoT = int.Parse(cmbOtros.SelectedValue.ToString()) * float.Parse(txtCantidad.Text);
                    grilla.Rows.Add(txtCantidad.Text, cmbOtros.Text, cmbOtros.SelectedValue.ToString(), CostoT);
                    LimpiarCampos();
                }

            }
            calcularMontoTotal();
            txtMonto.Text = calcularMontoTotal().ToString();

        }

        //Boton para limpiar los campos
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Metodo que limpia los campos de TextBox
        private void LimpiarCampos()
        {
            cmbPizza.SelectedIndex = -1;
            cmbMediaPizza.SelectedIndex = -1;
            cmbLomo.SelectedIndex = -1;
            cmbEmp.SelectedIndex = -1;
            cmbHamb.SelectedIndex = -1;
            cmbPromo.SelectedIndex = -1;
            cmbOtros.SelectedIndex = -1;
            txtCantidad.Text = "1";
        }

        private void LimpiarCamposFinalizar()
        {
            LimpiarCampos();

            radioEnvio.Checked = false;
            radioBusca.Checked = false;

            rtxtCuadro.Text = "";

            txtDireccion.Text = "";
            txtNroTelefono.Text = "";

            txtMonto.Text = "";
            txtPaga.Text = "";

            grilla.Rows.Clear();
            
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
            lblFechaHora.Text = dia + "/" + mes + "/" + año + "       " + hora + ":" + minuto;
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
            if (txtDireccion.Text != "" && grilla.Rows.Count != 0 && (radioEnvio.Checked == true || radioBusca.Checked == true))
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
            else
            {
                MessageBox.Show("Ingrese productos, direccion, tambien si se envia o se busca para registrar la venta");
            }
            

        }

        private void imprimirTicket(int idpedido, List<DetallePedido> lista)
        {
            try
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

                DateTime horaactual = DateTime.Now;
                //HORA DE SALIDA
                if (radioBusca.Checked)
                {
                    horasalida = horaactual.AddMinutes(20);
                    BuscaEnvia = "BUSCA";
                }
                if (radioEnvio.Checked)
                {
                    horasalida = horaactual.AddMinutes(40);
                    BuscaEnvia = "ENVIAR";
                }

                Ticket1.TextoDerecha("HORA SALIDA: " + horasalida.Hour + ":" + horasalida.Minute);
                Ticket1.TextoIzquierda("  ");
                Ticket1.LineasGuion();
                Ticket1.TextoIzquierda("CLIENTE:");
                Ticket1.TextoIzquierda("  ");
                Ticket1.TextoCentro(BuscaEnvia);
                Ticket1.TextoIzquierda(txtDireccion.Text);
                Ticket1.TextoIzquierda(txtNroTelefono.Text);
                Ticket1.TextoIzquierda("  ");
                Ticket1.LineasGuion();
                Ticket1.EncabezadoVenta1(); // imprime encabezados
                foreach (var item in lista)
                {
                    //Ticket1.AgregaArticulo(item.Comida, item.Cantidad, item.CostoUnitario, item.CostoTotal); //imprime una linea de descripcion
                    Ticket1.AgregaArticulo1(item.Cantidad, item.Comida, item.CostoUnitario, item.CostoTotal); //imprime una linea de descripcion
                }
                if (rtxtCuadro.Text != "")
                {
                    Ticket1.LineasIgual(); // imprime linea
                    Ticket1.TextoIzquierda(rtxtCuadro.Text);
                    Ticket1.LineasIgual(); // imprime linea
                }
                Ticket1.LineasGuion();
                Ticket1.AgregaTotales("Total", calcularMontoTotal()); // imprime linea con total
                Ticket1.LineasGuion();
                Ticket1.TextoIzquierda("  ");
                Ticket1.AgregaTotales("Paga", double.Parse(txtPaga.Text));
                Ticket1.CortaTicket(); // corta el ticket
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al imprimir ticket" + e.ToString());
    
                throw;
            }
        }

        /*Metodo que recuerda en el textbox las direcciones*/
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

        /*Boton BUSCA Y ENVIA*/
        private void RadioEnvio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEnvio.Checked)
            {
                grilla.Rows.Add(1, "ENVIO", 30, 30);
                
            }
            calcularMontoTotal();
            txtMonto.Text = calcularMontoTotal().ToString();
        }

        private void RadioBusca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBusca.Checked)
            {
                foreach (DataGridViewRow fila in grilla.Rows)
                {
                    if (fila.Cells["Comida"].Value.ToString().Equals("ENVIO"))
                    {
                        grilla.Rows.RemoveAt(fila.Index);
                        txtMonto.Text =Convert.ToString(Convert.ToInt32(txtMonto.Text) - 30);

                    }
                    
                }
              
            }

        }

        /*Verificacion de numero*/
        private void TxtNroTelefono_TextChanged(object sender, EventArgs e)
        {
            if(txtNroTelefono.Text != "")
                pcontroller.esNumero(txtNroTelefono);
        }

        private void TxtPaga_TextChanged(object sender, EventArgs e)
        {
            if (txtPaga.Text != "")
                pcontroller.esNumero(txtPaga);
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
                pcontroller.esNumero(txtCantidad);
        }

        /*Mayuscula en el cuadro de texto*/
        private void RtxtCuadro_KeyPress(object sender, KeyPressEventArgs e)
        {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}

