
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

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Ejecutivo_de_Cuentas
{
    public partial class ABM_EmpresasEdC : Form
    {
        public ABM_EmpresasEdC()
        {
            InitializeComponent();
        }

        private void ABM_EmpresasEdC_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            try
            {
                cargarGrillaEmpresas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de empresas", "ALERTA");
            }
        }

        //Grilla

        private void cargarGrillaEmpresas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "cargarGrillaEmpresas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdEmpresasEdC.DataSource = tabla;


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

        private void grdEmpresasEdC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdEmpresasEdC.Rows[indice];
            string id = filaSeleccionada.Cells["ID"].Value.ToString();
            Entidades.Ejecutivo_de_Cuentas.Empresa emp = ObtenerDatosEmpresaBD(id);
            LimpiarCampos();
            cargarCampos(emp);

            btnActualizar.Enabled = true;
        }

        //Cargar y limpiar campos

        private void cargarCampos(Entidades.Ejecutivo_de_Cuentas.Empresa e)
        {
            txtNombreEmpresa.Text = e.NombreEmpresa;
            txtCalle.Text = e.Calle;
            mbNroCalle.Text = e.NumCalle.ToString();
            mbCodBarrio.Text = e.CodBarrio.ToString();
        }

        private void LimpiarCampos()
        {
            txtNombreEmpresa.Text = "";
            txtCalle.Text = "";
            mbNroCalle.Text = "";
            mbCodBarrio.Text = "";
        }

        //Minimizar y cerrar

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botones
        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Entidades.Ejecutivo_de_Cuentas.Empresa emp = ObtenerDatosEmpresaDelABM();
            bool resultado = AgregarEmpresa(emp);
            if (resultado)
            {
                MessageBox.Show("Empresa agregada con éxito");
                LimpiarCampos();
                cargarGrillaEmpresas();
                btnActualizar.Enabled = false;

            }
            else
            {
                MessageBox.Show("Error al agregar nueva empresa", "ALERTA");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Entidades.Ejecutivo_de_Cuentas.Empresa emp = ObtenerDatosEmpresaDelABM();
            bool resultado = ActualizarEmpresa(emp);
            if (resultado)
            {
                MessageBox.Show("Empresa actualizada con exito");
                LimpiarCampos();
                cargarGrillaEmpresas();
            }
            else
            {
                MessageBox.Show("Error al actualizar empresa", "ALERTA");
            }
        }

        //Metodos para obtener datos

        private Entidades.Ejecutivo_de_Cuentas.Empresa ObtenerDatosEmpresaBD(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Entidades.Ejecutivo_de_Cuentas.Empresa emp = new Entidades.Ejecutivo_de_Cuentas.Empresa();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "datosEmpresa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader != null && reader.Read())
                {
                    emp.NombreEmpresa = reader["nombre_empresa"].ToString();
                    emp.Calle = reader["calle"].ToString();
                    emp.NumCalle = int.Parse(reader["numero_calle"].ToString());
                    emp.CodBarrio = int.Parse(reader["cod_barrio"].ToString());
                    emp.ID = int.Parse(reader["id_empresa"].ToString());
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }


            return emp;
        }

        private Entidades.Ejecutivo_de_Cuentas.Empresa ObtenerDatosEmpresaDelABM()
        {
            Entidades.Ejecutivo_de_Cuentas.Empresa emp = new Entidades.Ejecutivo_de_Cuentas.Empresa();
            emp.NombreEmpresa = txtNombreEmpresa.Text.Trim();
            emp.Calle = txtCalle.Text.Trim();
            emp.NumCalle = int.Parse(mbNroCalle.Text);
            emp.CodBarrio = int.Parse(mbCodBarrio.Text);

            return emp;
        }

        //Metodos para cargar datos a BD

        private bool AgregarEmpresa(Entidades.Ejecutivo_de_Cuentas.Empresa emp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarEmpresa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_empresa", emp.NombreEmpresa);
                cmd.Parameters.AddWithValue("@calle", emp.Calle);
                cmd.Parameters.AddWithValue("@numero_calle", emp.NumCalle);
                cmd.Parameters.AddWithValue("@cod_barrio", emp.CodBarrio);
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

        private bool ActualizarEmpresa(Entidades.Ejecutivo_de_Cuentas.Empresa emp)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "actualizarEmpresa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_empresa", emp.NombreEmpresa);
                cmd.Parameters.AddWithValue("@calle", emp.Calle);
                cmd.Parameters.AddWithValue("@numero_calle", emp.NumCalle);
                cmd.Parameters.AddWithValue("@cod_barrio", emp.CodBarrio);
                cmd.Parameters.AddWithValue("@id", emp.ID);
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

    }
}