using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Ejecutivo_de_Cuentas
{
    public class Empresa
    {
        public string NombreEmpresa { get; set; }
        public string Calle { get; set; }
        public int NumCalle { get; set; }
        public int CodBarrio { get; set; }
        public int ID { get; set; }


        public Empresa(string empresa, string calle, int numCalle, int codigo, int id)
        {
            NombreEmpresa = empresa;
            Calle = calle;
            NumCalle = numCalle;
            CodBarrio = codigo;
            ID = id;
        }

        public Empresa()
        {
        }
    }
}