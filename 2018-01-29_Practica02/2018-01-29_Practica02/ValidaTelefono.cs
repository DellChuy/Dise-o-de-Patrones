using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class ValidaTelefono:Validaciones
    {
        public bool Validar(string valor)
        {
            if(valor.Length == 10)
            {
                Console.WriteLine("se valido correctamente");
            }
            return true;
        }
    }
}
