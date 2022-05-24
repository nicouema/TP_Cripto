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
    public partial class ABM_Barrio : Form
    {
        public int codigoBarrio; // Se usa para obtener el codigo del barrio que el usuario selecciona en la grilla
        public ABM_Barrio()
        {
            InitializeComponent();
        }
        private void ABM_Barrio_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCiudad();
            CargarGrilla();
        }

        // ---------------------------- FUNCIONES AUXILIARES -----------------------------
        // -- Metodo cargar datos de la BD a la grilla
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT cod_barrio, nombre_barrio, cod_ciudad FROM Barrio";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                
                gdrBarrio.DataSource = tabla;
            }
            catch (Exception)
            {

            }
            finally { cn.Close(); }
        }

        // -- Metodo Cargar Ciudad en el ComboBox
        private void CargarComboCiudad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ciudad";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                cmbCiudadBarrio.DataSource = tabla;
                cmbCiudadBarrio.DisplayMember = "nombre_ciudad";
                cmbCiudadBarrio.ValueMember = "cod_ciudad";
                cmbCiudadBarrio.SelectedIndex = -1;
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
        // -- Metodo cargar campos del form
        private void CargarCampos(Barrio b)
        {
            txtNombreBarrio.Text = b.NombreBarrio;
            cmbCiudadBarrio.SelectedValue = b.CodCiudad;
        }
        // -- Metodo Obtener Datos del Barrio del Forms
        private Barrio ObtenerDatosBarrio()
        {
            Barrio b = new Barrio();
            b.NombreBarrio = txtNombreBarrio.Text.Trim();
            b.CodCiudad = (int)cmbCiudadBarrio.SelectedValue;

            return b;
        }
        // -- Metodo de obtener datos del barrio de la BD
        private Barrio ObtenerDatosBarrioBD(int codBarrio)
        {
            Barrio b = new Barrio();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Barrio WHERE cod_barrio like @codBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", codBarrio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.NombreBarrio = dr["nombre_barrio"].ToString();
                    b.CodCiudad = int.Parse(dr["cod_ciudad"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return b;
        }
        // -- Metodo agregar barrio a la BD
        private bool AgregarBarrioBD(Barrio b) 
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Barrio (nombre_barrio, cod_ciudad) VALUES (@nombreBarrio, @codCiudad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBarrio", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@codCiudad", b.CodCiudad);
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
        private bool ActualizarBarrioBD(Barrio b)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Barrio SET nombre_barrio=@nombreBarrio, cod_ciudad=@codCiudad WHERE cod_barrio like @codBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBarrio", b.NombreBarrio);
                cmd.Parameters.AddWithValue("@codCiudad", b.CodCiudad);
                cmd.Parameters.AddWithValue("@codBarrio", codigoBarrio);
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
        private bool EliminarBarrioBD()
        {
            bool result= false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Barrio WHERE cod_barrio like @codBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", codigoBarrio);
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
            txtNombreBarrio.Text = "";
            cmbCiudadBarrio.SelectedIndex = -1;
        }

        // ---------------------------- BOTONES -----------------------------


        // -- Botón Limpiar Campos
        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        // -- Boton cerrar ventana del abm
        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // -- Boton de minimizar ventana del abm
        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        // -- Boton de Guardar los datos cargados del barrio
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool result = AgregarBarrioBD(b);

            if (result)
            {
                MessageBox.Show("Barrio agregado con exito.");
                LimpiarCampos();
                CargarComboCiudad();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar barrio.");
            }
        }
        // -- Al hacer click en una fila de la grilla
        private void gdrBarrio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificar.Enabled = true;
            btnModificar.Cursor = Cursors.Hand;
            btnEliminar.Enabled = true;
            btnEliminar.Cursor = Cursors.Hand;
            DataGridViewRow filaSeleccionada = gdrBarrio.Rows[indice];
            int codBarrio = int.Parse(filaSeleccionada.Cells["Codigo_Barrio"].Value.ToString());

            Barrio b = ObtenerDatosBarrioBD(codBarrio);

            LimpiarCampos();
            CargarCampos(b);
            codigoBarrio = codBarrio;
        }
        // -- Boton de actualizar datos cargados del barrio
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool result = ActualizarBarrioBD(b);

            if (result)
            {
                MessageBox.Show("Barrio actualizado con exito.");
                CargarGrilla();
                CargarComboCiudad();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        // -- Boton para eliminar un dato de la BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool result = EliminarBarrioBD();

            if (result)
            {
                MessageBox.Show("Barrio eliminado con exito.");
                CargarGrilla();
                CargarComboCiudad();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void gdrBarrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
