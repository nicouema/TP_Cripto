using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Ejecutivo_de_Cuentas
{
    public class EjecutivoDeCuentas
    {

        public int TipoDocId { get; set; }
        public int NumDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public int TipoDocIdCoordinador { get; set; }
        public int NumDocumentoCoordinador { get; set; }
        public int IdEmpresa { get; set; }

        public EjecutivoDeCuentas(string nombre, string apellido, int tipoDoc, int nroDodumento, int legajo, int idEmpresa)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocId   = tipoDoc;
            this.NumDocumento = nroDodumento;
            this.Legajo = legajo;
            this.IdEmpresa = idEmpresa;
        }

        public EjecutivoDeCuentas(string nombreEjecutivo, string apellidoEjecutivo, int idtipoDocumento, int numeroDocumento, int legajoEjecutivo, int idEmpresa, 
            int tipoDocCoordinador, int numDocCoordinador)
        {
            this.Nombre = nombreEjecutivo;
            this.Apellido = apellidoEjecutivo;
            this.Legajo = legajoEjecutivo;
            this.TipoDocId = idtipoDocumento;
            this.NumDocumento = numeroDocumento;
            this.IdEmpresa = idEmpresa;
            this.TipoDocIdCoordinador = tipoDocCoordinador;
            this.NumDocumentoCoordinador = numDocCoordinador;
        }

        public EjecutivoDeCuentas()
        {
        }
    }
}
