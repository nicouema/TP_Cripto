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
    public partial class ABM_Monedero : Form
    {
        public int codigoMonedero;
        public ABM_Monedero()
        {
            InitializeComponent();
        }

        private void ABM_Monedero_Load(object sender, EventArgs e)
        {

            LimpiarCampos();
            CargarComboCodigoCripto();
            CargarComboNroCliente();
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
                string consulta = "SELECT cod_monedero, codigo_cripto, cantidad, nro_cliente FROM Monedero";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);

                grdMonedero.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grdMonedero");

            }
            finally { cn.Close(); }
        }

        // -- Metodo Cargar Codigo Cripto en el ComboBox
        private void CargarComboCodigoCripto()
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

                cmbCodCripto.DataSource = tabla;
                cmbCodCripto.DisplayMember = "siglas_cripto";
                cmbCodCripto.ValueMember = "codigo_cripto";
                cmbCodCripto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cmbCodigoCripto");
            }
            finally
            {
                cn.Close();
            }
        }

        // -- Metodo Cargar Nro Cliente en el ComboBox
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
        // -- Metodo cargar campos del form
        private void CargarCampos(Monedero m)
        {
            cmbCodCripto.SelectedValue = m.CodigoCripto;
            txtCantPrueba.Text = m.CantidadCripto.ToString();
            cmbNroCliente.SelectedValue = m.NroCliente;
        }
        // -- Metodo Obtener Datos del Monedero del Forms
        private Monedero ObtenerDatosMonedero()
        {
            Monedero m = new Monedero();
            m.CodigoCripto = (int)cmbCodCripto.SelectedValue;
            try
            {
                m.CantidadCripto = decimal.Parse(txtCantPrueba.Text);

            }

            catch (Exception)
            {
                throw;
            }
            m.NroCliente = (int)cmbNroCliente.SelectedValue;

            return m;
        }
        // -- Metodo de obtener datos del Monedero de la BD
        private Monedero ObtenerDatosMonederoBD(int codMonedero)
        {
            Monedero m = new Monedero();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Monedero WHERE cod_monedero like @codMonedero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codMonedero", codMonedero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    m.CodigoCripto = int.Parse(dr["codigo_cripto"].ToString());
                    m.CantidadCripto = decimal.Parse(dr["cantidad"].ToString());
                    m.NroCliente = int.Parse(dr["nro_cliente"].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problema al obtener datos de BD");
            }
            finally { cn.Close(); }

            return m;
        }
        // -- Metodo agregar barrio a la BD
        private bool AgregarMonederoBD(Monedero m)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Monedero (codigo_cripto, cantidad, nro_cliente) VALUES (@codCripto, @cant, @nroCliente)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCripto", m.CodigoCripto);
                cmd.Parameters.AddWithValue("@cant", m.CantidadCripto);
                cmd.Parameters.AddWithValue("@nroCliente", m.NroCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Monedero a Base de Datos");
            }
            finally { cn.Close(); }

            return result;
        }
        // -- Metodo actualizar barrio de la BD
        private bool ActualizarMonederoBD(Monedero m)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Monedero SET codigo_cripto=@codCripto, cantidad=@cant, nro_cliente = @nroCliente WHERE cod_monedero like @codMonedero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCripto", m.CodigoCripto);
                cmd.Parameters.AddWithValue("@cant", m.CantidadCripto);
                cmd.Parameters.AddWithValue("@nroCliente", m.NroCliente);
                cmd.Parameters.AddWithValue("@codMonedero", codigoMonedero);
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
        private bool EliminarMonederoBD()
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Monedero WHERE cod_monedero like @codMonedero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codMonedero", codigoMonedero);
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
            cmbCodCripto.SelectedValue = -1;
            txtCantPrueba.Text = "";
            cmbNroCliente.SelectedIndex = -1;
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
            try
            {
                Monedero m = ObtenerDatosMonedero();
                bool result = AgregarMonederoBD(m);

                if (result)
                {
                    MessageBox.Show("Monedero cargado con éxito!");
                    LimpiarCampos();
                    CargarComboCodigoCripto();
                    CargarComboNroCliente();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al dar de alta Monedero");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! Formato Inválido");
            }
            

            
        }
        // -- Al hacer click en una fila de la grilla
        private void grdMonedero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificar.Enabled = true;
            btnModificar.Cursor = Cursors.Hand;
            btnEliminar.Enabled = true;
            btnEliminar.Cursor = Cursors.Hand;
            DataGridViewRow filaSeleccionada = grdMonedero.Rows[indice];
            int codMonedero = int.Parse(filaSeleccionada.Cells["Codigo_Monedero"].Value.ToString());

            Monedero m = ObtenerDatosMonederoBD(codMonedero);

            LimpiarCampos();
            CargarCampos(m);
            codigoMonedero = codMonedero;
        }
        // -- Boton de actualizar datos cargados del barrio
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Monedero m = ObtenerDatosMonedero();
            bool result = ActualizarMonederoBD(m);

            if (result)
            {
                MessageBox.Show("Monedero actualizado con exito.");
                CargarGrilla();
                CargarComboCodigoCripto();
                CargarComboNroCliente();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        // -- Boton para eliminar un dato de la BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool result = EliminarMonederoBD();

            if (result)
            {
                MessageBox.Show("Monedero eliminado con exito.");
                CargarGrilla();
                CargarComboCodigoCripto();
                CargarComboNroCliente();
                LimpiarCampos();

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

       
    }
}

