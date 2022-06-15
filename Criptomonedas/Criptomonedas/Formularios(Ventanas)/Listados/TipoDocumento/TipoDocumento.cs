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

namespace Criptomonedas.Formularios_Ventanas_.Listados.TipoDocumento
{
    public partial class TipoDocumento : Form
    {
        public TipoDocumento()
        {
            InitializeComponent();
        }

        private void TipoDocumento_Load(object sender, EventArgs e)
        {
            this.reporteTipoDocumento.RefreshReport();
        }

        private void reporteTipoDocumento_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CriptoMonedasDataAccess.ObtenerDocumentoBD();

            ReportDataSource ds = new ReportDataSource("DatosTipoDocumento", tabla);

            reporteTipoDocumento.LocalReport.DataSources.Clear();
            reporteTipoDocumento.LocalReport.DataSources.Add(ds);
            reporteTipoDocumento.LocalReport.Refresh();


        }

        private void btnMinimizarPantallaReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantallaReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTipoDocumento_Click(object sender, EventArgs e)
        {
            if (textBoxTipoDocumento.Text.Length == 0)
            {
                MessageBox.Show("No designó nombre del tipo de documento");
                textBoxTipoDocumento.Focus();
                return;
            }


            DataTable tabla = new DataTable();

            tabla = CriptoMonedasDataAccess.ObtenerDocumentoBDNombre(textBoxTipoDocumento.Text);


            ReportDataSource ds = new ReportDataSource("DatosTipoDocumento", tabla);

            reporteTipoDocumentoNombre.LocalReport.DataSources.Clear();
            reporteTipoDocumentoNombre.LocalReport.DataSources.Add(ds);
            this.reporteTipoDocumentoNombre.RefreshReport();
        }

    
    }
}
