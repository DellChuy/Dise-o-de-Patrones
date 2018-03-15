using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class Dominos : pizzastore
    {
        public override pizza createpizza(string dato)
        {
            pizza mipizza;
            switch (dato)
            {
                case "peperoni":
                    mipizza = new panGrueso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni();
                    Console.WriteLine(mipizza.getnommbre());

                    break;
                case "especial":
                    mipizza = new panDelgado();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new carnes();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new chile();
                    Console.WriteLine(mipizza.getnommbre());
                    break;
                case "mexicana":
                    mipizza = new panCrujiente();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new frijol();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new carnes();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new chile();
                    Console.WriteLine(mipizza.getnommbre());
                    break;
                default:
                    mipizza = new panGrueso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni();
                    Console.WriteLine(mipizza.getnommbre());
                    break;
            }

            mipizza.hornear();
            mipizza.empacar();
            mipizza.cortar();

            Console.WriteLine("Se creo una pizza " + dato + " estilo Dominos.");
            return mipizza;
            

        }
    }
}
