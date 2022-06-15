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
    public partial class ListadoTelefonos : Form
    {
        public ListadoTelefonos()
        {
            InitializeComponent();
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ListadoTelefonos_Load(object sender, EventArgs e)
        {

            this.reportTelefonos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.obtenerListadoTransacciones();

            ReportDataSource ds = new ReportDataSource("Telefonos", tabla);

            reportTelefonos.LocalReport.DataSources.Clear();
            reportTelefonos.LocalReport.DataSources.Add(ds);
            reportTelefonos.LocalReport.Refresh();
        }
    }
}
