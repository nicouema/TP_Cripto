using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Criptomonedas.DAO
{
    internal class CotizacionesDAO
    {
        internal static DataTable obtenerCotizacionesMes(string order)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT TOP 5 SUM(tm.cantidad_moneda) as Cantidad, c.nombre " +
                    "FROM Transacciones_por_monedas tm JOIN Criptomonedas c ON tm.codigo_cripto = c.codigo_cripto " +
                    "WHERE tm.tipo_operacion=1 " +
                    "GROUP BY c.nombre " +
                    "ORDER BY Cantidad " + order;

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
                MessageBox.Show("Error al obtener los datos de las cotizaciones! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static DataTable obtenerCotizacionesCripto(int codCriptoSelect)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT CONVERT(datetime2, CONVERT(CHAR(10), cm.fecha, 126) + ' ' + CONVERT(char(8), cm.hora, 126)) as fechahora, cm.valor " +
                    "FROM Cotizaciones_por_monedas cm " +
                    "WHERE codigo_cripto = @CodCripto " +
                    "ORDER BY fechaHora";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodCripto", codCriptoSelect);
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
                MessageBox.Show("Error al obtener los datos de las cotizaciones! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
