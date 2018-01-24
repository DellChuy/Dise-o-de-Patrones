using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Estudiante : Persona
    {
        public int matricula { get; set; }
        public string carrera { get; set; }
        
        public Estudiante(Comportamientos comp)
        {
            comportamiento = comp;
        }
    }
}
