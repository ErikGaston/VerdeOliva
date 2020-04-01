using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva
{
    public partial class Pedido : Form
    {
        private string CostoU;
        private int CostoT;
        List<Entidad.EntidadDetallePedido> listaDT = new List<Entidad.EntidadDetallePedido>();

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
                if (txtCodigo.Text.Equals("") || txtCantidad.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese un CODIGO y CANTIDAD de producto");
                }
                else
                {
                    DataTable resultado = AccesoADatos.DetallePedido.ObtenerProducto(int.Parse(txtCodigo.Text));
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
            txtDireccion.Text = "";
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
            }
            else
            {
                MessageBox.Show("No existen mas filas para borrar!");
            }

        }

        //Obtener y mostrar Fecha y Hora Actual
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime fechahora = DateTime.Now;
            lblFechaHora.Text = fechahora.ToString();
        }

        //calcula el MontoTotal de los productos para el ticket
        private double calcularMontoTotal()
        {
            double MontoTotal = 0.0;
            for (int i = 0; i < grilla.Rows.Count; i++)
            {

                MontoTotal = grilla.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["CostoTotal"].Value));

            }
            return MontoTotal;

        }

        //FINALIZAR PEDIDO TRANSACCION
        private void BtnFinalizar_Click_1(object sender, EventArgs e)
        {
            int MontoT = int.Parse(calcularMontoTotal().ToString());

            //AccesoADatos.Pedido.InsertarPedido(DateTime.Now, txtDireccion.Text, MontoT, listaDT);

            bool resultado;

            //int IdPedido = (AccesoADatos.Pedido.obtenerIdPedido());

            foreach (DataGridViewRow row in grilla.Rows)
            {

                Entidad.EntidadDetallePedido dt = new Entidad.EntidadDetallePedido(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()), int.Parse(row.Cells[3].Value.ToString()), int.Parse(row.Cells[4].Value.ToString()));

                listaDT.Add(dt);

                //resultado = AccesoADatos.DetallePedido.InsertarDetallePedido(IdPedido,int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()), int.Parse(row.Cells[3].Value.ToString()), int.Parse(row.Cells[4].Value.ToString()));
               
            }

            resultado = AccesoADatos.Pedido.InsertarPedido(DateTime.Now, txtDireccion.Text, MontoT, listaDT);

            if (resultado)
            {
                MessageBox.Show("El pedido se genero correctamente!");
            }
            else
            {
                MessageBox.Show("El pedido no se genero!");
            }



        }
    }
 }

