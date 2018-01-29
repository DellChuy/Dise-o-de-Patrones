using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_24_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un rey 
            King rey = new King();
            rey.fight();
            //Cambio de arma al rey 
            rey.SetWeapon(new AxeBahavior());
            rey.fight();
            Console.WriteLine("-----------------------------------------------");
            //Creacion de una caballero
            Knight caballero = new Knight();
            caballero.fight();
            //Cambio de arma al caballero
            caballero.SetWeapon(new KnifeBehavior());
            caballero.fight();
            Console.WriteLine("-----------------------------------------------");
            //Creacion de un Troll
            Troll troll = new Troll();
            troll.fight();
            //Cambio de arma de un troll
            troll.SetWeapon(new BowAndArrow());
            troll.fight();
            Console.WriteLine("-----------------------------------------------");
            //Creacion de una reina 
            Queen reina = new Queen();
            reina.fight();
            //Cambio de arma a la reina 
            reina.SetWeapon(new SwordBehavior());
            reina.fight();
            Console.ReadKey();
        }
    }
}
