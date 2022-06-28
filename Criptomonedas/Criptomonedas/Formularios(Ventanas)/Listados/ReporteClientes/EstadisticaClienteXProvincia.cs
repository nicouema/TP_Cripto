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

namespace Criptomonedas.Formularios_Ventanas_.Listados.ReporteClientes
{
    public partial class EstadisticaClienteXProvincia : Form
    {
        public EstadisticaClienteXProvincia()
        {
            InitializeComponent();
        }

        private void EstadisticaClienteXProvincia_Load(object sender, EventArgs e)
        {

            this.reporteClienteXProvincia.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = ClientesDAO.obtenerClientesXProvincia();

            ReportDataSource ds = new ReportDataSource("DataSetClienteXProvincia", dataTable);

            reporteClienteXProvincia.LocalReport.DataSources.Clear();
            reporteClienteXProvincia.LocalReport.DataSources.Add(ds);
            reporteClienteXProvincia.RefreshReport();
        }
    }
}
