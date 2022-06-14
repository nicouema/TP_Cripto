using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.reportViewerClientes.RefreshReport();
            this.reportViewerClientes.RefreshReport();
            this.reportViewerClientes.RefreshReport();
            this.reportViewerClientes.RefreshReport();
        }

    }
}
