using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_04_Practica14
{
    class Amplificador
    {
        CDPlayer myCDPlayer { get; set; }
        DVDPlayer myDVDPlayer { get; set; }

       
        public void on()
        {
            Console.WriteLine("Amplificador encendido");
        }
        public void off()
        {
            Console.WriteLine("Amplificador apagado");
        }
        public void setCD(CDPlayer cd)
        {
            myCDPlayer = cd;
        }
        public void setDVD(DVDPlayer dvd)
        {
            myDVDPlayer = dvd;
        }
    }
}
