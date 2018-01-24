using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Lastimado : Comportamientos
    {
        public void Caminar()
        {
            Console.WriteLine("Estoy caminando lastimado");

        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando pero estoy lastimado");
        }

        public void Brincar()
        {
            Console.WriteLine("Estoy Brincando lastimado");
        }
    }
}
