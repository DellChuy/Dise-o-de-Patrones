﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_18_Practica06
{
    class Latte:Bebida
    {
        string descripcion = "Esto es un latte";
        double precio = 15;


        public Latte(string size2)
        {
            size = size2;
        }

        public override double costo()
        {
            if (size.Equals("s"))
            {
                return precio;
            }
            else if (size.Equals("m"))
            {
                return precio * 1.2;
            }
            else if (size.Equals("g"))
            {
                return precio * 1.5;
            }

            return precio;

        }

        public override string obtenerDescripcion()
        {
            return descripcion;
        }

        public override string obtenerSize()
        {
            return size;
        }
    }
}
