using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva.Presentacion
{
    public partial class ConsultarPedido : Form
    {
        public ConsultarPedido()
        {
            InitializeComponent();
            txtNroPedido.Text = "0";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
            DataTable tabla = AccesoADatos.DetallePedido.obtenerDetalles(Convert.ToInt32(txtNroPedido.Text));
            grilla.DataSource = tabla;
        }
    }
}
