using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.AccesoADatos
{
    public class DetallePedido
    {

        public static bool InsertarDetallePedido(int id, int codigo, string comida, int cantidad, int costounitario, int costototal)
        {
            string cadenaConexion = "Data Source=ERIK-PC;Initial Catalog=VerdeOliva;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "INSERT INTO DetallePedido VALUES (@IdDetallePedido,@Codigo,@Comida,@Cantidad,@CostoUnitario,@CostoTotal)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDetallePedido", id);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Comida ", comida);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@CostoUnitario", costounitario);
                cmd.Parameters.AddWithValue("@CostoTotal ", costototal);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerProducto(int codigo)
        {
            string cadenaConexion = "Data Source=ERIK-PC;Initial Catalog=VerdeOliva;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT Comida,CostoUnitario FROM Producto WHERE codigo=@Codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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

        /* ELIMINAR UN PEDIDO O DETALLE
        public static bool EliminarPedido(int dni)
        {
            string cadenaConexion = "Data Source=ERIK-PC;Initial Catalog=VerdeOliva;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "DELETE FROM  WHERE [DNI] = @dni";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                cn.Close();
            }


        }*/
    }
}
