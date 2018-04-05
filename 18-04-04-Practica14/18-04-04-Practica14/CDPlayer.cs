using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_04_Practica14
{
    class CDPlayer
    {
        Amplificador myAmplifier { get; set; }

        public CDPlayer(Amplificador ampli)
        {
            myAmplifier = ampli;
        }
        public void on()
        {
            Console.WriteLine("CD Player encendido");
        }
        public void off()
        {
            Console.WriteLine("CD Player apagado");
        }
        public void eject()
        {
            Console.WriteLine("Extrayendo CD...");
        }
        public void play()
        {
            Console.WriteLine("Leeyendo CD...");
        }
    }
}
