using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class ValidaCorreo:Validaciones
    {

        public bool Validar(string valor)
        {
            if (valor.Contains("@"))
            {
                Console.WriteLine("se valido correctamente");
            }
            else
            {
                Console.WriteLine("no es correcto el correo agrega un @");
            }
            return true;
        }
    }
}
