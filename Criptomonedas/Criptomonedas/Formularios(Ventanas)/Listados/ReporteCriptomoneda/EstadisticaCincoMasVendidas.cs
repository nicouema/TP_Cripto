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
    public partial class EstadisticaCincoMasVendidas : Form
    {
        public EstadisticaCincoMasVendidas()
        {
            InitializeComponent();
        }

        private void EstadisticaCincoMasVendidas_Load(object sender, EventArgs e)
        {

            this.reporteCriptomonedas.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = CriptoMonedasDataAccess.ObtenerCriptomonedasMasVendidas();

            ReportDataSource ds = new ReportDataSource("DataSetCincosCriptosMasVendidas", dataTable);

            reporteCriptomonedas.LocalReport.DataSources.Clear();
            reporteCriptomonedas.LocalReport.DataSources.Add(ds);
            reporteCriptomonedas.RefreshReport();
        }
    }
}
