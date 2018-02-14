using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_13_PracticaFinal_05
{
    interface Subject
    {
        void registrar(Observer nuevo);
        void remover(Observer cliente);
        void notificar();


    }
}
