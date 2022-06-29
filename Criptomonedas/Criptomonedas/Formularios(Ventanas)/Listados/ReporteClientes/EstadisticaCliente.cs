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
    public partial class EstadisticaCliente : Form
    {
        public EstadisticaCliente()
        {
            InitializeComponent();
        }

        private void EstadisticaCliente_Load(object sender, EventArgs e)
        {

            this.reportViewerEstadisticaCliente.RefreshReport();
        }

        private void reportViewerEstadisticaCliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.ClientesDAO.ObtenerEstadisticasClientes();


            ReportDataSource ds = new ReportDataSource("DatosEstadisticasClientes", tabla);
            reportViewerEstadisticaCliente.LocalReport.DataSources.Clear();
            reportViewerEstadisticaCliente.LocalReport.DataSources.Add(ds);
            reportViewerEstadisticaCliente.LocalReport.Refresh();
        }
    }
}
