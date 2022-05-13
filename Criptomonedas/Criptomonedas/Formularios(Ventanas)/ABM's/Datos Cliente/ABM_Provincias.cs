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
    public partial class ABM_Provincias : Form
    {
        public ABM_Provincias()
        {
            InitializeComponent();
        }

        private void ABM_Provincias_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboProvincia();
            cargarGrilla();
        }


        // -- Método Limpiar Campos
        private void LimpiarCampos()
        {
            txtNombreProv.Text = "";
            cmbProvCiudad.SelectedIndex = -1;
        }

        private void CargarCampos(int id, int comboId, string txtProvincia)
        {
            txtNombreProv.Text = txtProvincia;
            cmbProvCiudad.SelectedIndex = comboId;
            idUpdate.Text = id.ToString();
        }


        // Click cell
        private void grillaProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = gridProvincias.Rows[indice];
                int id = (int)filaSeleccionada.Cells["cod_provincia"].Value;

                int comboId = ((int)filaSeleccionada.Cells["cod_país"].Value - 1);
                string txtProvincia = (string)filaSeleccionada.Cells["nombre_provincia"].Value;

                CargarCampos(id, comboId, txtProvincia);

                //btnActualizar.Enabled = true;
                //cargarCampos(empleado);
                //btnCancelarLimpiar.Enabled = true;
                //btnEliminarEmpleado.Enabled = true;
            }
        }



        // ---------------------------- FUNCIONES AUXILIARES -----------------------------
        // -- Metodo Cargar Provincia en el ComboBox
        private void CargarComboProvincia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM País";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                cmbProvCiudad.DataSource = tabla;
                cmbProvCiudad.DisplayMember = "nombre_país";
                cmbProvCiudad.ValueMember = "cod_país";
                cmbProvCiudad.SelectedIndex = -1;
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


        public static DataTable getTableGrillaProvincia( )
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool result = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "Select cod_provincia, nombre_provincia, p.nombre_país, p.cod_país from provincias pv inner join País p on pv.cod_país = p.cod_país";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(tabla);

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

        private void cargarGrilla()
        {
            try
            {
                gridProvincias.DataSource = getTableGrillaProvincia();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("[ERROR - Provincias Form]: No se pudo traer el listado de provincias");
            }
        }


        // -- Metodo Obtener Datos de la provincia
        private Provincias ObtenerDatosProvincias()
        {
            Provincias b = new Provincias();
            b.NombreProvincia = txtNombreProv.Text.Trim();
            b.CodigoPais = (int)cmbProvCiudad.SelectedValue;

            return b;
        }

        private Provincias ObtenerDatosProvincias_Update()
        {
            Provincias provincias = new Provincias();
            provincias.NombreProvincia = txtNombreProv.Text.Trim();
            provincias.CodigoPais = (int)cmbProvCiudad.SelectedValue;

            provincias.CodigoProvincia = int.Parse(idUpdate.Text);


            return provincias;
        }

        private bool AgregarProvinciasBD(Provincias b)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Provincias (nombre_provincia, cod_país) VALUES (@nombreProvincia, @codPais)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreProvincia", b.NombreProvincia);
                cmd.Parameters.AddWithValue("@codPais", b.CodigoPais);
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

        private bool UpdateProvinciasDB(Provincias provincias)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Provincias SET nombre_provincia=@nombreProvincia, cod_país = @codPais WHERE cod_provincia = @codProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreProvincia", provincias.NombreProvincia);
                cmd.Parameters.AddWithValue("@codPais", provincias.CodigoPais);
                cmd.Parameters.AddWithValue("@codProvincia", provincias.CodigoProvincia);
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

        private bool DeleteProvinciasDB(Provincias provincias)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Provincias WHERE cod_provincia = @codProvincia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProvincia", provincias.CodigoProvincia);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("La provincia que desea borrar está siendo utilizada por otra ciudad ");
            }
            finally { cn.Close(); }

            return result;
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Provincias b = ObtenerDatosProvincias();
            bool result = AgregarProvinciasBD(b);

            if (result)
            {
                MessageBox.Show("Provincia agregada con exito.");
                LimpiarCampos();
                CargarComboProvincia();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar provincia.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Provincias provincias = ObtenerDatosProvincias_Update();
            bool result = UpdateProvinciasDB(provincias);

            if (result)
            {
                MessageBox.Show("Provincia modificada con exito.");
                LimpiarCampos();
                CargarComboProvincia();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al modificar provincia.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Provincias provincias = ObtenerDatosProvincias_Update();
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
