using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_06_Practica03
{
    class DisplayA : WeatherObserver,DsiplayMostrar
    {
        double temperatura;
        double humedad;
        double presion;
        public string name = "Dsiplay A";
        public void update(double temp, double hum, double pres)
        {
            temperatura = temp;
            humedad = hum;
            presion = pres;
            Console.WriteLine("Los datos del Display A se han actualizado");
            mostrar();
        }

        public void mostrar()
        {
            Console.WriteLine("Los datos que tengo ahora en el display A son:");
            Console.WriteLine("Temperatura: " + temperatura );
            Console.WriteLine("Humedad: " +  humedad);
            Console.WriteLine("Presion: " + presion);
        }
    }
}
