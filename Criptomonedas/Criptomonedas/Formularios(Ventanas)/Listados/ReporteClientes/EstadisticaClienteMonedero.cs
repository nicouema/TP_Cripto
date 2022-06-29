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

namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteClientes
{
    public partial class EstadisticaClienteMonedero : Form
    {
        public EstadisticaClienteMonedero()
        {
            InitializeComponent();
        }

        private void EstadisticaClienteMonedero_Load(object sender, EventArgs e)
        {

            this.reportViewerEstadisticaClienteMonedero.RefreshReport();
        }

        private void reportViewerEstadisticaClienteMonedero_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.ClientesDAO.ObtenerEstadisticasClientesMonedero();


            ReportDataSource ds = new ReportDataSource("EstadisticaClienteMonedero", tabla);
            reportViewerEstadisticaClienteMonedero.LocalReport.DataSources.Clear();
            reportViewerEstadisticaClienteMonedero.LocalReport.DataSources.Add(ds);
            reportViewerEstadisticaClienteMonedero.LocalReport.Refresh();
        }
    }
}
