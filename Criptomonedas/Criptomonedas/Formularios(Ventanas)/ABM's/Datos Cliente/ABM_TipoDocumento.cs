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

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Datos_Cliente
{
    public partial class ABM_TipoDocumento : Form
    {
        public ABM_TipoDocumento()
        {
            InitializeComponent();
        }

        private void ABM_TipoDocumento_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificarTipoDoc.Enabled = false;
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la Grilla");
            }
                

        }

        // ---------------------------- FUNCIONES AUXILIARES -----------------------------

        // -- Método Limpiar Campos
        private void LimpiarCampos()
        {
            txtNombreDoc.Text = "";
            txtDescDoc.Text = "";
        }

        // -- Método Cargar Grilla
        private void Cargar_Grilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {


                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT cod_tipo_doc, tipo_doc, descripcion FROM Tipo_documento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;


                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdTipoDoc.DataSource = tabla;


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
        // -- Método de Cargar a BD
        private bool AgregarTipoDocBD(Entidades.Datos_Cliente.Tipo_Documento tdoc)


        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Tipo_documento VALUES(@tipo_doc, @descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_doc", tdoc.TipoDocumento);
                cmd.Parameters.AddWithValue("@descripcion", tdoc.DescDocumento);
                cmd.CommandType = CommandType.Text;
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

        // -- Método de Cargar Campos
        private void Cargar_Campos(Entidades.Datos_Cliente.Tipo_Documento tdoc)
        {
            txtNombreDoc.Text = tdoc.TipoDocumento;

            txtDescDoc.Text = tdoc.DescDocumento;

        }

        // -- Método de Obtener Datos
        public Entidades.Datos_Cliente.Tipo_Documento ObtenerDatosTipoDocumento()
        {
            Entidades.Datos_Cliente.Tipo_Documento tdoc = new Entidades.Datos_Cliente.Tipo_Documento();
            tdoc.TipoDocumento = txtNombreDoc.Text.Trim();
            tdoc.DescDocumento = txtDescDoc.Text.Trim();
 

            return tdoc; //Retornamos el objeto

        }

        // Selección de fila de Grilla
        private void grdTipoDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            btnModificarTipoDoc.Enabled = true;
            DataGridViewRow filaSeleccionada = grdTipoDoc.Rows[indice];
            string documento = filaSeleccionada.Cells["TipoDocumento"].Value.ToString();
            Entidades.Datos_Cliente.Tipo_Documento tdoc = ObtenerDocumentoBD(documento);
            LimpiarCampos();
            Cargar_Campos(tdoc);

        }

        // Método Obtener Datos TipoDocumento desde Base de Datos
        private Entidades.Datos_Cliente.Tipo_Documento ObtenerDocumentoBD(string documento)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Entidades.Datos_Cliente.Tipo_Documento tdoc = new Entidades.Datos_Cliente.Tipo_Documento();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_documento where cod_tipo_doc like @documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    tdoc.CodigoDocumento = (int)dr["cod_tipo_doc"];
                    tdoc.TipoDocumento = dr["tipo_doc"].ToString();
                    tdoc.DescDocumento = dr["descripcion"].ToString();
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


            return tdoc;
        }

        // Actualizar Tipo Documento

        private bool ActualizarTipoDoc(Entidades.Datos_Cliente.Tipo_Documento tdoc)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Tipo_documento SET tipo_doc = @documento, descripcion = @descripcion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", tdoc.TipoDocumento);
                cmd.Parameters.AddWithValue("@descripcion", tdoc.DescDocumento);
                cmd.CommandType = CommandType.Text;
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
        // ---------------------------- BOTONES ----------------------------


        // -- Botón Limpiar Campos
        private void lblLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // -- Botón Guardar Datos
        private void btnGuardarTipoDoc_Click(object sender, EventArgs e)
        {
            Entidades.Datos_Cliente.Tipo_Documento tdoc = ObtenerDatosTipoDocumento();

            bool resultado = AgregarTipoDocBD(tdoc);
            if (resultado)
            {
                MessageBox.Show("Tipo Documento agregado con éxito!!");
                LimpiarCampos();
                Cargar_Grilla();

            }
            else
            {
                MessageBox.Show("ERROR AL AGREGAR TIPO DOCUMENTO");
            }
        }

       // Botón Cerrar Pantalla
        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botón Minimizar Pantalla

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        // Botón Modificar Datos
        private void btnModificarTipoDoc_Click(object sender, EventArgs e)
        {
            Entidades.Datos_Cliente.Tipo_Documento tdoc = ObtenerDatosTipoDocumento();
            bool resultado = ActualizarTipoDoc(tdoc);
            if (resultado == true)
            {
                MessageBox.Show("Persona actualizada con éxito");
                LimpiarCampos();
                Cargar_Grilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");

            }
        }

    }
}
