using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Discapacitado : Comportamientos
    {
        public void Caminar()
        {
            Console.WriteLine("No puedo caminar :c ");

        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando pero estoy invalido");
        }

        public void Brincar()
        {
            Console.WriteLine("No puedo brincar :c ");
        }
    }
}
