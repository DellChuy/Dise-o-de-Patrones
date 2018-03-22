using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class Ventilador
    {
        string estado = "off";
        public void On()
        {
            Console.WriteLine("Ventilador Encendido");
        }

        public void Off()
        {
            Console.WriteLine("Ventilador Apagado");
            estado = "off";
        }

        public void Slow()
        {
            Console.WriteLine("Ventilador en slow");
            estado = "slow";
        }

        public void Medium()
        {
            Console.WriteLine("Ventilador en medium");
            estado = "medium";
        }

        public void High()
        {
            Console.WriteLine("Ventilador en high");
            estado = "high";
        }
        public string obtenerEstado()
        {
            return estado;
        }
        

    }
}
