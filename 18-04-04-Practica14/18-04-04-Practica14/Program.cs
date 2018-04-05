using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_04_Practica14
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen mipantalla = new Screen();
            Amplificador amplificador = new Amplificador();
            CDPlayer micdplayer = new CDPlayer(amplificador);
            DVDPlayer midvdplayer = new DVDPlayer(amplificador);
            amplificador.setCD(micdplayer);
            amplificador.setDVD(midvdplayer);
            Speakers misbocinas = new Speakers();
            facade myfacade = new facade();

            myfacade.setAmplificador(amplificador);
            myfacade.setCDPlayer(micdplayer);
            myfacade.setDVDPlayer(midvdplayer);
            myfacade.setPantalla(mipantalla);
            myfacade.setSpeakers(misbocinas);
            Console.WriteLine("-Ver pelicula-");
            myfacade.mirarPelicula();
            Console.WriteLine("-Escuchar CD-");
            myfacade.escucharCD();
            Console.WriteLine("-Ve pelicula en CINEMA-");
            myfacade.peliculaCinema();

            Console.ReadKey();
            
        }
    }
}
