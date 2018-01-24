using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClases_Campos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOY UN ESTUDIANTE");
            //Estudiante Normal
            Estudiante estudiante = new Estudiante(new Normal());
            estudiante.Caminar();
            estudiante.Respirar();
            estudiante.Brincar();
            //Estudiante cambia a lastimado
            Console.WriteLine("Tuve un accidente!");
            estudiante.Asignar(new Lastimado());
            estudiante.Caminar();
            estudiante.Respirar();
            estudiante.Brincar();
            //Estudiante cambia a Discapacitado
            Console.WriteLine("Tuve otro accidente!");
            estudiante.Asignar(new Discapacitado());
            estudiante.Caminar();
            estudiante.Respirar();
            estudiante.Brincar();

            //Cocinero discapacitado
            Cocinero cocinero = new Cocinero(new Discapacitado());
            Console.WriteLine("SOY UN COCINERO Y ESTOY DISCAPACITADO");
            cocinero.Asignar(new Discapacitado());
            cocinero.Caminar();
            cocinero.Respirar();
            cocinero.Brincar();
            Console.ReadKey();
        }
    }
}
