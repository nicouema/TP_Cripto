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
    public partial class ABM_Pais : Form
    {
        public ABM_Pais()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CargarGrilla();
            Limpiar();
        }
        private void grdPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpiar()
        {
            txtPais.Text = "";
            cmbCodigoPais.SelectedIndex = -1;
        }
      
        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Pais ObtenerDatosPais()
        {
            int cod = cmbCodigoPais.SelectedIndex + 1;
            Pais p = new Pais();
            p.NombrePais = txtPais.Text.Trim();
            p.codigoPais = cod.ToString();
            return p;
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM País";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdPais.DataSource = tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar la tabla");
            }
            finally
            {
                cn.Close();
            }

        }

        private bool validar_pais(String nombrepais)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();


                String consulta = "SELECT * FROM País WHERE nombre_país like '" + nombrepais + "'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Pais", nombrepais);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla1);

                if (tabla1.Rows.Count > 0)
                {
                    resultado = true;
                }
                return resultado;
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

        private void ButtonConsulta_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Pais !!!");
            }
            else
            {
                string pais = txtPais.Text.Trim();
                bool resultado = false;
                try
                {
                    resultado = validar_pais(pais);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar los datos");
                }


                if (resultado == true)
                {
                    MessageBox.Show("Pais encontrado....");
                }
                else
                {
                    MessageBox.Show("Pais no encontrado....");
                }
            }
        }

        private bool AgregarPaisBD(Pais p)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO País (nombre_país) VALUES (@nombrePais)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePais", p.NombrePais);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Agregar dato");
            }
            finally { cn.Close(); }

            return result;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Pais !!!");
            }
            else
            {
                Pais p = ObtenerDatosPais();
                bool result = AgregarPaisBD(p);

                if (result)
                {
                    MessageBox.Show("Pais agregado con exito.");
                    CargarGrilla();
                    CargarComboCodigo();
                }
            }
        }

        private bool ModificarPais(Pais p)
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = " UPDATE País SET nombre_país = @nombrePais WHERE cod_país = @codigopais ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePais", p.NombrePais);
                cmd.Parameters.AddWithValue("@codigopais", p.codigoPais);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Modificar dato");
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

        private void ABM_Pais_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Limpiar();
            CargarComboCodigo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Pais !!!");
            }
            else
            {
                Pais p = ObtenerDatosPais();
                bool result = ModificarPais(p);

                if (result)
                {
                    MessageBox.Show("Pais modificado con exito.");
                    CargarGrilla();
                }
            }
        }
        private void CargarComboCodigo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM País";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCodigoPais.DataSource = tabla;
                cmbCodigoPais.DisplayMember = "cod_país";
                cmbCodigoPais.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar codigo pais");
            }
            finally
            {
                cn.Close();
            }

        }

    }

}

    

