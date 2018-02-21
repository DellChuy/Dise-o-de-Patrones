using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_18_Practica06
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Bebida cafe = new Cafe("m");
            Console.WriteLine(cafe.obtenerDescripcion());
            cafe = new Expresso(cafe);
            Console.WriteLine(cafe.obtenerDescripcion());
            cafe = new Avellana(cafe);
            Console.WriteLine(cafe.obtenerDescripcion());
            cafe = new Canela(cafe);
            Console.WriteLine(cafe.obtenerDescripcion());
            Console.WriteLine("El costo de tu cafe es: " + cafe.costo());

            Bebida latte = new Latte("g");
            Console.WriteLine(latte.obtenerDescripcion());
            latte = new Avellana(latte);
            Console.WriteLine(latte.obtenerDescripcion());

            Console.WriteLine("El costo de tu latte es: " + latte.costo());

            Console.ReadKey();
        }
    }
}
