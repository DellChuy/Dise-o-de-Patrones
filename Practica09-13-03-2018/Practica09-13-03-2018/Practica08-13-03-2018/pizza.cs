using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    abstract class pizza
    {
        protected string nombre;
        public void hornear()
        {
            Console.WriteLine("Horneando pizza");
        }
        public void cortar()
        {
            Console.WriteLine("Cortando pizza");

        }
        public void empacar()
        {
            Console.WriteLine("Empacando pizza");
        }

        public string getnommbre()
        {
            return nombre;
        }
    }
}
