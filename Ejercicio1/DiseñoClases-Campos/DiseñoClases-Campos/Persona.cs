using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    public class Persona
    {
        string nombre { get; set; }
        int edad { get; set; }
        bool genero { get; set; }
        public Comportamientos comportamiento;
        public void Caminar()
        {
            comportamiento.Caminar();
        }
        public void Brincar()
        {
            comportamiento.Brincar();
        }

        public void Respirar()
        {
            comportamiento.Respirar();
        }

        public void Asignar(Comportamientos comp)
        {
            comportamiento = comp;
        }
    }
}
