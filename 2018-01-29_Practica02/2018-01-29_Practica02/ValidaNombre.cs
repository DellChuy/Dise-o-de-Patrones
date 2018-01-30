using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class ValidaNombre:Validaciones
    {
        public bool Validar(string valor)
        {

            if (valor.Contains("[0-9]+"))
            {
                Console.WriteLine("No ingreses numeros");
            }
            else
            {
                Console.WriteLine("Validado Correctamente");
            }
            return true;
        }
    }
}
