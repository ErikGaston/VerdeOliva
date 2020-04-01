using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva.AccesoADatos
{
    public class Pedido
    {
        public static int obtenerIdPedido()
        {
            string cadenaConexion = "Data Source=ERIK-PC;Initial Catalog=VerdeOliva;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT MAX(IdPedido) FROM Pedido";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


        }

        public static bool InsertarPedido(DateTime fecha, string direccion,int montototal, List<Entidad.EntidadDetallePedido> listaDT)
        {
            string cadenaConexion = "Data Source=ERIK-PC;Initial Catalog=VerdeOliva;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlTransaction objTransacion = null;

            try
            {
                SqlCommand cmdPedido = new SqlCommand();
                SqlCommand cmdDetallePedido = new SqlCommand();

                string consulta = "INSERT INTO Pedido VALUES (@FechaHora,@Direccion,@MontoTotal)";

                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@FechaHora", fecha);
                cmdPedido.Parameters.AddWithValue("@Direccion", direccion);
                cmdPedido.Parameters.AddWithValue("@MontoTotal", montototal);

                cn.Open();
                objTransacion = cn.BeginTransaction("Pedido Generado");

                cmdPedido.CommandType = CommandType.Text;
                cmdPedido.CommandText = consulta;

                cmdPedido.Transaction = objTransacion;

                cmdPedido.Connection = cn;
                cmdPedido.ExecuteNonQuery();

                int IdPedido = (AccesoADatos.Pedido.obtenerIdPedido() + 1);

                for (int i = 0; i < listaDT.Count; i++)
                {
                    string consultaPedidoDetallePedido = "INSERT INTO DetallePedido VALUES (@IdDetallePedido,@Codigo,@Comida,@Cantidad,@CostoUnitario,@CostoTotal)";

                    cmdDetallePedido.Transaction = objTransacion;

                    cmdDetallePedido.Parameters.Clear();
                    cmdDetallePedido.Parameters.AddWithValue("@IdDetallePedido", IdPedido);
                    cmdDetallePedido.Parameters.AddWithValue("@Codigo", listaDT[i].Codigo);
                    cmdDetallePedido.Parameters.AddWithValue("@Comida", listaDT[i].Comida);
                    cmdDetallePedido.Parameters.AddWithValue("@Cantidad", listaDT[i].Cantidad);
                    cmdDetallePedido.Parameters.AddWithValue("@CostoUnitario", listaDT[i].CostoUnitario);
                    cmdDetallePedido.Parameters.AddWithValue("@CostoTotal", listaDT[i].CostoTotal);

                    cmdDetallePedido.CommandType = CommandType.Text;
                    cmdDetallePedido.CommandText = consultaPedidoDetallePedido;


                    cmdDetallePedido.Connection = cn;
                    cmdDetallePedido.ExecuteNonQuery();

                }
                objTransacion.Commit();

                return true;

            }
            catch (Exception)
            {
                objTransacion.Rollback();
                return false;
                throw;



            }
            finally
            {
                cn.Close();
            }
        }
    }

 }