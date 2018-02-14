using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_13_PracticaFinal_05
{
    class CorreosMexico
    {
        int tiempo { get; set; }
        bool changed = false;
        string nombre = "CM";

        List<Observer> clientes = new List<Observer>();

        public void registrar(Observer nuevo)
        {
            clientes.Add(nuevo);
            Console.WriteLine("Se registro en Correos De Mexico correctamente");
        }

        public void remover(Observer cliente)
        {
            clientes.Remove(cliente);
        }

        public void notificar()
        {
            if (changed == true)
            {
                Console.WriteLine("Hay Cambios en Correos de Mexico!");
                for (int i = 0; i < clientes.Count; i++)
                {
                    clientes[i].update(nombre);

                }
                clearChanged();
            }
            else
            {
                Console.WriteLine("No esta prendido el changed");
            }

        }
        public void measurenntChanged()
        {
            setChanged();
            notificar();
        }

        public void setChanged()
        {
            changed = true;
        }

        public void clearChanged()
        {
            changed = false;
        }
    }
}
