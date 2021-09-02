using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 2";
            double cuadrado, cubo;

            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());

            while (num < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);
            Console.WriteLine(string.Format("El cuadrado es {0} y el cubo es {1}", cuadrado, cubo));
            Console.ReadKey();
        }
    }
}
