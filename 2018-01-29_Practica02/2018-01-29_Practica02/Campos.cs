using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    abstract class Campos
    {
        public Validaciones miValidacion;
        public string valor;
        public void Validar()
        {
            this.miValidacion.Validar(valor);
        }

    }
}
