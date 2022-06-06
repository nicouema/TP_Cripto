using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptomonedas.Entidades;
using Criptomonedas.Entidades.Datos_Cliente;
using RJCodeAdvance.RJControls;

namespace Criptomonedas.DAO
{
    public class CriptoMonedasDataAccess
    {
        public static Cliente BuscarClientePorUsuario(Usuario usuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.* " +
                    "FROM Clientes c JOIN Usuarios u ON c.cod_usuario=u.id_usuario " +
                    "WHERE u.NombreDeUsuario like @NombreUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.User);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                Cliente cliente = new Cliente();

                cliente.nombre = (string)tabla.Rows[0]["nombre"];
                cliente.apellido = (string)tabla.Rows[0]["apellido"];
                cliente.email = (string)tabla.Rows[0]["email"];
                cliente.fechaAlta = (DateTime)tabla.Rows[0]["fecha_alta"];
                cliente.cod_barrio = (int)tabla.Rows[0]["cod_barrio"];
                cliente.cod_usuario = (int)tabla.Rows[0]["cod_usuario"];

                return cliente;

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

        public static void cargarGrillaCriptomonedas(DataGridView grilla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT cm.valor, c.nombre " +
                    "FROM Cotizaciones_por_monedas cm " +
                    "JOIN Criptomonedas c ON cm.codigo_cripto=c.codigo_cripto";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grilla.DataSource = tabla;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cotizaciones! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void CargarComboCripto(RJComboBox combo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Criptomonedas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                combo.DataSource = tabla;
                combo.DisplayMember = "nombre";
                combo.ValueMember = "codigo_cripto";
                combo.SelectedIndex = -1;
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
