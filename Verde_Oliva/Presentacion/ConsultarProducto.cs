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
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = AccesoADatos.Producto.ObtenerProductoId(Convert.ToInt32(txtCodigo.Text));
            if (tabla.Rows.Count > 0)
            {
                txtComida.Text = tabla.Rows[0][0].ToString();
                txtCostoUnitario.Text = tabla.Rows[0][1].ToString();


            }
            else
            {
                MessageBox.Show("Error no existen productos con ese codigo");
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtComida.Text = "";
            txtCostoUnitario.Text = "";
            txtCodigo.Focus();
        }
        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Producto.ObtenerProducto();
            grilla.DataSource = tabla;

        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
