using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.AccesoADatos
{
    public class Usuario
    {
        public static DataTable obtenerUsuario(string nombre, string contraseña)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT * FROM Usuario WHERE Nombre = @nombre AND Contraseña = @contraseña";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

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
