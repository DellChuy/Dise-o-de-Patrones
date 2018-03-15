using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dominos dominos = new Dominos();
            MamaMia mamamia = new MamaMia();

            dominos.orderpizza("peperoni");
            dominos.orderpizza("especial");
            dominos.orderpizza("mexicana");

            mamamia.orderpizza("peperoni");
            mamamia.orderpizza("especial");
            mamamia.orderpizza("mexicana");

            Console.ReadKey();
        }
    }
}
