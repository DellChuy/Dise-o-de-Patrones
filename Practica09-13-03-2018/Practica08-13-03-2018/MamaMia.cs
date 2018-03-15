using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class MamaMia : pizzastore
    {
        public override pizza createpizza(string dato)
        {
            pizza mipizza;
            switch (dato)
            {
                case "peperoni":
                    mipizza = new panGrueso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni(mipizza);
                    Console.WriteLine(mipizza.getnommbre());

                    break; 
                case "especial":
                    mipizza = new panDelgado();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new carnes(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new chile(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    break;
                case "mexicana":
                    mipizza = new panCrujiente();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new frijol(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new carnes(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new chile(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    break;
                default:
                    mipizza = new panGrueso();
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new tomate(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new queso(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    mipizza = new peperoni(mipizza);
                    Console.WriteLine(mipizza.getnommbre());
                    break;
            }

            mipizza.hornear();
            mipizza.empacar();
            mipizza.cortar();

            Console.WriteLine("Se creo una pizza " + dato + " estilo MamaMia.");
            return mipizza;
            

        }
    }
}
