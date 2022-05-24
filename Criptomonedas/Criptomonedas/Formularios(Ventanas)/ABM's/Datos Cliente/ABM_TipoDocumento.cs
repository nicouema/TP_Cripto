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
    public partial class ABM_TipoDocumento : Form
    {
        public int codigoTipoDocumento;
        public ABM_TipoDocumento()
        {
            InitializeComponent();
        }

        private void ABM_TipoDocumento_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

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

            }
            finally
            {
                cn.Close();
            }

        }
        // -- Método de Cargar a BD
        private bool AgregarTipoDocBD(Tipo_Documento tdoc)


        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_doc", tdoc.TipoDocumento);
                cmd.Parameters.AddWithValue("@descripcion", tdoc.DescDocumento);
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

        // -- Método de Cargar Campos
        private void Cargar_Campos(Tipo_Documento tdoc)
        {
            txtNombreDoc.Text = tdoc.TipoDocumento;

            txtDescDoc.Text = tdoc.DescDocumento;

        }

        // -- Método de Obtener Datos
        public Tipo_Documento ObtenerDatosTipoDocumento()
        {
            Tipo_Documento tdoc = new Tipo_Documento();

            tdoc.TipoDocumento = txtNombreDoc.Text.Trim();
            tdoc.DescDocumento = txtDescDoc.Text.Trim();
 

            return tdoc; //Retornamos el objeto

        }

        // Selección de fila de Grilla
        private void grdTipoDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            btnModificarTipoDoc.Enabled = true;
            btnModificarTipoDoc.Cursor = Cursors.Hand;
            btnEliminarTipoDoc.Enabled = true;
            btnEliminarTipoDoc.Cursor = Cursors.Hand;
            DataGridViewRow filaSeleccionada = grdTipoDoc.Rows[indice];
            int codTipoDoc = int.Parse(filaSeleccionada.Cells["Codigo_Documento"].Value.ToString());

            Tipo_Documento tdoc = ObtenerDocumentoBD(codTipoDoc);
            LimpiarCampos();
            Cargar_Campos(tdoc);
            codigoTipoDocumento = codTipoDoc;

        }

        // Método Obtener Datos TipoDocumento desde Base de Datos
        private Tipo_Documento ObtenerDocumentoBD(int codTipoDoc)
        {

            Tipo_Documento tdoc = new Tipo_Documento();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Tipo_documento WHERE cod_tipo_doc like @documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", codTipoDoc);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
 
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

        private bool ActualizarTipoDoc(Tipo_Documento tdoc)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Tipo_documento SET tipo_doc = @documento, descripcion = @descripcion WHERE cod_tipo_doc like @codTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", tdoc.TipoDocumento);
                cmd.Parameters.AddWithValue("@descripcion", tdoc.DescDocumento);
                cmd.Parameters.AddWithValue("@codTipoDoc", codigoTipoDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Actualizar Persona");
            }

            finally
            {
                cn.Close();
            }



            return resultado;
        }

        // -- Metodo para eliminar un TipoDocumento de la BD
        private bool EliminarTipoBD()
        {
            bool result = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Tipo_documento WHERE cod_tipo_doc like @codTipoDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codTipoDoc", codigoTipoDocumento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar");
            }
            finally { cn.Close(); }

            return result;
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
            Tipo_Documento tdoc = ObtenerDatosTipoDocumento();

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
            Tipo_Documento tdoc = ObtenerDatosTipoDocumento();
            bool resultado = ActualizarTipoDoc(tdoc);
            if (resultado == true)
            {
                MessageBox.Show("Persona actualizada con éxito");
                LimpiarCampos();
                Cargar_Grilla();
                btnModificarTipoDoc.Enabled = false;
                btnEliminarTipoDoc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar persona");

            }
        }

        // Botón Eliminar Datos
  
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                bool result = EliminarTipoBD();

                if (result)
                {
                    MessageBox.Show("Tipo Documento eliminado con éxito!");
                    Cargar_Grilla();
                    LimpiarCampos();

                    btnEliminarTipoDoc.Enabled = false;
                    btnModificarTipoDoc.Enabled = false;
                }

            }
        }
}
