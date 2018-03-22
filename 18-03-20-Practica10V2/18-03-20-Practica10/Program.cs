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
            ParpadeoLight comandoParpadeo = new ParpadeoLight(foco1);

            //Encender luces
            i.setCommand(comandoluz);
            i.PressBtn(1);

            //Encender lavadora
            i.setCommand(comandolavadora);
            i.PressBtn(2);
            i.PressBtnUndo();
            //Encender lavadora para lavar
            i.setCommand(comandolavar);
            i.PressBtn(3);
            //parpadeo de luces
            i.setCommand(comandoParpadeo);
            i.PressBtn(4);
            //Encender luces
            i.setCommand(comandoluz);
            i.PressBtn(5);

            //Encender lavadora
            i.setCommand(comandolavadora);
            i.PressBtn(6);
            
            //Encender lavadora para lavar
            i.setCommand(comandolavar);
            i.PressBtn(7);
            //parpadeo de luces
            i.setCommand(comandoParpadeo);
            i.PressBtn(8);
            i.PressBtnUndo();

            Console.ReadKey();

        }
    }
}
