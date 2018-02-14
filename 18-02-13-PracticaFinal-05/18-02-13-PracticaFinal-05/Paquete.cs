using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_13_PracticaFinal_05
{
    public class Paquete
    {
        public string id_Paquete { get; set; }
        public string Direccion { get; set; }
        public string paqueteria { get; set; }
        public string Estado { get; set; }
        public bool asignado { get; set; }

        public Paquete(string id,string direccion,string paq)
        {
            id_Paquete = id;
            Direccion = direccion;
            paqueteria = paq;
            Estado = "En camino";
            asignado = false;
        } 



    }
}
