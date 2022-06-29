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
    public partial class InformeClientes : Form
    {
        public InformeClientes()
        {
            InitializeComponent();
        }

        private void InformeClientes_Load(object sender, EventArgs e)
        {

            this.reportViewerClientes.RefreshReport();
        }

        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string alcance = "";
            DataTable dataTable = new DataTable();
            if (rdBtnTodosClientes.Checked)
            {
                alcance = "Todos los clientes";
                dataTable = new DataTable();
                dataTable = ClientesDAO.CargarTablaCliente();

            }
            if (rdBtnFiltrarPorNombre.Checked)
            { 
                string filtroNombre = textBoxFiltroNombre.Text;
                alcance = "Clientes filtrados por nombre: " + filtroNombre;
                dataTable = new DataTable();
                dataTable = ClientesDAO.CargarTablaClientePorNombreCompleto(filtroNombre);

            }
            if (rdBtnFiltrarPorMail.Checked)
            {
                
                string filtroMail = textBoxFiltroMail.Text;
                alcance = "Clientes filtrados por mail: " + filtroMail;
                dataTable = new DataTable();
                dataTable = ClientesDAO.CargarTablaClientePorMail(filtroMail);

            }
            if (rdBtnFiltrarFechaAlta.Checked)
            {
                DateTime fechaDesde = DateTime.Parse(dtpFechaDesde.Text);
                DateTime fechaHasta = DateTime.Parse(dtpFechaHasta.Text);
                alcance = "Clientes con fecha de alta desde: " + dtpFechaDesde.Text + " hasta: " + dtpFechaHasta.Text;
                dataTable = ClientesDAO.CargarTablaClientePorFechaAlta(fechaDesde, fechaHasta);
            }

            ReportDataSource reportDataSource = new ReportDataSource("DataSetClientes", dataTable);
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("AlcanceClientes", alcance);

            //reportViewerClientes.LocalReport.SetParameters(parametros);
            reportViewerClientes.LocalReport.DataSources.Clear();
            reportViewerClientes.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerClientes.RefreshReport();

        }

        private void ocultarTextBox()
        {
            textBoxFiltroNombre.Visible = false;
            textBoxFiltroNombre.Text = "";
            textBoxFiltroMail.Text = "";
            textBoxFiltroMail.Visible = false;
            dtpFechaDesde.Visible = false;
            dtpFechaHasta.Visible = false;
        }

        private void rdBtnFiltrarPorNombre_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            textBoxFiltroNombre.Visible = true;
        }

        private void rdBtnFiltrarPorMail_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            textBoxFiltroMail.Visible = true;
        }

        private void rdBtnFiltrarFechaAlta_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
            dtpFechaDesde.Visible = true;
            dtpFechaHasta.Visible = true;
        }

        private void rdBtnTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            ocultarTextBox();
        }
    }
}
