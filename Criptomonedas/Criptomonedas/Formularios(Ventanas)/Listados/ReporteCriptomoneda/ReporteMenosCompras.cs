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
    public partial class ReporteMenosCompras : Form
    {
        public ReporteMenosCompras()
        {
            InitializeComponent();
        }

        private void reportViewerCotizaciones_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = CotizacionesDAO.obtenerCotizacionesCompras("ASC");

            ReportDataSource ds = new ReportDataSource("CotizacionesMAX", dataTable);

            reportViewerCotizaciones.LocalReport.DataSources.Clear();
            reportViewerCotizaciones.LocalReport.DataSources.Add(ds);
            this.reportViewerCotizaciones.RefreshReport();
        }

        private void ReporteMenosCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
