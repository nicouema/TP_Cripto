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

namespace Criptomonedas.Formularios_Ventanas_.Listados.Rerporte_Transaccion
{
    public partial class TransaccionPorMonedero : Form
    {
        public TransaccionPorMonedero()
        {
            InitializeComponent();
        }

        private static DataTable listadoTransaccionesXMonedero()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                ;

                SqlCommand cmd = new SqlCommand();
                String consulta = "SELECT c.cod_monedero, COUNT(pc.tipo_operacion) as Cantidad_Transacciones FROM Transacciones_por_monedas  pc INNER JOIN Monedero c On pc.codigo_cripto = c.codigo_cripto  Group by c.cod_monedero";
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

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransaccionPorMonedero_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla1 = new DataTable();
            tabla1 = listadoTransaccionesXMonedero();

            ReportDataSource ds = new ReportDataSource("TransaccionesXMonedero", tabla1);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
