using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Criptomonedas.Formularios_Ventanas_.Listado_Cotizaciones
{
    public partial class ReporteListadosCotizaciones : Form
    {
        public ReporteListadosCotizaciones()
        {
            InitializeComponent();
        }

        private void ReporteListadosCotizaciones_Load(object sender, EventArgs e)
        {

            this.reportViewerCotizaciones.RefreshReport();
        }

        private void reportViewerCotizaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoDeCotizaciones();

            ReportDataSource ds = new ReportDataSource("DatosCotizaciones", tabla);

            reportViewerCotizaciones.LocalReport.DataSources.Clear();
            reportViewerCotizaciones.LocalReport.DataSources.Add(ds);
            reportViewerCotizaciones.LocalReport.Refresh();
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
