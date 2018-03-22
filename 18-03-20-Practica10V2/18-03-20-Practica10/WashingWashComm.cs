using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class WashingWashComm:Command
    {
        Lavadora lavadora;
        public WashingWashComm(Lavadora lavadora)
        {
            this.lavadora = lavadora;
        }
        public void setLavadora(Lavadora lavadora)
        {
            this.lavadora = lavadora;
        }
        public void Execute()
        {
            lavadora.Wash();
        }

        public void Undo()
        {
            lavadora.Off();
        }
    }
}
