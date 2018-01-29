using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_24_Practica
{
    class Troll : Character
    {
        public override void fight()
        {
            Console.WriteLine("Peleo como Troll");
            weapon.UseWeapon();
        }
        public Troll()
        {
            SetWeapon(new KnifeBehavior());
        }
    }

}
