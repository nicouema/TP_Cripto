using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Datos_Cliente
{
    public class Cliente
    {
        private int nroCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string emailCliente;
        private int barrioId;

        public int NroCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public int cod_barrio { get; set; }
        public int cod_usuario { get; set; }

        public Cliente(string nombre, string apellido, string email, int cod_barrio, int cod_usuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cod_barrio = cod_barrio;
            this.cod_usuario = cod_usuario;
        }

        public Cliente(string nombreCliente, string apellidoCliente, string emailCliente, int barrioId)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.emailCliente = emailCliente;
            this.barrioId = barrioId;
        }

        public Cliente()
        {
        }
    }

}

