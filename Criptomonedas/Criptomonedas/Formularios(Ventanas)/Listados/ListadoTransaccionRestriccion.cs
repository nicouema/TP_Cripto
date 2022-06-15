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
    public partial class ListadoTransaccionRestriccion : Form
    {
        public ListadoTransaccionRestriccion()
        {
            InitializeComponent();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoTransaccionRestriccion_Load(object sender, EventArgs e)
        {
            mbCliente.Visible = false;
            mbDoc.Visible = false;
            this.reportTpM.RefreshReport();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                mbCliente.Visible = false;
                mbDoc.Visible = false;
            }
        }

        private void rbXDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXDoc.Checked == true)
            {
                mbCliente.Visible = false;
                mbDoc.Visible = true;
            }
        }

        private void rbXCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXCliente.Checked == true)
            {
                mbDoc.Visible = false;
                mbCliente.Visible = true;
            }
        }

        private void Restriccion()
        {
            if (rbTodos.Checked == true)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DAO.CriptoMonedasDataAccess.obtenerListadoTransacciones();

            ReportDataSource ds = new ReportDataSource("Transaccion", tabla);

            reportTpM.LocalReport.DataSources.Clear();
            reportTpM.LocalReport.DataSources.Add(ds);
            reportTpM.LocalReport.Refresh();
            this.reportTpM.RefreshReport();
        }
    }
}
