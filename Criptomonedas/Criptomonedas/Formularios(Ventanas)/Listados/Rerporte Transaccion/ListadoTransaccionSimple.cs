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

namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    public partial class ListadoTransaccionSimple : Form
    {
        public ListadoTransaccionSimple()
        {
            InitializeComponent();
        }

        private void ListadoTransaccionesPorMoneda_Load(object sender, EventArgs e)
        {
            this.reportTpM.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.obtenerListadoTransacciones();

            ReportDataSource ds = new ReportDataSource("TipoTransaccion", tabla);

            reportTpM.LocalReport.DataSources.Clear();
            reportTpM.LocalReport.DataSources.Add(ds);
            reportTpM.LocalReport.Refresh();
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
