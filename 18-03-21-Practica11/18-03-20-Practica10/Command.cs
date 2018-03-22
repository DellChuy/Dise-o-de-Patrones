using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    interface Command
    {
        void Execute();
        void Undo();
    }
}
