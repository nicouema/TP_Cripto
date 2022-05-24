using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
     
    public class TipoOperacion
        {
            public string tipo_operacion { get; set; }
            public string  descripcion  { get; set; }

            public string codigo_operacion { get; set; }

        public TipoOperacion(string Tipo_Operacion, string Descripcion, string codigoOperacion)
            {
                tipo_operacion = Tipo_Operacion;
                descripcion = Descripcion;
                codigo_operacion = codigoOperacion;

            }

            public TipoOperacion()
            {
            }
        }
    
}

