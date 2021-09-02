using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";

            int f1, f2;
            int i;
            int[] num = { 1933, 2000, 1264, 1900 };

            Console.WriteLine("Ingrese un año: ");
            f1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro año: ");
            f2 = int.Parse(Console.ReadLine());

            for (i = f1; i <= f2; i++)
            {

                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(string.Format("Año bisiesto: {0}", i));
                }
            }
            Console.ReadKey();

            //foreach (int pompo in num)
            //{
            //    if (pompo % 4 == 0 && pompo % 100 != 0 || pompo % 400 == 0)
            //    {
            //        Console.WriteLine(string.Format("Año bisiesto: {0}", pompo));
            //    }
            //}

            //Console.ReadKey();
        }
    }
}
