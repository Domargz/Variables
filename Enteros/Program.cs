using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reglas: 
            //  1. No iniciar en numero el noomnre
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;

            int suma = numero_1 + numero_2 + numero_3;
            
            Console.WriteLine("El valor de SUMA es: "+ suma);
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
