using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class ParpadeoLight : Command
    {
        Lights luz;
        public ParpadeoLight(Lights luz)
        {
            this.luz = luz;
        }
        public void setLight(Lights luz)
        {
            this.luz = luz;
        }
        public void Execute()
        {
            luz.Parpadear();
        }

        public void Undo()
        {
            luz.Off();
        }
    }
}
