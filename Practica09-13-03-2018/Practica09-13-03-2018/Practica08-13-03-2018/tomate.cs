using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class tomate:Ingredientes
    {
        pizza mipizza;
        public tomate(pizza pizza)
        {
            mipizza = pizza;
            nombre = "Salsa de tomate";
        }
    }
}
