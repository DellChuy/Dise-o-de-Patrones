using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Normal : Comportamientos
    {
        public void Caminar()
        {
            Console.WriteLine("Estoy caminando normal");

        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando normal");
        }

        public void Brincar()
        {
            Console.WriteLine("Estoy Brincando normal");
        }
    }
}
