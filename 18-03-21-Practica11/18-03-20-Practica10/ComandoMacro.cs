using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class ComandoMacro : Command
    {
        List<Command> comandos = new List<Command>();
        public void addCommand(Command command)
        {
            comandos.Add(command);
        }
        public void removeCommand(Command command)
        {
            comandos.Remove(command);
            Console.WriteLine("se elimino un comando");
        }
        void Command.Execute()
        {
            Console.WriteLine("Se activo comandomacro");
            if (comandos.Count() == 0)
            {
                Console.WriteLine("no tengo comandos que ejecutar");
            }
            for(int i = 0; i < comandos.Count; i++)
            {
                comandos[i].Execute();
            }
        }

        void Command.Undo()
        {
            Console.WriteLine("Se activo comandomacro undo");
            if (comandos.Count() == 0)
            {
                Console.WriteLine("no tengo comandos que ejecutar");
            }
            for (int i = comandos.Count; i > 0; i--)
            {
                comandos[i-1].Undo();
            }
        }
    }
}
