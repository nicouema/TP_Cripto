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

namespace Criptomonedas.Formularios_Ventanas_.Listados
{
    public partial class ListadoTransaccion : Form
    {
        public ListadoTransaccion()
        {
            InitializeComponent();
        }

        private void ListadoTransaccionesPorMoneda_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TransaccionDAO.cargarTablaTransacciones();

            ReportDataSource reportDataSource = new ReportDataSource("DataSetTransaccionPorMoneda", dt);

            reportTpM.LocalReport.DataSources.Clear();
            reportTpM.LocalReport.DataSources.Add(reportDataSource);
            this.reportTpM.RefreshReport();
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ocultarTextBox()
        {
            txtCodCripto.Text = "";
            txtNroCliente.Text = "";
            txtTipoOperacion.Text = "";
            txtCodCripto.Visible = false;
            txtTipoOperacion.Visible = false;
            txtNroCliente.Visible = false;
        }

        private void rdBtnTodasTransacciones_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
        }

        private void rdBtnFiltrarPorNroCliente_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtNroCliente.Visible = true;
        }

        private void rdBtnFiltrarPorCodCripto_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtCodCripto.Visible = true;
        }

        private void rdBtnFiltrarPorTipoOp_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtTipoOperacion.Visible = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string alcance = "";
            DataTable dataTable = new DataTable();
            if (rdBtnTodasTransacciones.Checked)
            {
                alcance = "Todos las transacciones";
                dataTable = TransaccionDAO.cargarTablaTransacciones();

            }
            if (rdBtnFiltrarPorCodCripto.Checked)
            {
                if (txtCodCripto.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo codigo de cripto");
                }
                else
                {
                    int filtroCodCripto = int.Parse(txtCodCripto.Text);
                    alcance = "Transacciones filtradas por codigo de cripto: " + filtroCodCripto;
                    dataTable = TransaccionDAO.cargarTablaTransaccionesXCodCripto(filtroCodCripto);
                }
            }
            if (rdBtnFiltrarPorTipoOp.Checked)
            {
                if (txtTipoOperacion.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo tipo de operacion");
                }
                else
                {
                    int filtroTipoOp = int.Parse(txtTipoOperacion.Text);
                    alcance = "Transacciones filtradas por tipo de operacion: " + filtroTipoOp;
                    dataTable = TransaccionDAO.cargarTablaTransaccionesXTipoOperacion(filtroTipoOp);
                }
            }
            if (rdBtnFiltrarPorNroCliente.Checked)
            {
                if (txtNroCliente.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo numero de cliente");
                }
                else
                {
                    int filtroNroCliente = int.Parse(txtNroCliente.Text);
                    alcance = "Transacciones filtradas por numero de cliente: " + filtroNroCliente;
                    dataTable = TransaccionDAO.cargarTablaTransaccionesXNroCliente(filtroNroCliente);
                }
            }

            ReportDataSource reportDataSource = new ReportDataSource("DataSetTransaccionPorMoneda", dataTable);

            reportTpM.LocalReport.DataSources.Clear();
            reportTpM.LocalReport.DataSources.Add(reportDataSource);
            this.reportTpM.RefreshReport();
        }
    }
}
