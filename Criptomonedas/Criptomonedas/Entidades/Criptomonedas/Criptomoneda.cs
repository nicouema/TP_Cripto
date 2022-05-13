
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptomonedas.Entidades.Criptomonedas
{
    public class Criptomoneda
    {
        public string Sigla { get; set; }
        public string NombreCripto { get; set; }
        public int ID { get; set; }

        public Criptomoneda(string sigla, string nombreCripto, int id)
        {
            Sigla = sigla;
            NombreCripto = nombreCripto;
            ID = id;
        }

        public Criptomoneda()
        {
        }
    }
}