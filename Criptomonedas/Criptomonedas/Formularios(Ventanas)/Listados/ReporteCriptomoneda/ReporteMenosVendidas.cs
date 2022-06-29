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

namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteCriptomoneda
{
    public partial class ReporteMenosVendidas : Form
    {
        public ReporteMenosVendidas()
        {
            InitializeComponent();
        }


        private void reportViewerVentas_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = CotizacionesDAO.obtenerCotizacionesVentas("ASC");

            ReportDataSource ds = new ReportDataSource("DataSetMenosVendidas", dataTable);

            reportViewerVentas.LocalReport.DataSources.Clear();
            reportViewerVentas.LocalReport.DataSources.Add(ds);
            this.reportViewerVentas.RefreshReport();
        }
    }
}
