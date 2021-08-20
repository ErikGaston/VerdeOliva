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
                string consulta = "SELECT * FROM Producto ";
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

        public static DataTable ObtenerProductoLomo()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'Lomo%' ";
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

        public static DataTable ObtenerProductoPizza()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'P.%' ";
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

        public static DataTable ObtenerProductoMediaPizza()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'Media P.%' ";
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

        public static DataTable ObtenerProductoEmpanada()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'Emp%' OR Comida LIKE 'Doc.%' OR Comida LIKE 'Media D%'";
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

        public static DataTable ObtenerProductoHamb()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'Hamb%' ";
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

        public static DataTable ObtenerProductoPromo()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'PROMO%' ";
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

        public static DataTable ObtenerProductoOtros()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida NOT LIKE 'Lomo%' AND Comida NOT LIKE 'P.%' AND Comida NOT LIKE 'Media%' AND Comida NOT LIKE 'PROMO%' AND Comida NOT LIKE 'Hamb%' AND Comida NOT LIKE 'Doc%' AND Comida NOT LIKE 'Emp%' AND Comida NOT LIKE 'Beb.%' AND Comida NOT LIKE 'ENVIO%'";
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

        public static DataTable ObtenerProductoBebidas()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'Beb.%' ";
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

        public static DataTable ObtenerProductoMenu()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'MENU%' ";
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

        public static bool ActualizarProductoGrupo(string codigo, int costo)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Producto SET CostoUnitario = CostoUnitario + @Costo WHERE Comida LIKE @Codigo + '%'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Costo", costo);

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

        public static DataTable ObtenerProductoEnvio1()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'ENVIO1%' ";
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

        public static DataTable ObtenerProductoEnvio2()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT CostoUnitario,Comida FROM Producto WHERE Comida LIKE 'ENVIO2%' ";
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



    }
}
