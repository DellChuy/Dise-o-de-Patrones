using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_04_Practica14
{
    class DVDPlayer
    {
        Amplificador myAmplifier { get; set; }

        public DVDPlayer(Amplificador ampli)
        {
            myAmplifier = ampli;
        }
        public void on()
        {
            Console.WriteLine("DVD Player encendido");
        }
        public void off()
        {
            Console.WriteLine("DVD Player apagado");
        }
        public void eject()
        {
            Console.WriteLine("Extrayendo DVD...");
        }
        public void play()
        {
            Console.WriteLine("Leeyendo DVD...");
        }
    }
}
