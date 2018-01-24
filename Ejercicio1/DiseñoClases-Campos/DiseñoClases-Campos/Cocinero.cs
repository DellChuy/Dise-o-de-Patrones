using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Cocinero : Persona
    {
        string especialidad { get; set; }
        string puesto { get; set; }
        
        public Cocinero(Comportamientos comp)
        {
            comportamiento = comp;
        }

    }
}
