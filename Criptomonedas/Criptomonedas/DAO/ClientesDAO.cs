using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.DAO
{
    public class ClientesDAO
    {
        public static DataTable CargarTablaCliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Clientes";

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
            finally
            {
                cn.Close();
            }

        }

        public static DataTable CargarTablaClientePorMail(string filtroMail)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Clientes c " +
                                  "WHERE c.email like @Mail";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Mail", filtroMail);
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
            finally
            {
                cn.Close();
            }
        }

        public static DataTable CargarTablaClientePorNombreCompleto(string filtroNombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select c.* " +
                    "FROM Clientes c " +
                    "WHERE CONCAT(c.nombre, ' ', c.apellido) like @NombreCompleto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreCompleto", "%" + filtroNombre + "%");
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
            finally
            {
                cn.Close();
            }
        }

        public static DataTable CargarTablaClientePorFechaAlta(DateTime fechaDesde, DateTime fechaHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Clientes c " +
                                  "WHERE c.fecha_alta between @FechaDesde and @FechaHasta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
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
            finally
            {
                cn.Close();
            }
        }

        public static DataTable obtenerClientesXProvincia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT P.nombre_provincia as Provincia, COUNT(C.nro_cliente) as Cantidad " +
                                  "FROM Clientes C JOIN Barrio B ON (C.cod_barrio=B.cod_barrio) JOIN Ciudad Ci ON (B.cod_ciudad = Ci.cod_ciudad) JOIN Provincias P ON (Ci.cod_provincia = P.cod_provincia) " +
                                  "GROUP BY P.nombre_provincia";

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
