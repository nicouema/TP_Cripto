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

namespace Criptomonedas.Formularios_Ventanas_.Listado_Provincias
{
    public partial class ReporteListadosProvincias : Form
    {
        public ReporteListadosProvincias()
        {
            InitializeComponent();
        }

        private void ReporteListadosProvincias_Load(object sender, EventArgs e)
        {

            this.reportViewerProvincias.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoDeProvincias();

            ReportDataSource ds = new ReportDataSource("DatosProvincias", tabla);

            reportViewerProvincias.LocalReport.DataSources.Clear();
            reportViewerProvincias.LocalReport.DataSources.Add(ds);
            reportViewerProvincias.LocalReport.Refresh();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReporteListadosProvincias ventana = new ReporteListadosProvincias();
            ventana.ShowDialog();
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
