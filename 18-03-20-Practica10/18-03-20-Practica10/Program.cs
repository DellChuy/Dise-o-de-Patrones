using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker i = new Invoker();
            Lights foco1 = new Lights();
            Lavadora lavadora1 = new Lavadora();
            LightsCom comandoluz = new LightsCom(foco1);
            WashingComm comandolavadora = new WashingComm(lavadora1);
            WashingWashComm comandolavar = new WashingWashComm(lavadora1);

            //Encender luces
            i.setCommand(comandoluz);
            i.PressBtn1();
            i.PressBtn2();
            //Encender lavadora
            i.setCommand(comandolavadora);
            i.PressBtn1();
            i.PressBtn2();
            //Encender lavadora para lavar
            i.setCommand(comandolavar);
            i.PressBtn1();
            i.PressBtn2();


            Console.ReadKey();

        }
    }
}
