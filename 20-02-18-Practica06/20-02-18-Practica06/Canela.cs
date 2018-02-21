﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_18_Practica06
{
    class Canela:Ingredientes
    {
        string descripcion = "soy el ingrediente Canela";
        Bebida bebida;
        double precio = 5;

        public Canela(Bebida bebida)
        {
            this.bebida = bebida;
        }
        public override double costo()

        {
            if (obtenerSize().Equals("s"))
            {
                return precio + bebida.costo();
            }
            else if (obtenerSize().Equals("m"))
            {
                return (precio * 1.2) + bebida.costo();
            }
            else if (obtenerSize().Equals("g"))
            {
                return (precio * 1.5) + bebida.costo();
            }
            return precio + bebida.costo();
        }

        public override string obtenerDescripcion()
        {
            return descripcion;
        }

        public override string obtenerSize()
        {
            return bebida.obtenerSize();
        }
    }
}
