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
using Criptomonedas.Entidades.Criptomonedas;
using Criptomonedas.Entidades.Datos_Cliente;

namespace Criptomonedas.Transacciones.Ventanas
{
    public partial class ABM_Venta : Form
    {
        private static Cliente clienteEnSesion;
        private static Monedero monederoDeCliente;
        public ABM_Venta(Cliente cliente)
        {
            clienteEnSesion = cliente;
            InitializeComponent();
        }

        private void ABM_Venta_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy");
            CriptoMonedasDataAccess.cargarGrillaCriptomonedas(grillaCripto);
            CriptoMonedasDataAccess.CargarComboCripto(comboCriptomonedas);
            comboCriptomonedas.SelectedIndex = 0;
            monederoDeCliente = CriptoMonedasDataAccess.obtenerMonederoDeCliente(clienteEnSesion, (int)comboCriptomonedas.SelectedValue);
            obtenerDatosDeMonedero(monederoDeCliente);
        }

        private void obtenerDatosDeMonedero(Monedero monedero)
        {
            if (monedero != null)
            {
                lblCantidadEnMonedero.Text = monedero.CantidadCripto.ToString();
            }
            else
            {
                monederoDeCliente = new Monedero((int)comboCriptomonedas.SelectedValue, clienteEnSesion.NroCliente, 0);
                lblCantidadEnMonedero.Text = "0";
            }
        }

        private void btnMinimizarPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPantalla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCripto = CriptoMonedasDataAccess.getCriptoNameById(monederoDeCliente.CodigoCripto);
                int codMonedero = monederoDeCliente.Id;

                decimal cantidad = decimal.Parse(textBoxCantidad.Text);
                decimal cantidadSumada = cantidad;

                foreach (DataGridViewRow row in grillaCompras.Rows)
                {
                    if (row.Cells[2].Value.Equals(codMonedero))
                    {
                        cantidadSumada += decimal.Parse(row.Cells[3].Value.ToString());
                    }
                }

                if (cantidadSumada > decimal.Parse(lblCantidadEnMonedero.Text))
                {
                    MessageBox.Show("Fondos insuficientes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                decimal valor = CriptoMonedasDataAccess.getValorById(monederoDeCliente.CodigoCripto);
                int codCripto = monederoDeCliente.CodigoCripto;
                if (valor == 0)
                {
                    MessageBox.Show("No hay cotizaciones de la criptomoneda seleccionada", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                grillaCompras.Rows.Add(nombreCripto, codCripto, codMonedero, cantidad, valor, cantidad * valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en la tabla!" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboCriptomonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCriptomonedas.SelectedValue == null)
            {
                comboCriptomonedas.SelectedIndex = 0;
            }
            DataRowView dataRow = comboCriptomonedas.SelectedItem as DataRowView;
            int selectedValue = (int)dataRow.Row["codigo_cripto"];
            monederoDeCliente = CriptoMonedasDataAccess.obtenerMonederoDeCliente(clienteEnSesion, selectedValue);
            lblCantidadEnMonedero.Text = monederoDeCliente.CantidadCripto.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            List<TransaccionPorMoneda> list = new List<TransaccionPorMoneda>();

            for (int i = 0; i < grillaCompras.Rows.Count; i++)
            {
                int codMonedero = int.Parse(grillaCompras.Rows[i].Cells["cod_monedero"].Value.ToString());
                int codCripto = int.Parse(grillaCompras.Rows[i].Cells["cod_cripto"].Value.ToString());
                int codTipoOp = 2;
                decimal cantidadCripto = decimal.Parse(grillaCompras.Rows[i].Cells["cantidad"].Value.ToString());
                decimal valorCripto = decimal.Parse(grillaCompras.Rows[i].Cells["valor"].Value.ToString());
                TransaccionPorMoneda transaccionPorMoneda = new TransaccionPorMoneda(clienteEnSesion.NroCliente, codMonedero, codCripto, codTipoOp, cantidadCripto, valorCripto);

                list.Add(transaccionPorMoneda);

            }

            try
            {
                CriptoMonedasDataAccess.guardarTransaccion(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Compra!" + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                grillaCompras.Rows.Clear();
                textBoxCantidad.Text = "";
                comboCriptomonedas.SelectedIndex = -1;
                return;

            }
            grillaCompras.Rows.Clear();
            textBoxCantidad.Text = "";
            comboCriptomonedas.SelectedIndex = -1;
            MessageBox.Show("Transacciones Exitosas!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
