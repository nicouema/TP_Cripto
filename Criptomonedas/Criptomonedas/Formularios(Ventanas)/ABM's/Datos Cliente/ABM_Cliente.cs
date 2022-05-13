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
using Criptomonedas.Entidades;
using Criptomonedas.Entidades.Datos_Cliente;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Ejecutivo_de_CuentasCleite
{
    public partial class ABM_Cliente : Form
    {
        private DataTable tablaPais = new DataTable();
        private DataTable tablaProvincia = new DataTable();
        private DataTable tablaCiudad = new DataTable();
        private DataTable tablaBarrio = new DataTable();


        private static Usuario usuarioEnSesion;
        public ABM_Cliente(Usuario usuario)
        {
            usuarioEnSesion = usuario;

            InitializeComponent();
            txtRegNombreCliente.Focus();

            comboBoxPais.SelectedIndex = (-1);
            cargarComboPais();

            cargarComboProvincia();

            cargarComboCiudad();

            cargarComboBarrio();

            cargarGrillaCliente();
        }

        private void cargarGrillaCliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Clientes";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaClientes.DataSource = tabla;


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
        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboProvincia();
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboCiudad();
        }
        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboBarrio();
        }

        private void cargarComboBarrio()
        {
            string ciudadSeleccionada = comboBoxCiudad.GetItemText(this.comboBoxCiudad.SelectedItem);

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Barrio b join Ciudad c on b.cod_ciudad = c.cod_ciudad " +
                    "WHERE " +
                    "c.nombre_ciudad like @Nombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", ciudadSeleccionada);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                comboBoxBarrio.DataSource = tabla;
                comboBoxBarrio.DisplayMember = "nombre_barrio";
                comboBoxBarrio.ValueMember = "cod_barrio";
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

        private void cargarComboCiudad()
        {
            string provinciaSeleccionada = comboBoxProvincia.GetItemText(this.comboBoxProvincia.SelectedItem);

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Ciudad c join Provincias p on c.cod_provincia = p.cod_provincia " +
                    "WHERE " +
                    "p.nombre_provincia like @NombreProvincia";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreProvincia", provinciaSeleccionada);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                comboBoxCiudad.DataSource = tabla;
                comboBoxCiudad.DisplayMember = "nombre_ciudad";
                comboBoxCiudad.ValueMember = "cod_ciudad";
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

        private void cargarComboProvincia()
        {
            string paisSeleccionado = comboBoxPais.GetItemText(this.comboBoxPais.SelectedItem);

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * " +
                    "FROM Provincias prov join País p on prov.cod_país = p.cod_país " +
                    "WHERE " +
                    "p.nombre_país like @NombrePais";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombrePais", paisSeleccionado);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                comboBoxProvincia.DataSource = tabla;
                comboBoxProvincia.DisplayMember = "nombre_provincia";
                comboBoxProvincia.ValueMember = "cod_provincia";
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

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                comboBoxPais.DataSource = tabla;
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
        }
        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaABMCLiente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void ModificarCliente(int idCliente, string nombreCliente, string apellidoCliente, string emailCliente,
            int codBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string insert = "UPDATE Clientes" +
                    " SET nombre = @NombreUsuario, " +
                    "apellido = @Apellido, " +
                    "email = @Email, " +
                    "@CodBarrio = cod_barrio" +
                    " WHERE nro_cliente = @idCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreCliente);
                cmd.Parameters.AddWithValue("@Apellido", apellidoCliente);
                cmd.Parameters.AddWithValue("@Email", emailCliente);
                cmd.Parameters.AddWithValue("@CodBarrio", codBarrio);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
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


        private void registrarCliente(string nombreCliente, string apellidoCliente, string emailCliente, string fechaAlta,
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

        //      VERIFICA SI EXITE UN CLIENTE CON EL MAIL INGRESADO
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
            if (txtRegNombreCliente.Text.Equals("") || txtRegApellido.Text.Equals("") || txtRegEmail.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        //      >>>>> RELLENA LOS CAMPOS CON LOS DATOS DEL CLIENTE SELECCIONADO DE LA GRILLA
        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaClientes.Rows[indice];
            int idCliente = (int)filaSeleccionada.Cells["nro_cliente"].Value;

            try
            {
                Cliente cliente = getClienteBD(idCliente);
                cargarCampos(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el usuario!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarCampos(Cliente cliente)
        {
            txtRegNombreCliente.Text = cliente.nombre;
            txtRegApellido.Text = cliente.apellido;
            txtRegEmail.Text = cliente.email;
            comboBoxBarrio.SelectedIndex = cliente.cod_barrio + 1;
        }

        private Cliente getClienteBD(int idCliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cliente = new Cliente();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes where nro_cliente like @idCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    cliente.nombre = dr["nombre"].ToString();
                    cliente.apellido = dr["apellido"].ToString();
                    cliente.email = dr["email"].ToString();
                    cliente.fechaAlta = dr["fecha_alta"].ToString();
                    cliente.cod_barrio = (int)dr["cod_barrio"];
                    cliente.cod_usuario = (int)dr["cod_usuario"];
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }


            return cliente;
        }
        private void eliminarCliente(int idCliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string deleteUsuBarr = "UPDATE Clientes " +
                    "SET cod_usuario = null, cod_barrio = null";
                string delete = "DELETE " +
                    "FROM Clientes " +
                    "WHERE nro_cliente = @idCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = deleteUsuBarr;

                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();



                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK);
                cargarGrillaCliente();
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
    

    // >>>>>> BOTONES
    private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (validarCampos())
            {
                // DATOS DE LA PERSONA
                string nombreCliente = txtRegNombreCliente.Text.Trim();
                string apellidoCliente = txtRegApellido.Text.Trim();
                string emailCliente = txtRegEmail.Text.Trim();
                string pais = comboBoxPais.GetItemText(comboBoxPais.SelectedItem);
                string provincia = comboBoxProvincia.GetItemText(comboBoxProvincia.SelectedItem);
                string ciudad = comboBoxCiudad.GetItemText(comboBoxCiudad.SelectedItem);
                string barrio = comboBoxBarrio.GetItemText(comboBoxBarrio.SelectedItem);
                int barrioId = getIdPorNombre(barrio, "cod_barrio", "nombre_barrio", "Barrio");
                int idCliente = getIdPorNombre(emailCliente, "nro_cliente", "email", "Clientes");

                try
                {
                    ModificarCliente(idCliente, nombreCliente, apellidoCliente, emailCliente, barrioId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar Cliente! " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                cargarGrillaCliente();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // DATOS DE LA PERSONA
            string nombreCliente = txtRegNombreCliente.Text.Trim();
            string apellidoCliente = txtRegApellido.Text.Trim();
            string emailCliente = txtRegEmail.Text.Trim();
            string pais = comboBoxPais.GetItemText(comboBoxPais.SelectedItem);
            string provincia = comboBoxProvincia.GetItemText(comboBoxProvincia.SelectedItem);
            string ciudad = comboBoxCiudad.GetItemText(comboBoxCiudad.SelectedItem);
            string barrio = comboBoxBarrio.GetItemText(comboBoxBarrio.SelectedItem);
            int barrioId = getIdPorNombre(barrio, "cod_barrio", "nombre_barrio", "Barrio");
            string nombreUsuario = usuarioEnSesion.User;
            int usuarioId = getIdPorNombre(nombreUsuario, "id_usuario", "NombreDeUsuario", "Usuarios");


            if (validarCampos())
            {
                try
                {
                    if (emailExiste(emailCliente))
                    {
                        MessageBox.Show("Ya existe un cliente con ese mail!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtRegEmail.Text = "";
                        txtRegEmail.Focus();
                        return;
                    }

                    Cliente cliente = new Cliente(nombreCliente, apellidoCliente, emailCliente, barrioId, usuarioId);

                    registrarCliente(cliente.nombre, cliente.apellido, cliente.email, cliente.fechaAlta, cliente.cod_barrio, cliente.cod_usuario);

                    MessageBox.Show("Registrado con Exito!", "Registrado", MessageBoxButtons.OK);
                    cargarGrillaCliente();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string emailCliente = txtRegEmail.Text.Trim();
                int idCliente = getIdPorNombre(emailCliente, "nro_cliente", "email", "Clientes");

                try
                {
                    //ModificarCliente(idCliente, nombreCliente, apellidoCliente, emailCliente, barrioId);
                    eliminarCliente(idCliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Cliente! " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                cargarGrillaCliente();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

