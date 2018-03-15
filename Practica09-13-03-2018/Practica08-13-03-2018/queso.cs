using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    class queso:Ingredientes
    {
        pizza mipizza;
        public queso(pizza pizza)
        {
            mipizza = pizza;
            nombre = "Queso";
        }
    }
}
