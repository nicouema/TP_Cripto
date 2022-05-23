using Criptomonedas.Entidades;
using Criptomonedas.Entidades.Datos_Cliente;
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
    public partial class AltaCliente : Form
    {
        private static DataTable tablaPaises = new DataTable();
        private static DataTable tablaProvincias = new DataTable();
        private static DataTable tablaCiudades = new DataTable();
        private static DataTable tablaBarrios = new DataTable();
        public AltaCliente()
        {
            InitializeComponent();
            txtRegNombreCliente.Focus();

            cargarComboBarrioFromDB();
            cargarComboCiudadFromDB();
            cargarComboProvinciaFromDB();
            cargarComboPais();


        }
        // >>>>> COMBOS <<<<<<
        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboProvincia();
        }

        private void cargarComboProvincia()
        {
            int codPais = 1;
            string nombrePais = comboBoxPais.GetItemText(this.comboBoxPais.SelectedItem);
            foreach (DataRow row in tablaPaises.Rows)
            {
                if (row["nombre_país"].Equals(nombrePais))
                {
                    codPais = (int)row["cod_país"];
                    break;
                }
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("cod_provincia");
            tabla.Columns.Add("nombre_provincia");
            foreach (DataRow row in tablaProvincias.Rows)
            {
                if (row["cod_país"].Equals(codPais))
                {

                    tabla.Rows.Add(row["cod_provincia"], row["nombre_provincia"]);
                    //string nombreProvincia = (string)row["nombre_provincia"];
                    //comboBoxProvincia.Items.Add(nombreProvincia);
                }
            }
            comboBoxProvincia.DataSource = tabla;
            comboBoxProvincia.DisplayMember = "nombre_provincia";
            comboBoxProvincia.ValueMember = "cod_provincia";
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboCiudad();
        }

        private void cargarComboCiudad()
        {
            int codProvincia = 1;
            //TODO
            string nombreProvincia = comboBoxProvincia.GetItemText(this.comboBoxProvincia.SelectedItem);
            foreach (DataRow row in tablaProvincias.Rows)
            {
                if (row["nombre_provincia"].Equals(nombreProvincia))
                {
                    codProvincia = (int)row["cod_provincia"];
                    break;
                }
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("cod_ciudad");
            tabla.Columns.Add("nombre_ciudad");
            foreach (DataRow row in tablaCiudades.Rows)
            {
                if (row["cod_provincia"].Equals(codProvincia))
                {

                    tabla.Rows.Add(row["cod_ciudad"], row["nombre_ciudad"]);
                    //string nombreProvincia = (string)row["nombre_provincia"];
                    //comboBoxProvincia.Items.Add(nombreProvincia);
                }
            }
            comboBoxCiudad.DataSource = tabla;
            comboBoxCiudad.DisplayMember = "nombre_ciudad";
            comboBoxCiudad.ValueMember = "cod_ciudad";
        }

        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboBarrio();
        }

        private void cargarComboBarrio()
        {
            int codCiudad = 1;
            //TODO
            string nombreCiudad = comboBoxCiudad.GetItemText(this.comboBoxCiudad.SelectedItem);
            foreach (DataRow row in tablaCiudades.Rows)
            {
                if (row["nombre_ciudad"].Equals(nombreCiudad))
                {
                    codCiudad = (int)row["cod_ciudad"];
                    break;
                }
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("cod_barrio");
            tabla.Columns.Add("nombre_barrio");
            foreach (DataRow row in tablaBarrios.Rows)
            {
                if (row["cod_ciudad"].Equals(codCiudad))
                {

                    tabla.Rows.Add(row["cod_barrio"], row["nombre_barrio"]);
                    //string nombreProvincia = (string)row["nombre_provincia"];
                    //comboBoxProvincia.Items.Add(nombreProvincia);
                }
            }
            comboBoxBarrio.DataSource = tabla;
            comboBoxBarrio.DisplayMember = "nombre_barrio";
            comboBoxBarrio.ValueMember = "cod_barrio";
        }

        private void cargarComboBarrioFromDB()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Barrio";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tablaBarrios);

                //comboBoxBarrio.DataSource = tablaBarrios;
                //comboBoxBarrio.DisplayMember = "nombre_barrio";
                //comboBoxBarrio.ValueMember = "cod_barrio";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void cargarComboCiudadFromDB()
        {
            string provinciaSeleccionada = comboBoxProvincia.GetItemText(this.comboBoxProvincia.SelectedItem);

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Ciudad";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreProvincia", provinciaSeleccionada);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tablaCiudades);

                //comboBoxCiudad.DataSource = tablaCiudades;
                //comboBoxCiudad.DisplayMember = "nombre_ciudad";
                //comboBoxCiudad.ValueMember = "cod_ciudad";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void cargarComboProvinciaFromDB()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Provincias";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tablaProvincias);

                //    comboBoxProvincia.DataSource = tablaProvincias;
                //    comboBoxProvincia.DisplayMember = "nombre_provincia";
                //    comboBoxProvincia.ValueMember = "cod_provincia";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void cargarComboPais()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM País";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tablaPaises);

                comboBoxPais.DataSource = tablaPaises;
                comboBoxPais.DisplayMember = "nombre_país";
                comboBoxPais.ValueMember = "cod_país";
            }
            catch (Exception)
            {

                throw;
            }
        }

        //      >> LIMPIAR TEXTBOX >>
        private void limpiarCampos()
        {
            txtRegNombreCliente.Text = "";
            txtRegApellido.Text = "";
            txtRegEmail.Text = "";
            txtRegNombreUsuario.Text = "";
            txtRegPassword.Text = "";
        }

//      >> BOTONES >>
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            // DATOS DE LA PERSONA
            string nombreCliente = txtRegNombreCliente.Text.Trim();
            string apellidoCliente = txtRegApellido.Text.Trim();
            string emailCliente = txtRegEmail.Text.Trim();
            string pais = comboBoxPais.GetItemText(comboBoxPais.SelectedItem);
            string provincia = comboBoxProvincia.GetItemText(comboBoxProvincia.SelectedItem);
            string ciudad = comboBoxCiudad.GetItemText(comboBoxCiudad.SelectedItem);
            string barrio = comboBoxBarrio.GetItemText(comboBoxBarrio.SelectedItem);

            // DATOS DE USUARIO
            string nombreUsuario = txtRegNombreUsuario.Text.Trim();
            string password = txtRegPassword.Text.Trim();

            if (validarCampos())
            {
                if (existeUsuario(nombreUsuario))
                {
                    MessageBox.Show("Ya existe un usuario con el mismo nombre de usuario!");
                    limpiarCampos();
                    txtRegNombreUsuario.Focus();
                    return;
                }
                if (emailExiste(emailCliente))
                {
                    MessageBox.Show("Ya existe un cliente con ese mail!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    InsertarUsuario(nombreUsuario, password);
                    Usuario usuario = new Usuario(txtRegNombreCliente.Text, txtRegPassword.Text);

                    int usuarioId = getIdPorNombre(nombreUsuario, "id_usuario", "NombreDeUsuario", "Usuarios");
                    int barrioId = getIdPorNombre(barrio, "cod_barrio", "nombre_barrio", "Barrio");

                    Cliente cliente = new Cliente(nombreCliente, apellidoCliente, emailCliente, barrioId, usuarioId);

                    registrarCliente(cliente.nombre, cliente.apellido, cliente.email, cliente.fechaAlta, cliente.cod_barrio, cliente.cod_usuario);

                    MessageBox.Show("Registrado con Exito!", "Registrado", MessageBoxButtons.OK);
                    this.Hide();    
                    Principal form1 = new Principal(usuario);
                    form1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Registrarse!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarCampos();
            }
        }

        private int getIdPorNombre(string nombreUsuario, string nombreColumnaId, string nombreColumnaNombre, string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string select = "SELECT " + nombreColumnaId + " " +
                    "FROM " + nombreTabla + " t" +
                    " WHERE t." + nombreColumnaNombre + " like @NombreUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = select;

                connection.Open();
                cmd.Connection = connection;

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                return dataTable.Rows[0].Field<int>(nombreColumnaId);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void registrarCliente(string nombreCliente, string apellidoCliente, string emailCliente, DateTime fechaAlta,  
            int codBarrio, int codUsuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string insert = "INSERT INTO Clientes (nombre, apellido, email, fecha_alta, cod_barrio, cod_usuario)" +
                    " values (@NombreUsuario, @Apellido, @Email, @FechaAlta, @CodBarrio, @CodUsuario)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreCliente);
                cmd.Parameters.AddWithValue("@Apellido", apellidoCliente);
                cmd.Parameters.AddWithValue("@Email", emailCliente);
                cmd.Parameters.AddWithValue("@FechaAlta", fechaAlta);
                cmd.Parameters.AddWithValue("@CodBarrio", codBarrio);
                cmd.Parameters.AddWithValue("@CodUsuario", codUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = insert;

                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool emailExiste(string emailCliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT email " +
                    "FROM Clientes " +
                    "where email like @Email";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", emailCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    if (dataTable.Rows[0]["email"].Equals(emailCliente))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool validarCampos()
        {
            if (txtRegNombreCliente.Text.Equals("") || txtRegApellido.Text.Equals("") || 
                txtRegEmail.Text.Equals("") || comboBoxPais.Text.Equals("") || 
                comboBoxProvincia.Text.Equals("") || comboBoxCiudad.Text.Equals("") ||
                txtRegPassword.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool existeUsuario(string nombreDeUsuario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombreDeUsuario, Password " +
                    "FROM Usuarios " +
                    "where NombreDeUsuario like @NombreDeUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreDeUsuario", nombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    if (dataTable.Rows[0]["NombreDeUsuario"].Equals(nombreDeUsuario))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private void InsertarUsuario(string nombreUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string insert = "INSERT INTO usuarios (NombreDeUsuario, Password) values (@NombreUsuario, @Password)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = insert;

                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        // CERRAR/MAXIMIZAR/MINIMIZAR
        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
