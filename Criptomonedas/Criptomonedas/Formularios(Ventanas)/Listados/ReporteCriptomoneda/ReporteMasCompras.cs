using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptomonedas.DAO;
using Microsoft.Reporting.WinForms;

namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Cotizaciones
{
    public partial class ReporteMasCompras : Form
    {
        public ReporteMasCompras()
        {
            InitializeComponent();
        }

        private void ReporteCotizacionesMAX_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = CotizacionesDAO.obtenerCotizacionesMes("DESC");

            ReportDataSource ds = new ReportDataSource("CotizacionesMAX", dataTable);

            reportViewerCotizaciones.LocalReport.DataSources.Clear();
            reportViewerCotizaciones.LocalReport.DataSources.Add(ds);
            this.reportViewerCotizaciones.RefreshReport();
        }
    }
}
