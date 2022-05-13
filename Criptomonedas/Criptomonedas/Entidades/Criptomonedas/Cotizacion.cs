using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Criptomonedas
{
    public class Cotizacion
    {
        public int CodCripto { get; set; }
        public DateTime? FechaHora { get; set; } = DateTime.Now;
        public float Valor { get; set; }

        public Cotizacion(int codCripto, float valor)
        {
            CodCripto = codCripto;
            Valor = valor;
        }

        public Cotizacion()
        {

        }

    }
}
