using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_24_Practica
{
    abstract class Character
    {
        public WeaponBehavior weapon;
        public abstract void fight();

        public void SetWeapon(WeaponBehavior w)
        {
            this.weapon = w;
        }
    }
}
