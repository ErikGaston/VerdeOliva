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
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtComida.Text = "";
            txtCostoUnitario.Text = "";
            txtCodigo.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            insertarPedido();
        }


        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Producto.ObtenerProducto();
            grilla.DataSource = tabla;

        }

        private void insertarPedido()
        {
            if (txtCodigo.Text.Equals("") || txtComida.Text.Equals("") || txtCostoUnitario.Text.Equals(""))
            {
                MessageBox.Show("Los campos: Codigo, Descripcion de Comida y Costo Unitario son obligatorios!");
            }
            else
            {
                bool resultado = AccesoADatos.Producto.InsertarProducto(Convert.ToInt32(txtCodigo.Text),txtComida.Text,Convert.ToInt32(txtCostoUnitario.Text));
                if (resultado)
                {
                    MessageBox.Show("El producto se agrego con exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser agregado");
                }
            }
        }
    }
}
