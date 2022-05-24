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

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Datos_Cliente
{
    public partial class ABM_Ciudad : Form
    {
        public ABM_Ciudad()
        {
            InitializeComponent();
        }


        private void ABM_Ciudades_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboProvincia();
            cargarGrilla();
        }

        // ---------------------------- FUNCIONES AUXILIARES -----------------------------
        // -- Metodo Cargar Ciudad en el ComboBox
        private void CargarComboProvincia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Provincias";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                cmbCodPvcia.DataSource = tabla;
                cmbCodPvcia.DisplayMember = "nombre_provincia";
                cmbCodPvcia.ValueMember = "cod_provincia";  
                cmbCodPvcia.SelectedIndex = -1;
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

        private bool DeleteProvinciasDB(Ciudad ciudad)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Ciudad WHERE cod_ciudad = @codCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCiudad", ciudad.NombreCiudad);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return result;
        }


        // -- Metodo Obtener Datos del Barrio
        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad c = new Ciudad();
            c.NombreCiudad = txtNombreCiudad.Text.Trim();
            c.CodProvincia = (int)cmbCodPvcia.SelectedValue;

            return c;
        }

        private bool AgregarCiudadCD(Ciudad c)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Ciudad (nombre_ciudad, cod_provincia) VALUES (@nombreCiudad, @codProvincia)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreCiudad", c.NombreCiudad);
                cmd.Parameters.AddWithValue("@codProvincia", c.CodProvincia);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return result;
        }


        // -- Método Limpiar Campos
        private void LimpiarCampos()
        {
            txtNombreCiudad.Text = "";
            cmbCodPvcia.SelectedIndex = -1;
        }

        // ---------------------------- BOTONES -----------------------------


        // -- Botón Limpiar Campos
        private void lblLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMinimizarPantallaReg_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarTipoDoc_Click(object sender, EventArgs e)
        {
            Ciudad c = ObtenerDatosCiudad();
            bool result = AgregarCiudadCD(c);

            if (result)
            {
                MessageBox.Show("Ciudad agregada con exito.");
                LimpiarCampos();
                CargarComboProvincia();
            }
            else
            {
                MessageBox.Show("Error al cargar ciudad.");
            }
        }

        private void cmbCodPvcia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void getTableGrillaCiudad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from Ciudad";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(tabla);

                grdCiudad.DataSource = tabla;
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

        private void cargarGrilla()
        {
            try
            {
                getTableGrillaCiudad();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("[ERROR - Provincias Form]: No se pudo traer el listado de provincias");
            }
        }
        private void CargarCampos(int txtCiudad, string txtProvincia)
        {
            txtNombreCiudad.Text = txtCiudad.ToString();
            cmbCodPvcia.SelectedIndex = int.Parse(txtProvincia);
        }
        // Click cell
        private void grillaProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = grdCiudad.Rows[indice];
                int txtCiudad = (int)filaSeleccionada.Cells["nombre_ciudad"].Value;

                string txtProvincia = (string)filaSeleccionada.Cells["cod_provincia"].Value;

                CargarCampos(txtCiudad, txtProvincia);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Ciudad provincias = ObtenerDatosCiudad();
            bool result = DeleteProvinciasDB(provincias);

            if (result)
            {
                MessageBox.Show("Provincia eliminada con exito.");
                LimpiarCampos();
                CargarComboProvincia();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al eliminar provincia.");
            }
        }
    }
}