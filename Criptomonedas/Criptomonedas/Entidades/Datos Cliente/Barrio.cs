using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Barrio
    {
        public string NombreBarrio { get; set; }
        public int CodCiudad { get; set; }


        public Barrio(string nomBarrio, int codCiudad)
        {
            NombreBarrio = nomBarrio;
            CodCiudad = codCiudad;
        }

        public Barrio()
        {
        }
    }
}
