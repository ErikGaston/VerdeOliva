using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Verde_Oliva.AccesoADatos
{
    public class Producto
    {

        public static DataTable ObtenerProductoId(int codigo)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("ObtenerProducto", cn);
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();

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

        public static DataTable ObtenerProducto()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT * FROM Producto";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();

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

        public static bool InsertarProducto(int codigo, string comida, int costounitario)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Producto VALUES(@Codigo,@Comida,@CostoUnitario)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Comida", comida);
                cmd.Parameters.AddWithValue("@CostoUnitario", costounitario);

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

        public static bool ActualizarProducto(int codigo, string comida, int costounitario)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Producto SET Comida = @Comida, CostoUnitario = @CostoUnitario WHERE Codigo = @Codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Comida", comida);
                cmd.Parameters.AddWithValue("@CostoUnitario", costounitario);

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

        public static bool EliminarProducto(int codigo)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Producto WHERE Codigo = @Codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);

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
    }
}
