using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Pais
    {
        public string NombrePais { get; set; }
        
        public string codigoPais { get; set; }


        public Pais(string nomPais, string codigo)
        {
            NombrePais = nomPais;
            codigoPais = codigo;
        }

        public Pais()
        {
        }
    }
}

