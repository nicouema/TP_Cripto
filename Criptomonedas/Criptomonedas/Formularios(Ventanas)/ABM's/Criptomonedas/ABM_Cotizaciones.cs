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
using Criptomonedas.Entidades.Criptomonedas;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Criptomonedas
{
    public partial class ABM_Cotizaciones : Form
    {
        public int codigoCotizacion; // Se usa para obtener el codigo de la cotizacion que el usuario selecciona en la grilla
        public ABM_Cotizaciones()
        {
            InitializeComponent();
        }

        private void ABM_Cotizaciones_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCripto();
            CargarGrilla();
        }

        // ---------------------------- FUNCIONES AUXILIARES -----------------------------
        // -- Metodo Cargar Ciudad en el ComboBox
        private void CargarComboCripto()
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

                cmbCriptomoneda.DataSource = tabla;
                cmbCriptomoneda.DisplayMember = "nombre";
                cmbCriptomoneda.ValueMember = "codigo_cripto";
                cmbCriptomoneda.SelectedIndex = -1;
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
        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Cotizaciones_por_monedas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                gdrCotizaciones.DataSource = tabla;
            }
            catch (Exception)
            {

            }
            finally { cn.Close(); }
        }
        // -- Metodo cargar campos del form
        private void CargarCampos(Cotizacion c)
        {
            txtValor.Text = c.Valor.ToString();
            cmbCriptomoneda.SelectedValue = c.CodCripto;
        }
        // -- Metodo Obtener Datos del Barrio del Forms
        private Cotizacion ObtenerDatosCotizacion()
        {
            Cotizacion c = new Cotizacion();
            c.Valor = float.Parse(txtValor.Text.Trim());
            c.CodCripto = (int)cmbCriptomoneda.SelectedValue;

            return c;
        }
        // -- Metodo de obtener datos del barrio de la BD
        private Cotizacion ObtenerDatosCotizacionBD(int codCotizacion)
        {
            Cotizacion c = new Cotizacion();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Cotizaciones_por_monedas WHERE id_cotizaciones like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", codCotizacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.Valor = float.Parse(dr["valor"].ToString());
                    c.CodCripto = int.Parse(dr["codigo_cripto"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return c;
        }
        // -- Metodo para agregar una cotizacion a la BD
        private bool AgregarCotizacionBD(Cotizacion c)
        {
            bool result = false;
            DateTime fecha = (DateTime)c.FechaHora;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Cotizaciones_por_monedas (codigo_cripto, fecha, hora, valor) VALUES (@codCripto, @fecha, @hora, @valorCotizacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@valorCotizacion", c.Valor);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@hora", fecha.TimeOfDay);
                cmd.Parameters.AddWithValue("@codCripto", c.CodCripto);
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
        // -- Metodo actualizar cotizacion de la BD
        private bool ActualizarBarrioBD(Cotizacion c)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Cotizaciones_por_monedas SET codigo_cripto=@codCripto, valor=@valor WHERE id_cotizaciones like @codigoCotizacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCripto", c.CodCripto);
                cmd.Parameters.AddWithValue("@valor", c.Valor);
                cmd.Parameters.AddWithValue("@codigoCotizacion", codigoCotizacion);
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
        // -- Metodo para eliminar una cotizacion de la BD
        private bool EliminarCotizacionBD()
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Cotizaciones_por_monedas WHERE id_cotizaciones like @codigoCotizacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoCotizacion", codigoCotizacion);
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
            txtValor.Text = "";
            cmbCriptomoneda.SelectedIndex = -1;
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
        // -- Boton de guardar datos de la cotizacion en la BD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cotizacion c = ObtenerDatosCotizacion();
            bool result = AgregarCotizacionBD(c);

            if (result)
            {
                MessageBox.Show("Cotizacion agregado con exito.");
                LimpiarCampos();
                CargarComboCripto();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar la cotizacion.");
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
            DataGridViewRow filaSeleccionada = gdrCotizaciones.Rows[indice];
            int codCotizacion = int.Parse(filaSeleccionada.Cells["id_cotizacion"].Value.ToString());

            Cotizacion c = ObtenerDatosCotizacionBD(codCotizacion);

            LimpiarCampos();
            CargarCampos(c);
            codigoCotizacion = codCotizacion;
        }
        // -- Boton para modificar los datos de una cotizacion seleccionada
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cotizacion c = ObtenerDatosCotizacion();
            bool result = ActualizarBarrioBD(c);

            if (result)
            {
                MessageBox.Show("Cotizacion actualizada con exito.");
                CargarGrilla();
                CargarComboCripto();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool result = EliminarCotizacionBD();

            if (result)
            {
                MessageBox.Show("Cotizacion eliminada con exito.");
                CargarGrilla();
                CargarComboCripto();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
    }
}
