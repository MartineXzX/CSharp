using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Ejercicio22
{
    public class Ejercicio22
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 22";

            //Converciones Implicitas

            NumeroBinario objBinario = "1000";
            NumeroDecimal objDecimal = 8;

            //Converciones Explicitas

            Console.WriteLine("Converciones Explicitas:");
            Console.WriteLine((string)objBinario);
            Console.WriteLine((double)objDecimal);

            //Sobrecarga de Operadores

            Console.WriteLine("Sobrecarga de Operadores:");
            Console.WriteLine(objBinario + objDecimal);
            Console.WriteLine(objBinario - objDecimal);

            Console.ReadKey();
        }
    }
}
