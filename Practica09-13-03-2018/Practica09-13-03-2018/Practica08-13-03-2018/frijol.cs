using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class frijol:Ingredientes
    {
        pizza mipizza;
        public frijol(pizza pizza)
        {
            mipizza = pizza;
            nombre = "salsa de frijol";
        }
    }
}
