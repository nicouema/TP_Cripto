using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptomonedas.Formularios_Ventanas_.ABM_s
{
    public partial class ABM_EjecutivoDeCuentas : Form
    {

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarPantallaABMCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantallaABMCLiente_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ABM_EjecutivoDeCuentas_Load(object sender, EventArgs e)
        {

        }
    }

}