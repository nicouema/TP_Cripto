using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Tipo_Documento
    {
        public string TipoDocumento { get; set; }
        public string DescDocumento { get; set; }


        public Tipo_Documento(int cod_documento, string tipo_documento, string desc_documento)
        {
            TipoDocumento = tipo_documento;
            DescDocumento = desc_documento;
        }

        public Tipo_Documento()
        {
        }
    }
}
