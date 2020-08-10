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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Producto.ObtenerProducto();
            grilla.DataSource = tabla;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            cargarGrilla();
            txtCodigo.Text = "";
            txtCodigo.Focus();

        }

        private void eliminarProducto()
        {
            bool resultado = AccesoADatos.Producto.EliminarProducto(Convert.ToInt32(txtCodigo.Text));
            if (resultado)
            {
                MessageBox.Show("El producto se ELIMINO con exito");
            }
            else
            {
                MessageBox.Show("El producto no pudo ser eliminado");
            }
        }

    }
}
