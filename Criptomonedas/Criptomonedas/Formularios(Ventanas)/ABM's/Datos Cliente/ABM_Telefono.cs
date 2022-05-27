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
    public partial class ABM_Telefono : Form
    {
        public int codigoTelefono;
        public ABM_Telefono()
        {
            InitializeComponent();
            
        }
        private void Telefono_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboPais();
            CargarComboNroCliente();
            cargarGrilla();
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

                cmbCodigoPais.DataSource = tabla;
                cmbCodigoPais.DisplayMember = "nombre_país";
                cmbCodigoPais.ValueMember = "cod_país";
                cmbCodigoPais.SelectedIndex = -1;
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
        private void CargarComboNroCliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Clientes";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                cmbNroCliente.DataSource = tabla;
                cmbNroCliente.DisplayMember = "nro_cliente";
                cmbNroCliente.ValueMember = "nro_cliente";
                cmbNroCliente.SelectedIndex = -1;
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

            public void getTableGrillaTelefono()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * from Telefonos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(tabla);

                grdTelefono.DataSource = tabla;
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
                getTableGrillaTelefono();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("[ERROR - Telefono Form]: No se pudo traer el listado de telefonos");
            }
        }
        //Metodo cargar campos
        private void CargarCampos(Telefono t)
        {
            txtNroTelefono.Text = t.NroTelefono.ToString();
            cmbCodigoPais.SelectedValue = t.CodPais;
            txtCodigoArea.Text = t.CodArea.ToString();
            cmbNroCliente.SelectedValue = t.NroCliente;
            
        }


        // -- Metodo Obtener Datos de la provincia
        private Telefono ObtenerDatosTelefono()
        {
            Telefono b = new Telefono();
            b.NroTelefono = int.Parse(txtNroTelefono.Text);
            b.CodPais = (int)cmbCodigoPais.SelectedValue;
            b.NroCliente = (int)cmbNroCliente.SelectedValue;
            b.CodArea = int.Parse(txtCodigoArea.Text.Trim());

            return b;
        }

        private Telefono ObtenerDatosTelefonoBD(int codTelefono)
        {
            Telefono c = new Telefono();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Telefonos WHERE cod_telefono like @codTelefono";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTelefono", codTelefono);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.NroTelefono = int.Parse(dr["nro_telefono"].ToString());
                    c.CodPais = int.Parse(dr["cod_pais"].ToString());
                    c.CodArea = int.Parse(dr["cod_area"].ToString());
                    c.NroCliente = int.Parse(dr["nro_cliente"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return c;
        }

        // -- Metodo agregar telefono a la BD
        private bool AgregarTelefonoBD(Telefono b)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Telefonos (nro_telefono, cod_area, cod_pais, nro_cliente) VALUES (@nroTelefono, @codArea, @codPais, @nroCliente)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTelefono", b.NroTelefono);
                cmd.Parameters.AddWithValue("@codArea", b.CodArea);
                cmd.Parameters.AddWithValue("@codPais", b.CodPais);
                cmd.Parameters.AddWithValue("@nroCliente", b.NroCliente);
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

        // -- Metodo actualizar telefono de la BD
        private bool ActualizarTelefono(Telefono b)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Telefonos SET nro_telefono=@nroTelefono, cod_pais=@codPais, cod_area=@codArea, nro_cliente=@nroCliente WHERE cod_telefono like @codTelefono";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroTelefono", b.NroTelefono);
                cmd.Parameters.AddWithValue("@codPais", b.CodPais);
                cmd.Parameters.AddWithValue("@codArea", b.CodArea);
                cmd.Parameters.AddWithValue("@nroCliente", b.NroCliente);
                cmd.Parameters.AddWithValue("@codTelefono", codigoTelefono);
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

        private bool EliminarTelefonoBD()
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Telefonos WHERE cod_telefono = @codTelefono";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTelefono", codigoTelefono);
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
            txtNroTelefono.Text = "";
            txtCodigoArea.Text = "";
            cmbCodigoPais.SelectedIndex = -1;
            cmbNroCliente.SelectedIndex = -1;
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Telefono b = ObtenerDatosTelefono();
            bool result = AgregarTelefonoBD(b);

            if (result)
            {
                MessageBox.Show("Telefono agregado con exito.");
                LimpiarCampos();
                CargarComboPais();
                cargarGrilla();
                CargarComboNroCliente();
            }
            else
            {
                MessageBox.Show("Error al cargar telefono.");
            }
        }
        // Click cell
        private void gdrTelefono_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int indice = e.RowIndex;
                btnModificar.Enabled = true;
                btnModificar.Cursor = Cursors.Hand;
                btnEliminar.Enabled = true;
                btnEliminar.Cursor = Cursors.Hand;
                DataGridViewRow filaSeleccionada = grdTelefono.Rows[indice];
                codigoTelefono = int.Parse(filaSeleccionada.Cells["cod_telefono"].Value.ToString());

                    Telefono t = ObtenerDatosTelefonoBD(codigoTelefono);

                LimpiarCampos();
                CargarCampos(t);
            }
        }

        // -- Boton de actualizar datos cargados del telefono
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Telefono telefono = ObtenerDatosTelefono();
            bool result = ActualizarTelefono(telefono);

            if (result)
            {
                MessageBox.Show("Teléfono modificado con exito.");
                cargarGrilla();
                CargarComboPais();
                CargarComboNroCliente();
                LimpiarCampos();
                
            }
            else
            {
                MessageBox.Show("Error al modificar teléfono.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool result = EliminarTelefonoBD();

            if (result)
            {
                MessageBox.Show("Telefono eliminado con exito.");
                LimpiarCampos();
                CargarComboPais();
                cargarGrilla();
                CargarComboNroCliente();
                
            }
            else
            {
                MessageBox.Show("Error al eliminar Telefono.");
            }
        }

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
