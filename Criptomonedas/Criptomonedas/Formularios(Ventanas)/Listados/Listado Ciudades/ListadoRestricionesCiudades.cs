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
    public partial class ListadoRestriccionesCiudades : Form
    {

        DataTable tabla = new DataTable();

        public ListadoRestriccionesCiudades()
        {
            InitializeComponent();
        }

        private void Listado_con_restriciones_de_Ciudades_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudades();
            ReportDataSource ds = new ReportDataSource("DataSetCiudad", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();


        }
        private void rb_Todos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_Todos.Checked == true)
            {
                lblSeleccion.Text = "";
                lblSeleccion.Visible = false;
                cbSeleccion.Enabled = false;
                cbSeleccion.Visible = false;
            }
        }

        private void rb_País_CheckedChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = "PAÍS: ";
            lblSeleccion.Visible = true;
            cbSeleccion.Enabled = true;
            cbSeleccion.Visible = true;
        }

        private void rb_Provincia_CheckedChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = "PROVINCIA: ";
            lblSeleccion.Visible = true;
            cbSeleccion.Enabled = true;
            cbSeleccion.Visible = true;
        }


        public void Restriccion()
        {


            if (rb_Todos.Checked == true)
            {
                //Todos
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudades();

            }
            if (rb_País.Checked == true)
            {
                //País
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudades2();

            }
            if (rb_Provincia.Checked == true)
            {
                //Provincia
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudades();

            }

        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Restriccion();
            ReportDataSource ds = new ReportDataSource("DataSetCiudad", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }


    }
}
