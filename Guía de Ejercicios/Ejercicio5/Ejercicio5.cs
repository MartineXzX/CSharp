using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";

            int num, m, i, f;
            int acum1 = 0, acum2 = 0;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i < num; i++)
            {
                acum1 = 0;
                acum2 = 0;
                for ( m = 1; m < i; m++)
                {
                    acum1 += m;

                }
                for (f = i+1 ;; f++)
                {
                    acum2 += f;

                    if (acum2 >= acum1)
                    {
                        break;
                    }
                }
                if (acum1 == acum2)
                {
                    Console.WriteLine(string.Format("El centro numerico es {0}", i));
                }
            }
            Console.ReadKey();
        }
    }
}
