using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_18_Practica06
{
    abstract class Bebida
    {
        protected string size { get; set; }
        
        public abstract double costo();
        public abstract string obtenerDescripcion();
        public abstract string obtenerSize();
    }
}
