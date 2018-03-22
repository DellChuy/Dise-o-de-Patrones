using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class LightsCom : Command
    {
        Lights luz;
        public LightsCom(Lights luz)
        {
            this.luz = luz;
        }
        public void setLight(Lights luz)
        {
            this.luz = luz;
        }
        public void Execute()
        {
            luz.On();
        }

        public void Undo()
        {
            luz.Off();
        }
    }
}
