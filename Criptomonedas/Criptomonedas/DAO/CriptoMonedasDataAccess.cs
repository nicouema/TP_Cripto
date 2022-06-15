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

        public static void guardarTransaccion(List<TransaccionPorMoneda> list)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlTransaction transaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                connection.Open();

                transaction = connection.BeginTransaction("AltaTransaccion");
                cmd.Transaction = transaction;
                foreach (TransaccionPorMoneda transaccionPorMoneda in list)
                {
                    if (transaccionPorMoneda.codMonedero == 0 && transaccionPorMoneda.codTipoTransaccion == 1)
                    {
                        string insertMonedero = "INSERT INTO Monedero (codigo_cripto, cantidad, nro_cliente) VALUES (@codCripto, @cant, @nroCliente)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codCripto", transaccionPorMoneda.codCripto);
                        cmd.Parameters.AddWithValue("@cant", transaccionPorMoneda.cantidadCripto);
                        cmd.Parameters.AddWithValue("@nroCliente", transaccionPorMoneda.nroCliente);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = insertMonedero;

                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();

                        string selectId = "SELECT MAX(cod_monedero) as Codigo FROM Monedero";
                        cmd.Parameters.Clear();
                        cmd.CommandText = selectId;
                        SqlDataReader readerId = cmd.ExecuteReader();

                        if (readerId.Read() && readerId != null)
                        {
                            transaccionPorMoneda.codMonedero = int.Parse(readerId["Codigo"].ToString());
                        }

                        readerId.Close();
                    }
                    else
                    {
                        string consulta = "SELECT m.cantidad FROM Monedero m WHERE m.cod_monedero like @CodMonedero";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CodMonedero", transaccionPorMoneda.codMonedero);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;

                        cmd.Connection = connection;
                        SqlDataReader reader = cmd.ExecuteReader();
                        decimal cantidadActual = 0;


                        if (reader.Read() && reader != null)
                        {
                            cantidadActual = decimal.Parse(reader["cantidad"].ToString());
                        }

                        reader.Close();

                        decimal nuevaCantidad = 0;
                        if (transaccionPorMoneda.codTipoTransaccion == 1)
                        {
                            nuevaCantidad = cantidadActual + transaccionPorMoneda.cantidadCripto;
                        }
                        if (transaccionPorMoneda.codTipoTransaccion == 2)
                        {
                            nuevaCantidad = cantidadActual - transaccionPorMoneda.cantidadCripto;
                        }

                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();

                        string actualizarMonedero = "UPDATE Monedero  " +
                                "SET cantidad=@NuevaCantidad " +
                                "WHERE cod_monedero=@CodMonedero";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                        cmd.Parameters.AddWithValue("CodMonedero", transaccionPorMoneda.codMonedero);

                        cmd.CommandText = actualizarMonedero;
                        cmd.ExecuteNonQuery();
                    }

                    string insert = "INSERT INTO Transacciones_por_monedas " +
                        "(nro_cliente,cod_monedero, codigo_cripto, tipo_operacion, cantidad_moneda, valor)" +
                        " values (@NroCliente, @CodMonedero, @CodCripto, @TipoOp, @Cantidad, @Valor)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NroCliente", transaccionPorMoneda.nroCliente);
                    cmd.Parameters.AddWithValue("@CodMonedero", transaccionPorMoneda.codMonedero);
                    cmd.Parameters.AddWithValue("@CodCripto", transaccionPorMoneda.codCripto);
                    cmd.Parameters.AddWithValue("@TipoOp", transaccionPorMoneda.codTipoTransaccion);
                    cmd.Parameters.AddWithValue("@Cantidad", transaccionPorMoneda.cantidadCripto);
                    cmd.Parameters.AddWithValue("@Valor", transaccionPorMoneda.valorCripto);
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();

                }

                transaction.Commit();
                return;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                connection.Close();

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

        public static DataTable ObtenerListadoCiudades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT C.*" +
                                  "FROM Ciudad C";


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
          
        public static DataTable ObtenerListadoCriptomonedasRestriccionCodigo(string inicio, string final)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Criptomonedas WHERE codigo_cripto BETWEEN @inicio AND @final";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@inicio", inicio);
                cmd.Parameters.AddWithValue("@final", final);
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

        public static DataTable ObtenerListadoCiudades2()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                                  "FROM Ciudad" +
                                  "WHERE cod_ciudad = 23";

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

                MessageBox.Show("Error al cargar consulta");
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerListadoAreaTelefonica()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Area_telefonica";

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

        public static DataTable ObtenerListadoMonedero()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                                  "FROM Monedero";


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


        public static DataTable ObtenerListadoAreaTelefonicaRestriccionArea(int codArea)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Area_telefonica WHERE cod_area = @codArea";

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
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerListadoCriptomonedas()
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

        public static DataTable obtenerListadoTransacciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tipo_Transaccion";

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

        public static DataTable obtenerListadoTelefonos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

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
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerDocumentoBD()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_documento";

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

        public static DataTable ObtenerDocumentoBDNombre(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_documento WHERE tipo_doc LIKE @nombre ";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
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

        public static DataTable ObtenerEjecutivoCuentasBD()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Ejecutivo_de_cuentas";

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
