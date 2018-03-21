using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class WashingComm:Command
    {
        Lavadora lavadora;
        public WashingComm(Lavadora lavadora)
        {
            this.lavadora = lavadora;
        }
        public void setLavadora(Lavadora lavadora)
        {
            this.lavadora = lavadora;
        }
        public void Execute()
        {
            lavadora.On();
        }

        public void Undo()
        {
            lavadora.Off();
        }
    }
}
