using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir por consola el nombre de alguien y su cuidad y
            //mostrarla por pantalla
            string nombre, cuidad;
            Console.WriteLine("Ingrese su nombre.");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su ciudad.");
            cuidad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", Bienvenido a " + cuidad);
            Console.WriteLine("Presione una tecla para fianlizar...");
            Console.ReadKey();

        }
    }
}
