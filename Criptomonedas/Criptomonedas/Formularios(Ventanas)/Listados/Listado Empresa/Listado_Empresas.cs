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

namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Empresa
{
    public partial class Listado_Empresas : Form
    {
        public Listado_Empresas()
        {
            InitializeComponent();
        }

        private void Listado_Empresas_Load(object sender, EventArgs e)
        {
            lblRangoInicial.Visible = false;
            lblRangoFinal.Visible = false;
            textRangoFinal.Visible = false;
            textRangoInicial.Visible = false;
            this.reportViewer1.RefreshReport();
        }
        
        private void btnCerrarPantallaReg_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private static DataTable obtenerEmpresa()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM Empresa_ejecutivo_de_cuentas";
                cmd.Parameters.Clear();
               
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

        private static DataTable obtenerEmpresaRango(int RangoInicial, int RangoFinal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT * FROM Empresa_ejecutivo_de_cuentas WHERE id_empresa BETWEEN @RangoInicial AND @RangoFinal";
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

        private void radioRangoIdentificador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRangoIdentificador.Checked == true)
            {
                label1.Visible = true;
                lblRangoFinal.Visible = true;
                textRangoFinal.Visible = true;
                textRangoInicial.Visible = true;
            }
            else
            {
                label1.Visible = false;
                lblRangoInicial.Visible = false;
                lblRangoFinal.Visible = false;
                textRangoFinal.Visible = false;
                textRangoInicial.Visible = false;
            }

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (radioTodasEmpresas.Checked == true)
            {
                String Alcance = "Todas las Empresas";
                DataTable tabla = new DataTable();
                tabla = obtenerEmpresa();

                ReportDataSource ds = new ReportDataSource("DataSetEmpresa", tabla);
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
                int RangoFinal = Convert.ToInt32(textRangoFinal.Text);
                String Alcance = "Empresa Entre Rango de id" + RangoInicial.ToString() + "y" + RangoFinal;
                DataTable tabla = new DataTable();
                tabla = obtenerEmpresaRango(RangoInicial, RangoFinal);

                ReportDataSource ds = new ReportDataSource("DataSetEmpresa", tabla);
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

        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
