using Criptomonedas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Criptomonedas 
{
    public partial class LoginForm : Form
    {
        private Size formSize;

        public LoginForm()
        {
            InitializeComponent();
            txtUsuario.Focus();

        }


        // ---------------------------- FUNCIONES AUXILIARES -----------------------------

        // -- Método Limpiar Campos

        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        // -- Método de Verificación de Campos Vacios

        private bool ValidarCampos(string user, string password)
        {
            if (user.Equals("") || password.Equals(""))
            {
                return false;
            }
            return true;
        }


        // -- Validación de Usuario desde la Base de Datos (Por ahora con tabla Provincias)
        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {

            // Definición de Cadena de Conexión
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                // Consulta a la Base de Datos
                string consulta = "SELECT * " +
                    "FROM Usuarios " +
                    "WHERE NombreDeUsuario like @user " +
                    "AND Password like @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                // Apertura de Conexión
                cn.Open();
                cmd.Connection = cn;

                // Definición de Tabla mediante Base de Datos
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow row in tabla.Rows)
                    {
                        if (tabla.Rows[i]["NombreDeUsuario"].Equals(nombreDeUsuario) && tabla.Rows[i]["Password"].Equals(password))
                        {

                            resultado = true;
                            return resultado;
                        }
                        i += 1;
                    }
                    return resultado;
                }
                else
                {
                    return resultado;
                }

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

        // ---------------------------- BOTONES -----------------------------

        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validamos si existen campos vacíos.

            if (ValidarCampos(txtUsuario.Text.Trim(), txtContraseña.Text.Trim()))    
                                                                                   

            {

                // Comparamos si la información de login es correcta.

                if (ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
                {

                    Usuario usu = new Usuario(txtUsuario.Text, txtContraseña.Text);



                    Principal ventana = new Principal(usu);


                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos de Usuario incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Nombre de Usuario y Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus(); 
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            AltaCliente altaUsuario= new AltaCliente();
            altaUsuario.Show();

        }

        private void btnCerrarPantallaLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarPantallaLogIn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}