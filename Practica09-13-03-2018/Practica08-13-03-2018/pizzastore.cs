using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica08_13_03_2018
{
    abstract class pizzastore
    {
        public pizza orderpizza(string dato)
        {
            return createpizza(dato);
        }
        public abstract pizza createpizza(string dato);

    }
}
