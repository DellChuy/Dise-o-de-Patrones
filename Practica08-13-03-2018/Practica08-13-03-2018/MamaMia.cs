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
                    mipizza = new peperoni();
                    break;
                case "especial":
                    mipizza = new especial();
                    break;
                case "mexicana":
                    mipizza = new mexicana();
                    break;
                default:
                    mipizza = new peperoni();
                    break;
            }

            mipizza.hornear();
            mipizza.empacar();
            mipizza.cortar();

            Console.WriteLine("Se creo una pizza " + mipizza.getnommbre() + " estilo MamaMia.");
            return mipizza;
            

        }
    }
}
