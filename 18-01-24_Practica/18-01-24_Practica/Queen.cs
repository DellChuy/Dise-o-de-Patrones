using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_24_Practica
{
    class Queen : Character
    {
        public override void fight()
        {
            Console.WriteLine("Peleo como Queen");
            weapon.UseWeapon();
        }
        public Queen()
        {
            SetWeapon(new BowAndArrow());
        }
    }

}
