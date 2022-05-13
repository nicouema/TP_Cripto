using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Provincias
    {
        public string NombreProvincia { get; set; }
        public int CodigoPais { get; set; }

        public int CodigoProvincia { get; set; }


        public Provincias(string nombre_provincia, int cod_pais, int cod_provincia)
        {
            NombreProvincia = nombre_provincia;
            CodigoPais = cod_pais;
            CodigoProvincia = cod_provincia;
        }

        public Provincias()
        {
        }
    }
}
