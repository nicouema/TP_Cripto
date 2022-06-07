using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Criptomonedas
{
    public class TransaccionPorMoneda
    {
        public int idTransaccion { get; set; }
        public int nroCliente { get; set; } 
        public int codMonedero { get; set; }
        public int codCripto { get; set; }
        public int codTipoTransaccion { get; set; }
        public decimal cantidadCripto { get; set; }
        public decimal valorCripto { get; set; }

        public TransaccionPorMoneda(int nroCliente, int codMonedero, int codCripto, int codTipoTransaccion, decimal cantidadCripto, decimal valorCripto)
        {
            this.nroCliente = nroCliente;
            this.codMonedero = codMonedero;
            this.codCripto = codCripto;
            this.codTipoTransaccion = codTipoTransaccion;
            this.cantidadCripto = cantidadCripto;
            this.valorCripto = valorCripto;
        }

        public TransaccionPorMoneda()
        {
        }
    }
}
