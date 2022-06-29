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

namespace Criptomonedas
{
    public partial class ListadoMonederos : Form
    {

        DataTable tabla = new DataTable();

        public ListadoMonederos()
        {
            InitializeComponent();
        }

        private void ListadoMonederos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cmbCriptomonedas.Visible = false;
            lblSeleccion.Visible = false;
            txtNroCliente.Visible = false;
            txtNroCliente.Enabled = false;
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
                cmbCriptomonedas.Enabled = false;
                cmbCriptomonedas.Visible = false;

            }
        }

        private void rb_Criptomonedas_CheckedChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = "CRIPTOMONEDA: ";
            lblSeleccion.Visible = true;
            cmbCriptomonedas.Enabled = true;
            cmbCriptomonedas.Visible = true;
            cmbCriptomonedas.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarComboCriptomonedas();
            txtNroCliente.Enabled = false;
            txtNroCliente.Visible = false;
        }

        private void rb_NroCliente_CheckedChanged(object sender, EventArgs e)
        {
            lblSeleccion.Text = "NRO. CLIENTE: ";
            lblSeleccion.Visible = true;
            txtNroCliente.Enabled = true;
            txtNroCliente.Visible = true;
            cmbCriptomonedas.Enabled = false;
            cmbCriptomonedas.Visible = false;

        }
        private void CargarComboCriptomonedas()
        {
            cmbCriptomonedas.DataSource = DAO.CriptoMonedasDataAccess.ObtenerListadoCriptomonedas();
            cmbCriptomonedas.ValueMember = "codigo_cripto";
            cmbCriptomonedas.DisplayMember = "siglas_cripto";
            cmbCriptomonedas.SelectedIndex = -1;

        }
        public void Restriccion()
        {


            if (rb_Todos.Checked == true)
            {
                //Todos
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoMonedero();

            }
            if (rb_Criptomonedas.Checked == true)
            {
                //Criptomonedas
                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoMonederoCripto(int.Parse(cmbCriptomonedas.SelectedValue.ToString()));

            }
            if (rb_CodCliente.Checked == true)
            {
                //Clientes

                tabla = DAO.CriptoMonedasDataAccess.ObtenerListadoMonederoCliente(int.Parse(txtNroCliente.Text.Trim()));

            }

        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {   
            Restriccion();
            ReportDataSource ds = new ReportDataSource("DataSetMonedero", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}
