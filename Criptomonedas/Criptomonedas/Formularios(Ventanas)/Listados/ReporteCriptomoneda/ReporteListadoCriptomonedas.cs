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
    public partial class ReporteListadoCriptomonedas : Form
    {
        public ReporteListadoCriptomonedas()
        {
            InitializeComponent();
        }

        private void ReporteListadoCriptomonedas_Load(object sender, EventArgs e)
        {
            reporteCriptomonedas.RefreshReport();
        }

        private void reporteCriptomonedas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string alcance = "";
            if (rbTodas.Checked)
            {
                tabla = CriptoMonedasDataAccess.ObtenerListadoCriptomonedas();
                alcance = "Todas las criptomonedas";
            }
            if (rbResCodigo.Checked)
            {
                string[] datos = txtRestriccion.Text.Split('-');
                alcance = "Rango del codigo, inicio: " + datos[0].ToString() + " final: " + datos[1].ToString();
                tabla = CriptoMonedasDataAccess.ObtenerListadoCriptomonedasRestriccionCodigo(datos[0].ToString(), datos[1].ToString());
            }
            ReportDataSource ds = new ReportDataSource("DataSetCriptomonedas", tabla);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("AlcanceCripto", alcance);

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

        private void rbResCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblRestriccion.Text = "Ingrese rango:";
            txtRestriccion.Mask = "99-99";
            lblRestriccion.Visible = true;
            txtRestriccion.Visible = true;
        }
    }
}
