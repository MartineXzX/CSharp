using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionGuia
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 1";
            
            int num, mayor, menor, acum;
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            mayor = num;
            menor = num;
            acum = num;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                if (mayor < num)
                {
                    mayor = num;
                }

                if (menor > num)
                {
                    menor = num;
                }
                acum += num;
            }

            acum = acum / 5;
            Console.WriteLine(string.Format("El numero maximo es {0}, el minimo {1} y promedio {2}", mayor, menor, acum));
            Console.ReadKey();



        }
    }
}
