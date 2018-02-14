using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_13_PracticaFinal_05
{
    class Persona : Observer
    {
        string idpersona { get; set; }
        List<Paquete> paquetes = new List<Paquete>();

        public Persona (string idpersona)
        {
            this.idpersona = idpersona;
        } 

        public void registrar_paquete(Paquete nuevo)
        {
            if (nuevo.asignado == false)
            {
                paquetes.Add(nuevo);
                Console.WriteLine("Se registro tu paquete con exito");
            }
            else
            {
                Console.WriteLine("Este paquete ya ha se asigno a otro cliente");
            }
        }

        public void update(string paqueteria)
        {
            for(int i = 0; i < paquetes.Count; i++)
            {
                if(paquetes[i].paqueteria == paqueteria)
                {

                    Console.WriteLine("El paquete "+paquetes[i].id_Paquete +" tiene un estado de: " + paquetes[i].Estado + "\n");
                }
            }

        }

    }
}
