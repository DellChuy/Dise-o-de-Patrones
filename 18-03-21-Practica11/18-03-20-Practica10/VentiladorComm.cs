using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_20_Practica10
{
    class VentiladorComm : Command
    {

        
        Ventilador ventilador;
        public VentiladorComm(Ventilador ventilador)
        {
            this.ventilador = ventilador;
        }
        public void setVentilador(Ventilador ventilador)
        {
            this.ventilador = ventilador;
        }
        public void Execute()
        {
            switch (ventilador.obtenerEstado())
            {
                case "off":
                    ventilador.Slow();

                    break;
                case "slow":
                    ventilador.Medium();
                  
                    break;
                case "medium":
                    ventilador.High();
                   
                    break;
                case "high":
                    
                    ventilador.Off();
                    break;
            }
        }

        public void Undo()
        {
            switch (ventilador.obtenerEstado())
            {
                case "off":
                    Console.WriteLine("Ya estoy apagado");
                    break;
                case "slow":
                    ventilador.Off();
                    
                    break;
                case "medium":
                    ventilador.Slow();
                   
                    break;
                case "high":
                    ventilador.Medium();
                   
                    break;
            }
        }
    }
}
