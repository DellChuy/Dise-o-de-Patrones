using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class Correo:Campos
    {
        public Correo(string val)
        {
            valor = val;
            miValidacion = new ValidaCorreo();
        }
    }
}
