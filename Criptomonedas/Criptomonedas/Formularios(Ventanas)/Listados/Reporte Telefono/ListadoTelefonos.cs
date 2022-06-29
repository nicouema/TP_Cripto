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
            DataTable dt = new DataTable();
            dt = TelefonoDAO.cargarTablaTelefonos();

            ReportDataSource reportDataSource = new ReportDataSource("DataSetTelefonos", dt);

            reportTelefonos.LocalReport.DataSources.Clear();
            reportTelefonos.LocalReport.DataSources.Add(reportDataSource);
            this.reportTelefonos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string alcance = "";
            DataTable dataTable = new DataTable();
            if (rdBtnTodosTelefonos.Checked)
            {
                alcance = "Todos los telefonos";
                dataTable = TelefonoDAO.cargarTablaTelefonos();

            }
            if (rdBtnFiltrarPorCodPais.Checked)
            {
                if (txtCodPais.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo codigo pais");
                }
                else
                {
                    int filtroCodPais = int.Parse(txtCodPais.Text);
                    alcance = "Telefonos filtrados por codigo de pais: " + filtroCodPais;
                    dataTable = TelefonoDAO.cargarTablaTelefonosXCodPais(filtroCodPais);
                }
            }
            if (rdBtnFiltrarPorCodArea.Checked)
            {
                if (txtCodArea.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo codigo area");
                }
                else
                {
                    int filtroCodArea = int.Parse(txtCodArea.Text);
                    alcance = "Telefonos filtrados por codigo de area: " + filtroCodArea;
                    dataTable = TelefonoDAO.cargarTablaTelefonosXCodArea(filtroCodArea);
                }
            }
            if (rdBtnFiltrarNroCliente.Checked)
            {
                if (txtNroCliente.Text.Equals(""))
                {
                    MessageBox.Show("Llenar campo numero de cliente");
                }
                else
                {
                    int filtroNroCliente = int.Parse(txtNroCliente.Text);
                    alcance = "Telefonos filtrados por numero de cliente: " + filtroNroCliente;
                    dataTable = TelefonoDAO.cargarTablaTelefonosXNroCliente(filtroNroCliente);
                }
            }

            ReportDataSource reportDataSource = new ReportDataSource("DataSetTelefonos", dataTable);

            reportTelefonos.LocalReport.DataSources.Clear();
            reportTelefonos.LocalReport.DataSources.Add(reportDataSource);
            this.reportTelefonos.RefreshReport();
        }

        private void ocultarTextBox()
        {
            txtCodArea.Text = "";
            txtNroCliente.Text = "";
            txtCodPais.Text = "";
            txtCodArea.Visible = false;
            txtCodPais.Visible = false;
            txtNroCliente.Visible = false;
        }

        private void rdBtnTodosTelefonos_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
        }

        private void rdBtnFiltrarPorCodPais_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtCodPais.Visible = true;
        }

        private void rdBtnFiltrarPorCodArea_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtCodArea.Visible = true;
        }

        private void rdBtnFiltrarNroCliente_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            txtNroCliente.Visible = true;
        }
    }
}
