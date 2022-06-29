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
            cbSeleccion.Visible = false;
            lblSeleccion.Visible = false;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
 

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
            lblSeleccion.Text = "PAÍS";
            lblSeleccion.Visible = true;
            cbSeleccion.Enabled = true;
            cbSeleccion.Visible = true;
            cbSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarComboPais();
        }

        private void rb_Provincia_CheckedChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = "PROVINCIA: ";
            lblSeleccion.Visible = true;
            cbSeleccion.Enabled = true;
            cbSeleccion.Visible = true;
            cbSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarComboProvincia();

        }
        private void CargarComboPais()
        {
            cbSeleccion.DataSource = DAO.CriptoMonedasDataAccess.ObtenerListadoPais();
            cbSeleccion.ValueMember = "cod_país";
            cbSeleccion.DisplayMember = "nombre_país";
            cbSeleccion.SelectedIndex = -1;

        }
        private void CargarComboProvincia()
        {
            cbSeleccion.DataSource = DAO.CriptoMonedasDataAccess.ObtenerListadoDeProvincias();
            cbSeleccion.ValueMember = "cod_provincia";
            cbSeleccion.DisplayMember = "nombre_provincia";
            cbSeleccion.SelectedIndex = -1;

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
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudadesPais(int.Parse(cbSeleccion.SelectedValue.ToString()));

            }
            if (rb_Provincia.Checked == true)
            {
                //Provincia

                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoCiudadesProv(int.Parse(cbSeleccion.SelectedValue.ToString()));

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
