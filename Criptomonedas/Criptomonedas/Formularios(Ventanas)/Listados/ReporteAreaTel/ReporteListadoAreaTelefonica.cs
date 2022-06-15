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

namespace Criptomonedas.Formularios_Ventanas_.ReporteAreaTel
{
    public partial class ReporteListadoAreaTelefonica : Form
    {
        public ReporteListadoAreaTelefonica()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string alcance = "";
            if (rbTodas.Checked)
            {
                tabla = CriptoMonedasDataAccess.ObtenerListadoAreaTelefonica();
                alcance = "Todas las areas telefonicas";
            }
            if (rbResArea.Checked)
            {
                alcance = "Area: " + txtRestriccion.Text;
                tabla = CriptoMonedasDataAccess.ObtenerListadoAreaTelefonicaRestriccionArea(int.Parse(txtRestriccion.Text));
            }
            ReportDataSource ds = new ReportDataSource("DataSetAreaTelefonica", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("AlcanceAreaTel", alcance);

            reporteCriptomonedas.LocalReport.SetParameters(parametros);
            reporteCriptomonedas.LocalReport.DataSources.Clear();
            reporteCriptomonedas.LocalReport.DataSources.Add(ds);
            reporteCriptomonedas.RefreshReport();
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                lblRestriccion.Text = "";
                txtRestriccion.Mask = "";
                lblRestriccion.Visible = false;
                txtRestriccion.Visible = false;
            }
        }

        private void rbResArea_CheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese area:";
            txtRestriccion.Mask = "999";
            lblRestriccion.Visible = true;
            txtRestriccion.Visible = true;
        }

        private void ReporteListadoAreaTelefonica_Load(object sender, EventArgs e)
        {

        }
    }
}
