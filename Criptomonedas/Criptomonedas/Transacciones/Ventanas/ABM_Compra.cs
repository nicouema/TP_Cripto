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
using Criptomonedas.Entidades.Datos_Cliente;

namespace Criptomonedas.Transacciones.Ventanas
{
    public partial class ABM_Compra : Form
    {
        private static Cliente clienteEnSesion;
        public ABM_Compra(Cliente cliente)
        {
            clienteEnSesion = cliente;
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy");
            CriptoMonedasDataAccess.cargarGrillaCriptomonedas(grillaCripto);
            CriptoMonedasDataAccess.CargarComboCripto(comboCriptomonedas);
        }

        private void btnCerrarPantalla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
