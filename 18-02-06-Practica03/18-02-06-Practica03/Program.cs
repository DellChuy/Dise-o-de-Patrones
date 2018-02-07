using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_06_Practica03
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData datos = new WeatherData();
            DisplayA displayA = new DisplayA();
            DisplayB displayB = new DisplayB();
            datos.registrar(displayA);
            datos.registrar(displayB);
            datos.temperatura = 10.90;
            datos.humedad = 500.878898;
            datos.presion = 100.873;

            datos.measurenntChanged();
            
           
            Console.ReadKey();

        }
    }
}
