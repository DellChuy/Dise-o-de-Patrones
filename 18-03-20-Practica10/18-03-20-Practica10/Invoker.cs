using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class Invoker
    {
        Command comando;
        public void setCommand(Command comando2)
        {
            comando = comando2;
        }
        public void PressBtn1()
        {
            comando.Execute();
        }
        public void PressBtn2()
        {
            comando.Undo();
        }
    }
}
