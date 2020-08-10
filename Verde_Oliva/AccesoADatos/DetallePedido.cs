using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.AccesoADatos
{
    public class DetallePedido
    {
        public static DataTable obtenerDetalles(int nropedido)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT Comida,Cantidad,CostoUnitario,CostoTotal FROM DetallePedido WHERE IdPedido = @nropedido";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nropedido", nropedido);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();

                cmd.Connection = cn;

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
        public static bool InsertarDetallePedido(int idpedido, int montototal, List<Entidad.DetallePedido> listadt)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                //SqlCommand cmdDetallePedido = new SqlCommand("InsertarDetallePedido", cn);
                SqlCommand cmdDetallePedido = new SqlCommand();

                cn.Open();
                foreach (var item in listadt)
                {

                    string consultadt = "INSERT INTO DetallePedido VALUES(@IdDetallePedido,@Comida,@Cantidad,@CostoUnitario,@CostoTotal) WHERE IdPedido = @IdPedido";

                    cmdDetallePedido.Parameters.Clear();
                    cmdDetallePedido.Parameters.AddWithValue("@IdPedido", idpedido);
                    cmdDetallePedido.Parameters.AddWithValue("@IdDetallePedido", item.IdDetallePedido);
                    cmdDetallePedido.Parameters.AddWithValue("@Comida", item.Comida);
                    cmdDetallePedido.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmdDetallePedido.Parameters.AddWithValue("@CostoUnitario", item.CostoUnitario);
                    cmdDetallePedido.Parameters.AddWithValue("@CostoTotal", item.CostoTotal);
                    cmdDetallePedido.CommandType = CommandType.Text;
                    cmdDetallePedido.CommandText = consultadt;
                    //cmdDetallePedido.CommandType = CommandType.StoredProcedure;

                    cmdDetallePedido.Connection = cn;

                    cmdDetallePedido.ExecuteNonQuery();

                }

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
        public static void eliminarDetalles(int idpedido)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmdDetallePedido = new SqlCommand();

                string consultadt = "DELETE FROM DetallePedido WHERE IdPedido = @IdPedido";

                cmdDetallePedido.Parameters.Clear();
                cmdDetallePedido.Parameters.AddWithValue("@IdPedido", idpedido);

                cmdDetallePedido.CommandType = CommandType.Text;
                cmdDetallePedido.CommandText = consultadt;

                cn.Open();

                cmdDetallePedido.Connection = cn;

                cmdDetallePedido.ExecuteNonQuery();
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
        public static void eliminarDetallePedido(int iddetallepedido)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmdDetallePedido = new SqlCommand();

                string consultadt = "DELETE FROM DetallePedido WHERE IdDetallePedido = @IdDetallePedido";

                cmdDetallePedido.Parameters.Clear();
                cmdDetallePedido.Parameters.AddWithValue("@IdDetallePedido", iddetallepedido);

                cmdDetallePedido.CommandType = CommandType.Text;
                cmdDetallePedido.CommandText = consultadt;

                cn.Open();

                cmdDetallePedido.Connection = cn;

                cmdDetallePedido.ExecuteNonQuery();
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
