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
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
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
        private void Button1_Click_1(object sender, EventArgs e)
        {
            actualizarProducto();
            cargarGrilla();
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


        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Producto.ObtenerProducto();
            grilla.DataSource = tabla;

        }

        private void actualizarProducto()
        {
            if (txtCodigo.Text.Equals("") || txtComida.Text.Equals("") || txtCostoUnitario.Text.Equals(""))
            {
                MessageBox.Show("Los campos: Codigo, Descripcion de Comida y Costo Unitario son obligatorios!");
            }
            else
            {
                bool resultado = AccesoADatos.Producto.ActualizarProducto(Convert.ToInt32(txtCodigo.Text), txtComida.Text, Convert.ToInt32(txtCostoUnitario.Text));
                if (resultado)
                {
                    MessageBox.Show("El producto se actualizo con exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser actualizado");
                }
            }
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
