using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class ValidaRegistro:Validaciones
    {
        public bool Validar(string valor)
        {
            if (valor.Length == 5)
            {
                Console.WriteLine("Se valido correcto");

            }
            else
            {
                Console.WriteLine("No se valido el largo de tu numero de registro debe ser 5");
            }
            return true;
        }
    }
}
