using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_01_29_Practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            Nombre nombre = new Nombre("Jesus");
            Correo correo = new Correo("jesus@gmail.com");
            Telefono telefono = new Telefono("6646943573");
            Fecha fecha = new Fecha("10/13/1997");
            Registro registro = new Registro("45678");

            Formulario formulario = new Formulario();
            formulario.campos.Add(nombre);
            formulario.campos.Add(correo);
            formulario.campos.Add(telefono);
            formulario.campos.Add(fecha);
            formulario.campos.Add(registro);

            formulario.ValidarTodo();

            Console.ReadKey();

        }
    }
}
