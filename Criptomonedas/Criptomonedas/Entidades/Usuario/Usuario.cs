using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades
{
    public class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }

        public Usuario(string usuario, string contraseña)
        {
            User = usuario;
            Password = contraseña;
        }

        public Usuario()
        {
        }
    }
}


