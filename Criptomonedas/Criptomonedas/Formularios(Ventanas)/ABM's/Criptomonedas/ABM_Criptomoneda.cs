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

namespace Criptomonedas
{
    public partial class ABM_Criptomoneda : Form
    {
        private string idSeleccionado;
        public ABM_Criptomoneda()
        {
            InitializeComponent();
        }

        private void ABM_Criptomoneda_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            try
            {
                cargarGrillaCriptos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de criptomonedas", "ALERTA");
            }

        }

        //Grilla

        private void cargarGrillaCriptos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "cargarGrillaCriptos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdCriptos.DataSource = tabla;


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

        private void grdCriptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = grdCriptos.Rows[indice];
                idSeleccionado = filaSeleccionada.Cells["ID"].Value.ToString();
                Entidades.Criptomonedas.Criptomoneda cripto = ObtenerDatosCriptoBD(idSeleccionado);
                LimpiarCampos();
                cargarCampos(cripto);
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar criptomoneda");
            }
            

            
        }

        //Botones

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Entidades.Criptomonedas.Criptomoneda cripto = ObtenerDatosCriptoDelABM();
            if (validarCampos())
            {
                try
                {
                    bool resultado = AgregarCriptomoneda(cripto);
                    if (resultado)
                    {
                        MessageBox.Show("Criptomoneda agregada con éxito");
                        LimpiarCampos();
                        cargarGrillaCriptos();
                        btnActualizar.Enabled = false;
                        btnBorrar.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar nueva criptomoneda", "ALERTA");
                }
            }
        }
            

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Entidades.Criptomonedas.Criptomoneda cripto = ObtenerDatosCriptoDelABM();
            if (validarCampos())
            {
                try
                {
                    bool resultado = ActualizarCriptomoneda(cripto);
                    if (resultado)
                    {
                        MessageBox.Show("Criptomoneda actualizada con exito");
                        LimpiarCampos();
                        cargarGrillaCriptos();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar criptomoneda", "ALERTA");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    eliminarCripto(int.Parse(idSeleccionado));
                    cargarGrillaCriptos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Criptomoneda!", "Alerta");
                }

            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Metodos para obtener datos

        private Entidades.Criptomonedas.Criptomoneda ObtenerDatosCriptoBD(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Entidades.Criptomonedas.Criptomoneda cripto = new Entidades.Criptomonedas.Criptomoneda();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "datosCripto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo_cripto", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader != null && reader.Read())
                {
                    cripto.Sigla = reader["siglas_cripto"].ToString();
                    cripto.NombreCripto = reader["nombre"].ToString();
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }


            return cripto;
        }

        private Entidades.Criptomonedas.Criptomoneda ObtenerDatosCriptoDelABM()
        {
            Entidades.Criptomonedas.Criptomoneda cripto = new Entidades.Criptomonedas.Criptomoneda();
            cripto.Sigla = txtSigla.Text.Trim();
            cripto.NombreCripto = txtNombreCripto.Text.Trim();
            cripto.ID = int.Parse(idSeleccionado.ToString());
            return cripto;
        }

        //Metodos para BD

        private bool AgregarCriptomoneda(Entidades.Criptomonedas.Criptomoneda cripto)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarCriptomoneda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@siglas_cripto", cripto.Sigla);
                cmd.Parameters.AddWithValue("@nombre", cripto.NombreCripto);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private bool ActualizarCriptomoneda(Entidades.Criptomonedas.Criptomoneda cripto)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "actualizarCripto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo_cripto", cripto.ID);
                cmd.Parameters.AddWithValue("@siglas_cripto", cripto.Sigla);
                cmd.Parameters.AddWithValue("@nombre", cripto.NombreCripto);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private bool eliminarCripto(int id)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string delete = "eliminarCripto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = delete;

                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                resultado = true;

                MessageBox.Show("Criptomoneda eliminada con exito", "Eliminado", MessageBoxButtons.OK);
                cargarGrillaCriptos();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return resultado;
        }

        //Cargar y limpiar campos

        private void cargarCampos(Entidades.Criptomonedas.Criptomoneda cripto)
        {
            txtNombreCripto.Text = cripto.NombreCripto;
            txtSigla.Text = cripto.Sigla;
        }

        private void LimpiarCampos()
        {
            txtNombreCripto.Text = "";
            txtSigla.Text = "";
        }

        //Minimizar y cerrar

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Validaciones

        private bool validarCampos()
        {
            if (txtNombreCripto.Text.Equals("") || txtSigla.Text.Equals(""))
            {
                MessageBox.Show("Rellenar campos", "Alerta");
                return false;
            }
            return true;
        }
    }
}