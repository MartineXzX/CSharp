using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";

            int i = 0, num, max = -100, min =100, acum = 0;
            float promedio;
            while (i < 10) 
            {
                Console.WriteLine("Ingrese un numero entero: ");
                num = int.Parse(Console.ReadLine());

                if (Validacion.Validar(num ,-100, 100))
                {
                    if (num > max)
                    {
                        max = num; 
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                    i++;
                    acum += num;
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
            }
            promedio = acum / 10;
            Console.WriteLine(string.Format("El promedio {0}, el maximo {1} y minimo {2}", promedio, max, min));
            Console.ReadKey();
        }


    }
}
