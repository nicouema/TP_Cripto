using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s.Ejecutivo_de_Cuentas
{
    public partial class ABM_EjecutivoDeCuentas : Form
    {
        public ABM_EjecutivoDeCuentas()
        {
            InitializeComponent();
        }

        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaABMCLiente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
