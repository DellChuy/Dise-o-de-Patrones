using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02_06_Practica03
{
    class WeatherData : Subject
    {
        public double temperatura { get; set; }
        public double humedad { get; set; }
        public double presion { get; set; }
        public bool changed = false;
        List<WeatherObserver> observadores = new List<WeatherObserver>();

        public void registrar(WeatherObserver nuevo)
        {
            observadores.Add(nuevo);
            Console.WriteLine("Se registro correctamente!");
        }

        public void remover(WeatherObserver observer)
        {
            observadores.Remove(observer);
        }

        public void notificar()
        {
            if(changed == true)
            {
                Console.WriteLine("Hay Cambios!");
                for (int i = 0; i < observadores.Count; i++)
                {
                    observadores[i].update(temperatura, humedad, presion);

                }
                clearChanged();
            }
            else
            {
                Console.WriteLine("No esta prendido el changesd");
            }
            
        }
        public void measurenntChanged()
        {
            //setChanged();
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
