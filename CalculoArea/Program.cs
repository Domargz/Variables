using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reto 
            int a = 10, b = 10, c = 7;
            int area = (b * a) / 2;
            Console.WriteLine("El area del triangulo es: " + area);
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
