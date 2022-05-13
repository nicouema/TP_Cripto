using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptomonedas.Entidades.Datos_Cliente;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Datos_Cliente
{
    public partial class ABM_AreaTelefono : Form
    {
        public ABM_AreaTelefono()
        {
            InitializeComponent();
            CargarComboPais();
            cargarGrilla();
        }

        private void ABM_AreaTelefonica_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        // ---------------------------- FUNCIONES AUXILIARES -----------------------------
        // -- Metodo Cargar País en el ComboBox
        private void CargarComboPais()
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

                cmb_AreaTelefono.DataSource = tabla;
                cmb_AreaTelefono.DisplayMember = "nombre_país";
                cmb_AreaTelefono.ValueMember = "cod_país";
                cmb_AreaTelefono.SelectedIndex = -1;
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


        public static DataTable getTableGrillaAreaTelefonica()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool result = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Area_telefonica ate inner join País p ON p.cod_país = ate.cod_país ";

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
                gridAreaTelefonica.DataSource = getTableGrillaAreaTelefonica();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("[ERROR - Area Telefonica Form]: No se pudo traer el listado de areas telefonicas");
            }
        }


        // -- Metodo Obtener Datos de la provincia
        private AreaTelefono ObtenerDatosAreaTelefono()
        {
            AreaTelefono b = new AreaTelefono();
            b.NombreArea = txtNombreArea.Text.Trim();
            b.CodigoPais = (int)cmb_AreaTelefono.SelectedValue;
            b.CodigoArea =  int.Parse( txtCodigoArea.Text.Trim() );

            return b;
        }

        private AreaTelefono ObtenerDatosAreaTelefono_Update()
        {
            AreaTelefono b = new AreaTelefono();
            b.NombreArea = txtNombreArea.Text.Trim();
            b.CodigoPais = (int)cmb_AreaTelefono.SelectedValue;
            b.CodigoArea = int.Parse(txtCodigoArea.Text.Trim());
            b.Id = int.Parse( idUpdate.Text.Trim() );

            return b;
        }


        private bool AgregarAreaTelefonoBD(AreaTelefono b)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Area_telefonica (cod_país, cod_area, nombre_area) VALUES (@codPaís, @codArea, @nombreArea)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPaís", b.CodigoPais);
                cmd.Parameters.AddWithValue("@codArea", b.CodigoArea);
                cmd.Parameters.AddWithValue("@nombreArea", b.NombreArea);
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

        private bool UpdateAreaTelefono(AreaTelefono areaTelefono)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Area_telefonica SET nombre_area=@nombreArea, cod_país = @codPais, cod_area = @codArea WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreArea", areaTelefono.NombreArea);
                cmd.Parameters.AddWithValue("@codPais", areaTelefono.CodigoPais);
                cmd.Parameters.AddWithValue("@codArea", areaTelefono.CodigoArea);
                cmd.Parameters.AddWithValue("@id", areaTelefono.Id);
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

        private bool DeleteProvinciasDB(AreaTelefono areaTelefono)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Area_telefonica WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", areaTelefono.Id);
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
            txtCodigoArea.Text = "";
            txtNombreArea.Text = "";
            cmb_AreaTelefono.SelectedIndex = -1;
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
            AreaTelefono b = ObtenerDatosAreaTelefono();
            bool result = AgregarAreaTelefonoBD(b);

            if (result)
            {
                MessageBox.Show("Área telefónica agregada con exito.");
                LimpiarCampos();
                CargarComboPais();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar área telefónica.");
            }
        }

        private void grillaAreaTelefonica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {

                AreaTelefono areaTelefono = new AreaTelefono();
                DataGridViewRow filaSeleccionada = gridAreaTelefonica.Rows[indice];

                areaTelefono.CodigoArea = (int)filaSeleccionada.Cells["cod_area"].Value;
                areaTelefono.Id = ((int)filaSeleccionada.Cells["id"].Value);
                areaTelefono.CodigoPais = ((int)filaSeleccionada.Cells["cod_país"].Value - 1);
                areaTelefono.NombreArea = (string)filaSeleccionada.Cells["nombre_area"].Value;

                CargarCampos(areaTelefono);

                //btnActualizar.Enabled = true;
                //cargarCampos(empleado);
                //btnCancelarLimpiar.Enabled = true;
                //btnEliminarEmpleado.Enabled = true;
            }
        }

        private void CargarCampos(AreaTelefono areaTelefono)
        {
            txtNombreArea.Text = areaTelefono.NombreArea;
            cmb_AreaTelefono.SelectedIndex = areaTelefono.CodigoPais;
            txtCodigoArea.Text = areaTelefono.CodigoArea.ToString();

            idUpdate.Text = areaTelefono.Id.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AreaTelefono areaTelefono = ObtenerDatosAreaTelefono_Update();
            bool result = UpdateAreaTelefono(areaTelefono);

            if (result)
            {
                MessageBox.Show("Área telefónica modificada con exito.");
                LimpiarCampos();
                cargarGrilla();
                CargarComboPais();
            }
            else
            {
                MessageBox.Show("Error al modificar área telefónica.");
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            AreaTelefono areaTelefono = ObtenerDatosAreaTelefono_Update();
            bool result = DeleteProvinciasDB(areaTelefono);

            if (result)
            {
                MessageBox.Show("Área telefónica eliminada con exito.");
                LimpiarCampos();
                CargarComboPais();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al eliminar área telefónica.");
            }
        }
    }
}
