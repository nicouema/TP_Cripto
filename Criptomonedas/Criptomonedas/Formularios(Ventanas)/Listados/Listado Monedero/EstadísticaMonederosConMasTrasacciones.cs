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

namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Monedero
{
    public partial class EstadísticaMonederosConMasTrasacciones : Form
    {
        public EstadísticaMonederosConMasTrasacciones()
        {
            InitializeComponent();
        }

        private void EstadísticaMonederoConMasTrasacciones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.Top5MonederosConMasTransacciones();
           

            ReportDataSource ds = new ReportDataSource("DataSetEstadísticaMonederoConMasTransacciones", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
