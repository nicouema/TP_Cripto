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
        public int codigoCiudad;// Se usa para obtener el codigo del barrio que el usuario selecciona en la grilla
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
        // -- Metodo cargar datos de la BD a la grilla
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
                MessageBox.Show("[ERROR - Ciudad Form]: No se pudo traer el listado de ciudades");
            }
        }
        // Metodo cargar campos del form
        private void CargarCampos(Ciudad c)
        {
            txtNombreCiudad.Text = c.NombreCiudad;
            cmbCodPvcia.SelectedValue = c.CodProvincia;
        }

        // -- Metodo Obtener Datos del Barrio
        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad c = new Ciudad();
            c.NombreCiudad = txtNombreCiudad.Text.Trim();
            c.CodProvincia = (int)cmbCodPvcia.SelectedValue;

            return c;
        }

        // -- Metodo de obtener datos del barrio de la BD
        private Ciudad ObtenerDatosCiudadBD(int codCiudad)
        {
            Ciudad c = new Ciudad();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Ciudad WHERE cod_ciudad like @codCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCiudad", codCiudad);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.NombreCiudad = dr["nombre_ciudad"].ToString();
                    c.CodProvincia = int.Parse(dr["cod_provincia"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return c;
        }
        // -- Metodo agregar ciudad a la BD
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
        // -- Metodo actualizar barrio de la BD
        private bool ActualizarCiudadBD(Ciudad c)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Ciudad SET nombre_ciudad=@nombreCiudad, cod_provincia=@codProvincia WHERE cod_ciudad like @codCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreCiudad", c.NombreCiudad);
                cmd.Parameters.AddWithValue("@codProvincia", c.CodProvincia);
                cmd.Parameters.AddWithValue("@codCiudad", codigoCiudad);
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
        // -- Metodo para eliminar un barrio de la BD
        private bool EliminarCiudadBD()
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Ciudad WHERE cod_ciudad like @codCiudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCiudad", codigoCiudad);
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
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar ciudad.");
            }
        }

        private void cmbCodPvcia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Click cell

        private void gdrCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int indice = e.RowIndex;
                btnModificar.Enabled = true;
                btnModificar.Cursor = Cursors.Hand;
                btnEliminar.Enabled = true;
                btnEliminar.Cursor = Cursors.Hand;
                DataGridViewRow filaSeleccionada = grdCiudad.Rows[indice];
                int codCiudad = int.Parse(filaSeleccionada.Cells["id"].Value.ToString());

                Ciudad c = ObtenerDatosCiudadBD(codCiudad);

                LimpiarCampos();
                CargarCampos(c);
                codigoCiudad = codCiudad;
            }
        }
        // -- Boton de actualizar datos cargados del barrio
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Ciudad c = ObtenerDatosCiudad();
            bool result = ActualizarCiudadBD(c);

            if (result)
            {
                MessageBox.Show("Ciudad actualizada con exito.");
                cargarGrilla();
                CargarComboProvincia();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool result = EliminarCiudadBD();

            if (result)
            {
                MessageBox.Show("Ciudad eliminada con exito.");
                cargarGrilla();
                CargarComboProvincia();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void grdCiudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}