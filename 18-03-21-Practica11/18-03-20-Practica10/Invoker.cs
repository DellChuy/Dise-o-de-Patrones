using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class Invoker
    {
        List<Command> comandos = new List<Command>();
        Command ultimo = null;
        public void setCommand(Command comando)
        {
          if(comandos.Count < 8)
            {
                comandos.Add(comando);
            }  
          else if (comandos.Count == 8)
            {
                Console.WriteLine("Todos los botoenes de tu control tienen un comando");
                Console.WriteLine("Tu nuevo comando se asignara a tu boton 1");
                comandos[0] = comando;
            }
        }
        public void PressBtn(int numeroBoton)
        {
            comandos[numeroBoton-1].Execute();
            ultimo = comandos[numeroBoton - 1];
        }
        public void PressBtnUndo()
        {
            if (ultimo != null)
            {
                ultimo.Undo();
            }
            else
            {
                Console.WriteLine("Aun no se a realiado ningun comando");
            }
          
        }
    }
}
