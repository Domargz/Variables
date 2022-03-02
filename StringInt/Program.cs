using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, edad;
            Console.WriteLine("Ingrese su nombre.");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad.");
            edad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " y tienes: " + edad + " años");
            Console.WriteLine("Presione una tecla para fianlizar...");
            Console.ReadKey();
        }
    }
}
