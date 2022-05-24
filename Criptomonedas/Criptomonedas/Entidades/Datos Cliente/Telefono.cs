using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Telefono
    {
        public int CodPais { get; set; }
        public int CodArea { get; set; }
        public int NroTelefono { get; set; }
        public int NroCliente { get; set; }

        public Telefono(int cod_pais, int cod_area, int cod_telefono, int nro_telefono, int nro_cliente)
            {
            CodPais = cod_pais;
            CodArea =  cod_area;
            NroTelefono = nro_telefono;
            NroCliente = nro_cliente;

            }

        public Telefono()
        {
        }
    }
}
