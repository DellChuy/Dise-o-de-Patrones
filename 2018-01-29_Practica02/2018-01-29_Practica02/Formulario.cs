using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class Formulario
    {
        public List<Campos> campos = new List<Campos>();
        public void ValidarTodo()
        {
            for(int i = 0; i < campos.Count; i++)
            {
                campos[i].Validar();
            }
        }
        
    }
}
