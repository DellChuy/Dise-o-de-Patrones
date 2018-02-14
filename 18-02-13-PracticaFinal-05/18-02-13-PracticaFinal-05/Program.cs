using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18_02_13_PracticaFinal_05
{
    class Program
    {
        static DHL dhl = new DHL();
        static Fedex fedex = new Fedex();
        static CorreosMexico correos = new CorreosMexico();
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("persona5678");
            Paquete paquete1 = new Paquete("paquete423426", "Calle Santa Catarina", "DHL");
            Paquete paquete2 = new Paquete("paquete423489", "Calle Santa Catarina", "FEDEX");
            Paquete paquete3 = new Paquete("paquete423878", "Calle Santa Catarina", "CM");
            persona1.registrar_paquete(paquete1);
            persona1.registrar_paquete(paquete2);
            persona1.registrar_paquete(paquete3);
            dhl.registrar(persona1);
            fedex.registrar(persona1);
            correos.registrar(persona1);


            TimerCallback callbackDHL = new TimerCallback(TickDHL);
            Timer timerDHL = new Timer(callbackDHL, null, 0, 5000);//simulan ser 5 minutos

            TimerCallback callbackFEDEX = new TimerCallback(TickFEDEX);
            Timer timerFEDEX = new Timer(callbackFEDEX, null, 0, 12000);//simulan ser 12 minutos

            TimerCallback callbackCM = new TimerCallback(TickCM);
            Timer timerCM = new Timer(callbackCM, null, 0, 60000);//simulan ser 1 Hora

            Console.ReadKey();
        }

        static public void TickDHL(Object stateInfo)
        {
           
            dhl.measurenntChanged();
        }

        static public void TickFEDEX(Object stateInfo)
        {
           
            fedex.measurenntChanged();
        }

        static public void TickCM(Object stateInfo)
        {
            
            correos.measurenntChanged();
        }
    }
}
