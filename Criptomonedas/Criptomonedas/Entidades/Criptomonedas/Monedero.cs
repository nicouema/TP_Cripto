using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Criptomonedas
{
    public class Monedero
    {
        public int CodigoCripto { get; set; }
        public decimal CantidadCripto { get; set; }
        public int NroCliente { get; set; }



        public Monedero(int codigo_cripto, decimal cantidad_cripto, int nro_cliente)
        {
            
            CodigoCripto = codigo_cripto;
            CantidadCripto = cantidad_cripto;
            NroCliente = nro_cliente;
        }

        public Monedero()
        {
        }
    }
}
