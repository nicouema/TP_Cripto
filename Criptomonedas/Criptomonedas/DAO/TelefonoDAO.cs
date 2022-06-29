using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.DAO
{
    public class TelefonoDAO
    {
        public static DataTable cargarTablaTelefonos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Telefonos";
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

        public static DataTable cargarTablaTelefonosXCodPais(int codPais)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Telefonos WHERE cod_pais = @codPais";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPais", codPais);
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

        public static DataTable cargarTablaTelefonosXCodArea(int codArea)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Telefonos WHERE cod_area = @codArea";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codArea", codArea);
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
        
        public static DataTable cargarTablaTelefonosXNroCliente(int nroCliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Telefonos WHERE nro_cliente = @nroCliente";
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
