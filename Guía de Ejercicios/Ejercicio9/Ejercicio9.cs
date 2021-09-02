using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";

            int altura, f;

            Console.WriteLine("Ingrese un numero entero positivo:" );
            altura = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= altura; i++)
            {
                for (f = 0; f < i*2-1; f++)
                {
                    Console.Write("*");                 
                }
                Console.WriteLine();              
            }
            Console.ReadKey();
        }
    }
}
