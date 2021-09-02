using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 3";

            bool esPrimo = true;
            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int f = 1; f <= num; f++)
            {
                for (int i = 2; i < f; i++)
                {
                    if ((f % i == 0))
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(f + " es primo.");
                    
                }
                esPrimo = true;
            }

            Console.ReadKey();

        }
    }
}
