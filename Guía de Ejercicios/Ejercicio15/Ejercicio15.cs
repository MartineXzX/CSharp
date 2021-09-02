using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Ejercicio15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            //INGRESO DE DATOS DE LA OPERACION
            Console.WriteLine("Ingrese un numero:");
            int numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            int numDos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion a realizar: ");
            string operador = Console.ReadLine();

            //MOSTRAMOS LOS DATOS
            Console.WriteLine(string.Format("Resultado: {0}", Calculadora.Calcular(numUno, numDos, operador)));
            Console.ReadKey();
        }
    }
}
