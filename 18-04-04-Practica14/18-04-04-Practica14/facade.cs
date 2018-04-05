using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_04_Practica14
{
    class facade
    {
        Screen pantalla { get; set; }
        CDPlayer cdplayer { get; set; }
        Amplificador amplificador { get; set; }
        DVDPlayer dvdplayer { get; set; }
        Speakers bocinas { get; set; }

        public void setPantalla(Screen pantalla)
        {
            this.pantalla = pantalla;
        }

        public void setCDPlayer(CDPlayer cd)
        {
            this.cdplayer = cd;
        }

        public void setAmplificador(Amplificador ampli)
        {
            this.amplificador = ampli;
        }

        public void setDVDPlayer(DVDPlayer dvd)
        {
            this.dvdplayer = dvd;
        }

        public void setSpeakers(Speakers speak)
        {
            this.bocinas = speak;
        }

        public void mirarPelicula()
        {
            pantalla.On();
            amplificador.on();
            dvdplayer.on();
            dvdplayer.play();
        }

        public void escucharCD()
        {
            bocinas.On();
            amplificador.on();
            cdplayer.on();
            cdplayer.play();
        }

        public void peliculaCinema()
        {
            pantalla.On();
            bocinas.On();
            amplificador.on();
            dvdplayer.on();
            dvdplayer.play();
        }
    }
}
