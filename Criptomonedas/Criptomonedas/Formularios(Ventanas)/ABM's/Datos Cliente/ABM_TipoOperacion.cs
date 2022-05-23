using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptomonedas.Entidades.Datos_Cliente;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s
{
    public partial class ABM_TipoOperacion : Form
    {
        public ABM_TipoOperacion()
        {
            InitializeComponent();
        }

        private void ABM_TipoOperacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarcmbCodigoOperacion();
            Limpiar();
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                String consulta = "SELECT * FROM Tipo_Transaccion";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdPais.DataSource = tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la grilla ...");
            }
            finally
            {
                cn.Close();
            }

        }


        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtTipoOperacion.Text = "";
            cmbCodigoOperacion.SelectedIndex = -1;
        }

        private bool validar_TipoOperacion(String tipoOperacion, String descripcion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();


                String consulta = "SELECT * FROM Tipo_Transaccion WHERE tipo_operacion like @TipoOperacion AND descripcion like @Descripcion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoOperacion", tipoOperacion);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla1);

                if (tabla1.Rows.Count > 0)
                {
                    resultado = true;
                }
                return resultado;
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

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ButtonConsulta_Click(object sender, EventArgs e)
        {
            if (txtTipoOperacion.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Datos !!!");
            }
            else
            {
                string TipoOperacion = txtTipoOperacion.Text;
                string Descripcion = txtDescripcion.Text;
                bool resultado = false;
                try
                {
                    resultado = validar_TipoOperacion(TipoOperacion, Descripcion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar los datos");
                }


                if (resultado == true)
                {
                    MessageBox.Show("Operacion existe");
                }
                else
                {
                    MessageBox.Show("No se encuetra datos");
                }
            }
        }

        private TipoOperacion ObtenerDatosT()
        {
            int cod = cmbCodigoOperacion.SelectedIndex + 1;
            TipoOperacion t = new TipoOperacion();
            t.tipo_operacion = txtTipoOperacion.Text.Trim();
            t.descripcion = txtDescripcion.Text.Trim();
            t.codigo_operacion = cod.ToString();
            return t;
        }

        private bool AgregarTipoOperacionBD(TipoOperacion t)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Tipo_Transaccion (tipo_operacion, descripcion) VALUES (@TipoOperacion, @Descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoOperacion", t.tipo_operacion);
                cmd.Parameters.AddWithValue("@Descripcion", t.descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Agregar dato");
            }
            finally { cn.Close(); }

            return result;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipoOperacion.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Datos !!!");
            }
            else
            {
                TipoOperacion t = ObtenerDatosT();
                bool result = AgregarTipoOperacionBD(t);

                if (result)
                {
                    MessageBox.Show("Tipo de Operacion agregada con exito.");
                    CargarGrilla();
                    CargarcmbCodigoOperacion();
                }
            }
        }

        private bool ActualizarTipoOperacion(TipoOperacion t)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Tipo_Transaccion SET tipo_operacion = @TipoOperacion, descripcion = @Descripcion WHERE codigo_operacion = @Codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoOperacion", t.tipo_operacion);
                cmd.Parameters.AddWithValue("@Descripcion", t.descripcion);
                cmd.Parameters.AddWithValue("@Codigo", t.codigo_operacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Modificar dato");
            }
            finally { cn.Close(); }

            return result;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtTipoOperacion.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Datos !!!");
            }
            else
            {
                TipoOperacion t = ObtenerDatosT();
                bool result = ActualizarTipoOperacion(t);

                if (result)
                {
                    MessageBox.Show("Tipo de Operacion agregada con exito.");
                    CargarGrilla();
                    CargarcmbCodigoOperacion();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CargarcmbCodigoOperacion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                String consulta = "SELECT * FROM Tipo_Transaccion";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCodigoOperacion.DataSource = tabla;
                cmbCodigoOperacion.DisplayMember = "codigo_operacion";
                cmbCodigoOperacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la Codigo Operacion ...");
            }
            finally
            {
                cn.Close();
            }
        }
    }

}


