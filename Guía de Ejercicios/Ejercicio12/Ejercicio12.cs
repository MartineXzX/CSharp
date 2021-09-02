using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int num1;
            string resp;
            int acum = 0;
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Desea continuar (S/N): ");
                resp = Console.ReadLine();

                seguir = ValidarRespuesta.ValidaS_N(Convert.ToChar(resp));
                acum += num1;
            }
            Console.WriteLine(string.Format("La suma de los numeros es {0}", acum));
            Console.ReadKey();
        }
    }
}
