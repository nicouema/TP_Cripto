using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class AreaTelefono
    {

        public int CodigoPais { get; set; }
        public int Id { get; set; }
        public int CodigoArea { get; set; }

        public string NombreArea { get; set; }


        public AreaTelefono(int cod_pais, int cod_area, string nombre_area, int id)
        {
            CodigoPais = cod_pais;
            CodigoArea = cod_area;
            NombreArea = nombre_area;
            Id = id;
        }


        public AreaTelefono()
        {
        }
    }
}
