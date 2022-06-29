using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.DAO
{
    public class TransaccionDAO
    {
        public static DataTable cargarTablaTransacciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Transacciones_por_monedas";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }

        }

        public static DataTable cargarTablaTransaccionesXCodCripto(int codCripto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Transacciones_por_monedas WHERE codigo_cripto = @codCripto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCripto", codCripto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
        }

        public static DataTable cargarTablaTransaccionesXTipoOperacion(int tipoOp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Transacciones_por_monedas WHERE tipo_operacion = @tipoOp";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoOp", tipoOp);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
        }

        public static DataTable cargarTablaTransaccionesXNroCliente(int nroCliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Transacciones_por_monedas WHERE nro_cliente = @nroCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCliente", nroCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
        }
    }
}
