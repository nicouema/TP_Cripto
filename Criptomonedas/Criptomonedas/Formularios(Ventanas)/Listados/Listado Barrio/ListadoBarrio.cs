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

namespace Criptomonedas.Formularios_Ventanas_.Listados.Listado_Barrio
{
    public partial class ListadoBarrio : Form
    {
        public ListadoBarrio()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewerBarrios.RefreshReport();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string alcance = "";
            DataTable dataTable = new DataTable();
            if (rbTodos.Checked)
            {
                alcance = "Todos los barrios";
                dataTable = new DataTable();
                dataTable = BarrioDAO.CargarTablaBarrios();

            }
            if (rbFiltrarCiudad.Checked)
            {
                textBoxCiudad.Visible = true;
                string filtroCiudad = textBoxCiudad.Text;
                alcance = "Barrios filtrados por : " + filtroCiudad;
                dataTable = new DataTable();
                dataTable = BarrioDAO.CargarTablaBarrioPorCiudad(filtroCiudad);

            }
           

            ReportDataSource reportDataSource = new ReportDataSource("Barrios", dataTable);
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("AlcanceClientes", alcance);

            //reportViewerClientes.LocalReport.SetParameters(parametros);
            reportViewerBarrios.LocalReport.DataSources.Clear();
            reportViewerBarrios.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerBarrios.RefreshReport();

        }

        private void rbFiltrarCiudad_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCiudad.Visible = true;
        }
    }
}
