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

namespace Criptomonedas.Formularios_Ventanas_.Listados.EjecutivoDeCuenta
{
    public partial class EjecutivoDeCuenta : Form
    {
        public EjecutivoDeCuenta()
        {
            InitializeComponent();
        }


        private void EjecutivoDeCuenta_Load(object sender, EventArgs e)
        {
            this.reporteEjecutivoCuentas.RefreshReport();
        }
        private void reporteEjecutivoCuentas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CriptoMonedasDataAccess.ObtenerEjecutivoCuentasBD();

            ReportDataSource ds = new ReportDataSource("ejecutivoDeCuentas", tabla);

            reporteEjecutivoCuentas.LocalReport.DataSources.Clear();
            reporteEjecutivoCuentas.LocalReport.DataSources.Add(ds);
            reporteEjecutivoCuentas.LocalReport.Refresh();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
