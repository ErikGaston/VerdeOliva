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
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT MAX(IdPedido) FROM Pedido";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
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

        public static bool InsertarPedido(string direccion, int montototal, List<Entidad.DetallePedido> listadt)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlTransaction objTransacion = null;
            try
            {
                //SqlCommand cmdPedido = new SqlCommand("InsertarPedido",cn);
                SqlCommand cmdPedido = new SqlCommand();

                int idpedido = obtenerIdPedido() + 1;

                string consulta = "INSERT INTO Pedido VALUES(@IdPedido,@FechaHora,@Direccion,@MontoTotal)";
                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@IdPedido", idpedido);
                cmdPedido.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                cmdPedido.Parameters.AddWithValue("@Direccion", direccion);
                cmdPedido.Parameters.AddWithValue("@MontoTotal", montototal);
                cmdPedido.CommandType = CommandType.Text;
                cmdPedido.CommandText = consulta;

                cn.Open();

                objTransacion = cn.BeginTransaction("PedidoCreado");

                // cmdPedido.CommandType = CommandType.StoredProcedure;

                cmdPedido.Transaction = objTransacion;

                cmdPedido.Connection = cn;

                cmdPedido.ExecuteNonQuery();

                //SqlCommand cmdDetallePedido = new SqlCommand("InsertarDetallePedido", cn);
                SqlCommand cmdDetallePedido = new SqlCommand();

                foreach (var item in listadt) {

                    string consultadt = "INSERT INTO DetallePedido VALUES(@IdPedido,@IdDetallePedido,@Comida,@Cantidad,@CostoUnitario,@CostoTotal)";

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

                    cmdDetallePedido.Transaction = objTransacion;

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

        public static bool ModificarPedido(int idpedido,string direccion, int montototal, List<Entidad.DetallePedido> listadt)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlTransaction objTransacion = null;
            try
            {
                //SqlCommand cmdPedido = new SqlCommand("InsertarPedido",cn);
                SqlCommand cmdPedido = new SqlCommand();

                string consulta = "UPDATE Pedido SET FechaHora = @FechaHora, Direccion = @Direccion , MontoTotal = @MontoTotal WHERE IdPedido = @IdPedido";
                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@IdPedido", idpedido);
                cmdPedido.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                cmdPedido.Parameters.AddWithValue("@Direccion", direccion);
                cmdPedido.Parameters.AddWithValue("@MontoTotal", montototal);
                cmdPedido.CommandType = CommandType.Text;
                cmdPedido.CommandText = consulta;

                cn.Open();
                objTransacion = cn.BeginTransaction("PedidoModificado");

                cmdPedido.Transaction = objTransacion;
                // cmdPedido.CommandType = CommandType.StoredProcedure;


                cmdPedido.Connection = cn;

                cmdPedido.ExecuteNonQuery();

                //SqlCommand cmdDetallePedido = new SqlCommand("InsertarDetallePedido", cn);
                SqlCommand cmdDetallePedido = new SqlCommand();

                foreach (var item in listadt)
                {

                    string consultadt = "UPDATE DetallePedido SET Comida = @Comida, Cantidad = @Cantidad, CostoUnitario = @CostoUnitario, CostoTotal = @CostoTotal WHERE IdPedido = @IdPedido, IdDetallePedido = @IdDetallePedido,";

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

                    cmdDetallePedido.Transaction = objTransacion;

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

        public static bool eliminarPedido(int idpedido)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            try
            {
                SqlCommand cmdPedido = new SqlCommand();

                /* ELIMINO DETALLES */
                DetallePedido.eliminarDetalles(idpedido);

                string consulta = "DELETE FROM Pedido WHERE IdPedido = @IdPedido";
                cmdPedido.Parameters.Clear();
                cmdPedido.Parameters.AddWithValue("@IdPedido", idpedido);

                cmdPedido.CommandType = CommandType.Text;
                cmdPedido.CommandText = consulta;

                cn.Open();

                cmdPedido.Connection = cn;


                cmdPedido.ExecuteNonQuery();

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

        public static DataTable obtenerPedidos(int nropedido)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT * FROM Pedido where IdPedido = @nropedido";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nropedido", nropedido);

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
        public static DataTable obtenerPedidosFecha(DateTime desde, DateTime hasta)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT * FROM Pedido WHERE FechaHora  >= @desde AND FechaHora <= @hasta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);

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
        public static DataTable obtenerDireccion()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["bd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("", cn);
            try
            {
                string consulta = "SELECT Direccion FROM Pedido";

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


