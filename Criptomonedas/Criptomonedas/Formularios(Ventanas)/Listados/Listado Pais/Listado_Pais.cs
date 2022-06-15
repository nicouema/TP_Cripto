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
using Microsoft.Reporting.WinForms;

namespace Criptomonedas
{
    public partial class Listado_Pais : Form
    {
        public Listado_Pais()
        {
            InitializeComponent();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static DataTable obtenerPais()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM País";
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@Pais", nombrepais);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla1);

                return tabla1;
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

        private static DataTable obtenerPaisRango(int RangoInicial, int RangoFinal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM País WHERE cod_país BETWEEN @RangoInicial AND @RangoFinal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@RangoInicial", RangoInicial);
                cmd.Parameters.AddWithValue("@RangoFinal", RangoFinal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla1);

                return tabla1;
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

        private void Listado_EjecutivoDeCuenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProyecto.País' table. You can move, or remove it, as needed.
            this.paísTableAdapter.Fill(this.dataSetProyecto.País);
            // TODO: This line of code loads data into the 'dataSetProyecto.País' table. You can move, or remove it, as needed.
            //this.paísTableAdapter.Fill(this.dataSetProyecto.País);
            lblRangoInicial.Visible = false;
            lblRangoFinal.Visible = false;
            textRangoFinal.Visible = false;
            textRangoInicial.Visible = false;
            //
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioTodosPaises_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTodosPaises.Checked == true)
            {
                
            }

        }

        private void radioRangoIdentificador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRangoIdentificador.Checked == true)
            {
                lblRangoInicial.Visible = true;
                lblRangoFinal.Visible=true;
                textRangoFinal.Visible = true;
                textRangoInicial.Visible = true;
            }
            else
            {
                lblRangoInicial.Visible = false;
                lblRangoFinal.Visible = false;
                textRangoFinal.Visible = false;
                textRangoInicial.Visible=false;
            }

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (radioTodosPaises.Checked == true)
            {
                String Alcance = "Todos los paises"; 
                
                DataTable tabla = new DataTable();
                tabla = obtenerPais();

                ReportDataSource ds = new ReportDataSource("DataSetPais", tabla);
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", Alcance);
                this.reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.LocalReport.DataSources.Clear();
                //this.reportViewer1.LocalReport.ReportPath = "Listado_Pais.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }

            if (radioRangoIdentificador.Checked == true)
            {
                int RangoInicial = Convert.ToInt32(textRangoInicial.Text);
                int  RangoFinal = Convert.ToInt32(textRangoFinal.Text);
                String Alcance = "Paises Entre Rango de id" + RangoInicial.ToString() +"y"+ RangoFinal;

                DataTable tabla = new DataTable();
                tabla = obtenerPaisRango(RangoInicial,RangoFinal);

                ReportDataSource ds = new ReportDataSource("DataSetPais", tabla);
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("Alcance", Alcance);
                this.reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.LocalReport.DataSources.Clear();
                //this.reportViewer1.LocalReport.ReportPath = "Listado_Pais.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
