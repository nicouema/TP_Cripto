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
using Criptomonedas.Entidades.Ejecutivo_de_Cuentas;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Ejecutivo_de_Cuentas
{
    public partial class ABM_EjecutivoDeCuentas : Form
    {
        private static Dictionary<int, string> ejecutivos = new Dictionary<int, string>();
        private static Dictionary<int, string> empresas = new Dictionary<int, string>();
        private static Dictionary<int, string> tipoDocumentos = new Dictionary<int, string>();
        public ABM_EjecutivoDeCuentas()
        {
            InitializeComponent();
            txtRegNombre.Focus();

            cargarComboTipoDoc();
            cargarComboEmpresa();
            cargarComboCoordinador();
            cargarGrillaEjecutivos();
        }

        private void cargarGrillaEjecutivos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select * from Ejecutivo_de_cuentas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaEjecutivos.DataSource = tabla;


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

        private EjecutivoDeCuentas getById(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string select = "SELECT * " +
                    "FROM Ejecutivo_de_cuentas t" +
                    " WHERE t.nro_ejecutivo like @Parameter";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Parameter", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = select;

                connection.Open();
                cmd.Connection = connection;

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                string nombre = (string)dataTable.Rows[0]["nombre"];
                string apellido = (string)dataTable.Rows[0]["apellido"];
                int tipoDoc = (int)dataTable.Rows[0]["tipo_doc"];
                int nroDodumento = (int)dataTable.Rows[0]["nro_doc"];
                int legajo = (int)dataTable.Rows[0]["legajo"];
                int idEmpresa = (int)dataTable.Rows[0]["id_empresa"];
                if (dataTable.Rows[0]["tipo_doc_cord"].Equals(DBNull.Value) || dataTable.Rows[0]["nro_doc_cord"].Equals(DBNull.Value))
                {
                    EjecutivoDeCuentas coordinador1 = new EjecutivoDeCuentas(nombre, apellido, tipoDoc, nroDodumento, legajo, idEmpresa);
                    return coordinador1;
                }

                int tipoDocCoord = (int)dataTable.Rows[0]["tipo_doc_cord"];
                int nroDocCoord = (int)dataTable.Rows[0]["nro_doc_cord"];
                EjecutivoDeCuentas coordinador = new EjecutivoDeCuentas(nombre, apellido, tipoDoc, nroDodumento, legajo, idEmpresa, tipoDocCoord, nroDocCoord);

                return coordinador;

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
            if (txtRegNombre.Text.Equals("") || txtRegApellido.Text.Equals("") || txtLegajo.Text.Equals("") || 
                txtDocumento.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void cargarComboCoordinador()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ejecutivo_de_cuentas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    if (!ejecutivos.ContainsKey((int)row["nro_ejecutivo"]))
                    {
                        ejecutivos.Add((int)row["nro_ejecutivo"], row["nombre"] + " " + row["apellido"]);
                    }
                }
                comboCoordinador.DataSource = new BindingSource(ejecutivos, null);

                comboCoordinador.DisplayMember = "Value";
                comboCoordinador.ValueMember = "Key";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarComboEmpresa()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Empresa_ejecutivo_de_cuentas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    if (!empresas.ContainsKey((int)row["id_empresa"]))
                    {
                        empresas.Add((int)row["id_empresa"], (string)row["nombre_empresa"]);
                    }
                }

                comboEmpresa.DataSource = new BindingSource(empresas, null);
                comboEmpresa.DisplayMember = "Value";
                comboEmpresa.ValueMember = "Key";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarComboTipoDoc()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tipo_documento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable tabla = new DataTable();

                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(tabla);

                foreach(DataRow row in tabla.Rows)
                {
                    if (!tipoDocumentos.ContainsKey((int)row["cod_tipo_doc"]))
                    {
                        tipoDocumentos.Add((int)row["cod_tipo_doc"], (string)row["tipo_doc"]);
                    }
                }

                comboTipoDoc.DataSource = new BindingSource(tipoDocumentos, null);
                comboTipoDoc.DisplayMember = "Value";
                comboTipoDoc.ValueMember = "Key";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaABMCLiente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void registrarEjecutivo(string nombre, string apellido, int tipoDocId, int numDocumento, int legajo, int idEmpresa, int tipoDocIdCoordinador, int numDocumentoCoordinador)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string insert = "INSERT INTO Ejecutivo_de_cuentas (nombre, apellido, tipo_doc, nro_doc, legajo, tipo_doc_cord, nro_doc_cord, id_empresa)" +
                    " values (@Nombre, @Apellido, @TipoDoc, @NroDoc, @Legajo, @TipoDocCoord, @NroDocCoord, @IdEmpresa)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@TipoDoc",tipoDocId);
                cmd.Parameters.AddWithValue("@NroDoc", numDocumento);
                cmd.Parameters.AddWithValue("@Legajo", legajo);
                cmd.Parameters.AddWithValue("@TipoDocCoord", tipoDocIdCoordinador);
                cmd.Parameters.AddWithValue("@NroDocCoord", numDocumentoCoordinador);
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);
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

        private void limpiarCampos()
        {
            txtRegNombre.Text = "";
            txtRegApellido.Text = "";
            txtLegajo.Text = "";
            txtDocumento.Text = "";
        }

        private bool ejectutivoExiste(int tipoDoc, int numeroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * " +
                    "FROM Ejecutivo_de_cuentas " +
                    "where tipo_doc like @TipoDoc " +
                    "and " +
                    "nro_doc like @NumDocumento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDoc", tipoDoc);
                cmd.Parameters.AddWithValue("@NumDocumento", numeroDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    if (dataTable.Rows[0]["tipo_doc"].Equals(tipoDoc) && dataTable.Rows[0]["nro_doc"].Equals(numeroDocumento))
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

        //>>>>>BOTONES
        private void btnCrear_Click(object sender, EventArgs e)
        {

            // DATOS DEL EJECUTIVO
            string nombreEjecutivo = txtRegNombre.Text;
            string apellidoEjecutivo = txtRegApellido.Text;
            int legajoEjecutivo = 0;
            try
            {
                legajoEjecutivo = Convert.ToInt32(txtLegajo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato invalido de legajo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLegajo.Text = "";
                txtLegajo.Focus();
                return;
            }
            int idtipoDocumento = 0;
            foreach (var tipodoc in tipoDocumentos)
            {
                if (tipodoc.Value.Equals(comboTipoDoc.GetItemText(comboTipoDoc.SelectedItem)))
                {
                    idtipoDocumento = tipodoc.Key;
                }
            }
            int numeroDocumento = 0;
            try
            {
                numeroDocumento = Convert.ToInt32(txtDocumento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato invalido de Documento!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Text = "";
                txtDocumento.Focus();
                return;
            }
            int nroCoordinador = 0;
            string nombreCoordinador = comboCoordinador.GetItemText(comboCoordinador.SelectedItem);
            foreach (var ejec in ejecutivos)
            {
                if (ejec.Value.Equals(nombreCoordinador))
                {
                    nroCoordinador = ejec.Key;
                }
            }
            EjecutivoDeCuentas coordinador =  new EjecutivoDeCuentas();
            try
            {
                coordinador = getById(nroCoordinador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del coordinador!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idEmpresa = 0;
            string nombreEmpresa = comboEmpresa.GetItemText(comboEmpresa.SelectedItem);
            foreach (var empresa in empresas)
            {
                if (empresa.Value.Equals(nombreEmpresa))
                {
                    idEmpresa = empresa.Key;
                }
            }


            if (validarCampos())
            {
                try
                {
                    if (ejectutivoExiste(idtipoDocumento, numeroDocumento))
                    {
                        MessageBox.Show("Ya existe un Ejecutivo con ese Documento!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtDocumento.Text = "";
                        txtDocumento.Focus();
                        return;
                    }

                    EjecutivoDeCuentas ejecutivo = new EjecutivoDeCuentas(nombreEjecutivo, apellidoEjecutivo, idtipoDocumento, numeroDocumento, legajoEjecutivo, idEmpresa,
                        coordinador.TipoDocId, coordinador.NumDocumento);

                    registrarEjecutivo(ejecutivo.Nombre, ejecutivo.Apellido, ejecutivo.TipoDocId, ejecutivo.NumDocumento, ejecutivo.Legajo, ejecutivo.IdEmpresa,
                        ejecutivo.TipoDocIdCoordinador, ejecutivo.NumDocumentoCoordinador);

                    MessageBox.Show("Registrado con Exito!", "Registrado", MessageBoxButtons.OK);
                    cargarGrillaEjecutivos();
                    cargarComboCoordinador();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                // DATOS DE LA PERSONA
                string nombreEjecutivo = txtRegNombre.Text;
                string apellidoEjecutivo = txtRegApellido.Text;
                int legajoEjecutivo = 0;
                try
                {
                    legajoEjecutivo = Convert.ToInt32(txtLegajo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato invalido de legajo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLegajo.Text = "";
                    txtLegajo.Focus();
                    return;
                }
                int idtipoDocumento = 0;
                foreach (var tipodoc in tipoDocumentos)
                {
                    if (tipodoc.Value.Equals(comboTipoDoc.GetItemText(comboTipoDoc.SelectedItem)))
                    {
                        idtipoDocumento = tipodoc.Key;
                    }
                }
                int numeroDocumento = 0;
                try
                {
                    numeroDocumento = Convert.ToInt32(txtDocumento.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato invalido de Documento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Text = "";
                    txtDocumento.Focus();
                    return;
                }
                int nroCoordinador = 0;
                string nombreCoordinador = comboCoordinador.GetItemText(comboCoordinador.SelectedItem);
                foreach (var ejec in ejecutivos)
                {
                    if (ejec.Value.Equals(nombreCoordinador))
                    {
                        nroCoordinador = ejec.Key;
                    }
                }
                EjecutivoDeCuentas coordinador = getById(nroCoordinador);
                int idEmpresa = 0;
                string nombreEmpresa = comboEmpresa.GetItemText(comboEmpresa.SelectedItem);
                foreach (var empresa in empresas)
                {
                    if (empresa.Value.Equals(nombreEmpresa))
                    {
                        idEmpresa = empresa.Key;
                    }
                }

                try
                {
                    ModificarEjecutivo(nombreEjecutivo, apellidoEjecutivo, legajoEjecutivo, idtipoDocumento, numeroDocumento,
                        coordinador.TipoDocId, coordinador.NumDocumento, idEmpresa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar Ejecutivo de Cuentas! " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                cargarGrillaEjecutivos();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarEjecutivo(string nombreEjecutivo, string apellidoEjecutivo, int legajoEjecutivo, int idtipoDocumento,
            int numeroDocumento, int idTipoDocCoord, int numDocCord, int idEmpresa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string update = "UPDATE Ejecutivo_de_cuentas" +
                    " SET Ejecutivo_de_cuentas.nombre = @Nombre, " +
                    "Ejecutivo_de_cuentas.apellido = @Apellido, " +
                    "Ejecutivo_de_cuentas.legajo = @Legajo, " +
                    "Ejecutivo_de_cuentas.tipo_doc = @TipoDoc, " +
                    "Ejecutivo_de_cuentas.nro_doc = @NumDoc, " +
                    "Ejecutivo_de_cuentas.tipo_doc_cord = @TipoDocCord, " +
                    "Ejecutivo_de_cuentas.nro_doc_cord = @NumDocCord, " +
                    "Ejecutivo_de_cuentas.id_empresa = @IdEmpresa " +
                    " WHERE " +
                    "tipo_doc = @TipoDoc and nro_doc = @NumDoc ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombreEjecutivo);
                cmd.Parameters.AddWithValue("@Apellido", apellidoEjecutivo);
                cmd.Parameters.AddWithValue("@Legajo", legajoEjecutivo);
                cmd.Parameters.AddWithValue("@TipoDoc", idtipoDocumento);
                cmd.Parameters.AddWithValue("@NumDoc", numeroDocumento);
                cmd.Parameters.AddWithValue("@TipoDocCord", idTipoDocCoord);
                cmd.Parameters.AddWithValue("@NumDocCord", numDocCord);
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = update;

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

        private void grillaEjecutivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = grillaEjecutivos.Rows[indice];
                int id = (int)filaSeleccionada.Cells["nro_ejecutivo"].Value;
                txtRegApellido.Text = (string)filaSeleccionada.Cells["nombre"].Value;
                txtRegNombre.Text = (string)filaSeleccionada.Cells["apellido"].Value;
                try
                {
                    txtLegajo.Text = (string)filaSeleccionada.Cells["legajo"].Value.ToString();
                    txtDocumento.Text = (string)filaSeleccionada.Cells["nro_doc"].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al tomar los datod de la grilla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //int comboId = ((int)filaSeleccionada.Cells["cod_país"].Value - 1);
                //string txtProvincia = (string)filaSeleccionada.Cells["nombre_provincia"].Value;


                //btnActualizar.Enabled = true;
                //cargarCampos(empleado);
                //btnCancelarLimpiar.Enabled = true;
                //btnEliminarEmpleado.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                int idtipoDocumento = 0;
                foreach (var tipodoc in tipoDocumentos)
                {
                    if (tipodoc.Value.Equals(comboTipoDoc.GetItemText(comboTipoDoc.SelectedItem)))
                    {
                        idtipoDocumento = tipodoc.Key;
                    }
                }
                int numeroDocumento = 0;
                try
                {
                    numeroDocumento = Convert.ToInt32(txtDocumento.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato invalido de Documento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Text = "";
                    txtDocumento.Focus();
                    return;
                }

                try
                {
                    //ModificarCliente(idCliente, nombreCliente, apellidoCliente, emailCliente, barrioId);
                    eliminarEjecutivo(idtipoDocumento, numeroDocumento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Ejecutivo! " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                cargarGrillaEjecutivos();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarEjecutivo(int idtipoDocumento, int numeroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connection = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string deleteUsuBarr = "UPDATE Ejecutivo_de_cuentas " +
                    "SET id_empresa = null, nro_doc_cord = null, tipo_doc_cord = null";
                string delete = "DELETE " +
                    "FROM Ejecutivo_de_cuentas " +
                    "WHERE tipo_doc = @TipoDoc and nro_doc = @NumDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDoc", idtipoDocumento);
                cmd.Parameters.AddWithValue("@NumDoc", numeroDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = deleteUsuBarr;

                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();



                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK);
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
    }
}
