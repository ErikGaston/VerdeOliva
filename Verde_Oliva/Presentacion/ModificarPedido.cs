using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verde_Oliva.Entidad;

namespace Verde_Oliva.Presentacion
{
    public partial class ModificarPedido : Form
    {
        private string CostoU;
        private int CostoT;
        public ModificarPedido()
        {
            InitializeComponent();
            txtCantidad.Text = "1";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            buscarPedido();
            cargarGrilla();


        }
        private void buscarPedido()
        {

            try
            {
                if (txtNroPedido.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese un Numero de Pedido");
                }
                else
                {
                    DataTable resultado = AccesoADatos.Pedido.obtenerPedidos(int.Parse(txtNroPedido.Text));
                    if (resultado.Rows.Count > 0)
                    {
                        lblFechaHora.Text = resultado.Rows[0][1].ToString();
                        txtDireccion.Text = resultado.Rows[0][2].ToString();
                        txtMonto.Text = resultado.Rows[0][3].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Error no existen PEDIDOS con ese numero");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargarGrilla()
        {
            try
            {
                DataTable tabla = AccesoADatos.DetallePedido.obtenerDetalles(Convert.ToInt32(txtNroPedido.Text));
                grilla.DataSource = tabla;
            }
            catch (Exception)
            {
                throw;
            }

        }

        

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }
        private void buscarProducto()
        {

            try
            {
                if (txtCodigo.Text.Equals("") || txtCantidad.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese un CODIGO y CANTIDAD de producto");
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
                DataTable tabla =(DataTable) grilla.DataSource;
                DataRow dr = tabla.NewRow();

               // dr["Codigo"] = txtCodigo.Text;
                dr["Comida"] = txtDescripcion.Text;
                dr["Cantidad"] = txtCantidad.Text;
                dr["CostoUnitario"] = CostoU;
                dr["CostoTotal"] = CostoT;

                tabla.Rows.Add(dr);
                grilla.DataSource = tabla;

                /*-------------------------------*/

                LimpiarCampos();
                calcularMontoTotal();
                txtMonto.Text = calcularMontoTotal().ToString();
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "0";
            txtDescripcion.Text = "";
            txtCantidad.Text = "1";
            txtDireccion.Text = "";
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (grilla.Rows.Count > 0)
            {
                grilla.Rows.RemoveAt(grilla.CurrentRow.Index);
                //AccesoADatos.DetallePedido.eliminarDetallePedido(Convert.ToInt32(grilla.CurrentRow.Index));
                calcularMontoTotal();
                txtMonto.Text = calcularMontoTotal().ToString();
            }
            else
            {
                MessageBox.Show("No existen mas filas para borrar!");
            }
        }
        private int calcularMontoTotal()
        {
            int MontoTotal = 0;
            for (int i = 0; i < grilla.Rows.Count; i++)
            {

                MontoTotal = grilla.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["CostoTotal"].Value));

            }
            return MontoTotal;

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            List<DetallePedido> listaDT = new List<DetallePedido>();
            int iddetalle = 0;
            int idpedido = Convert.ToInt32(txtNroPedido.Text);
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

            bool resultado = AccesoADatos.Pedido.ModificarPedido(idpedido, txtDireccion.Text, calcularMontoTotal(), listaDT);

            if (resultado)
            {
                MessageBox.Show("El pedido se modifico con exito");

                //*********************IMPRESION DE TICKET ********************//
                imprimirTicket(idpedido, listaDT);
                imprimirTicket(idpedido, listaDT);

            }
            else
            {
                MessageBox.Show("Error al modificar pedido");
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
            int horasalida = DateTime.Now.Minute + 40;
            Ticket1.TextoDerecha("HORA SALIDA: " + DateTime.Now.Hour + ":" + horasalida);
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

    }
}
