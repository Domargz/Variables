using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10, c = 7;
            int p = a + b + c;
            Console.WriteLine("El perimetro del triangulo es: " + p);
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();

            //Reto 
            int a1 = 10, b1 = 10, c1 = 7;
            int area = (b * a) / 2;
            Console.WriteLine("El area del triangulo es: " + area);
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
