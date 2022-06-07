using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptomonedas.Entidades;
using Criptomonedas.Entidades.Criptomonedas;
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

                cliente.NroCliente = (int)tabla.Rows[0]["nro_cliente"];
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
                MessageBox.Show("Error al obtener los datos del cliente! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        public static decimal getValorById(int codigoCripto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.valor " +
                    "FROM Cotizaciones_por_monedas c " +
                    "WHERE c.codigo_cripto like @CodCripto " +
                    "AND c.fecha = (SELECT " +
                    "               MAX(c.fecha) " +
                    "               FROM Cotizaciones_por_monedas c" +
                    "               WHERE c.codigo_cripto like @CodCripto)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodCripto", codigoCripto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return (decimal)tabla.Rows[0]["valor"];
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la criptomoneda! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }


        internal static string getCriptoNameById(int codigoCripto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.nombre " +
                    "FROM Criptomonedas c " +
                    "WHERE c.codigo_cripto like @CodCripto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodCripto", codigoCripto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return (string)tabla.Rows[0]["nombre"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del cliente! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Monedero obtenerMonederoDeCliente(Cliente clienteEnSesion, int cod_cripto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Monedero monedero = new Monedero();
            monedero.NroCliente = clienteEnSesion.NroCliente;
            monedero.CodigoCripto = cod_cripto;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT m.* " +
                    "FROM Monedero m JOIN Clientes c ON c.nro_cliente=m.nro_cliente " +
                    "WHERE c.nro_cliente like @NumCliente " +
                    "AND " +
                    "m.codigo_cripto like @CodCripto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumCliente", clienteEnSesion.NroCliente);
                cmd.Parameters.AddWithValue("@CodCripto", cod_cripto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count > 0)
                {
                    monedero.CantidadCripto = (decimal)tabla.Rows[0]["cantidad"];
                    monedero.Id = (int)tabla.Rows[0]["cod_monedero"];
                    return monedero;
                }

                monedero.CantidadCripto = 0;

                return monedero;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del monedero! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
                    "JOIN Criptomonedas c ON cm.codigo_cripto=c.codigo_cripto " +
                    "AND cm.fecha = (SELECT MAX(c.fecha) FROM Cotizaciones_por_monedas c WHERE c.codigo_cripto=cm.codigo_cripto)";

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
                MessageBox.Show("Error al obtener los datos de las cotizaciones! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void CargarComboCriptoDeMonederos(ComboBox combo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.* " +
                    "FROM Criptomonedas c JOIN Monedero m ON c.codigo_cripto=m.codigo_cripto";

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de las criptomonedas! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
        public static void CargarComboCripto(ComboBox combo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.* " +
                    "FROM Criptomonedas c";

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de las criptomonedas! " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
