using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";

            int contador = 0, acum = 0;

            for (int f = 1; contador < 4; f++)
            {
                acum = 0;
                for (int i = 1; i < f; i++)
                {
                    if (f % i == 0)
                    {
                        acum += i;
                    }
                }

                if (acum == f)
                {
                    contador++;
                    Console.WriteLine(string.Format("El numero {0} es perfecto ", f));
                }
            }
            Console.ReadKey();
        }
    }
}
