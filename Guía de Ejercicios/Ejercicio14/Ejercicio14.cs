using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            //// INGRESO DE DATOS DEL CUADRADO
            //Console.WriteLine("Ingrese medida del lado del cuadrado: ");
            //double lado = double.Parse(Console.ReadLine());

            //// VISUALIZACION DE DATOS DEL CUADRADO
            //Console.WriteLine(string.Format("El area del cuadrado es {0}.",CalculoDeArea.CalcularCuadrado(lado) ));
            //Console.ReadKey();

            //----------------------------------------------------

            // INGRESO DE DATOS DEL TRIANGULO
            //Console.WriteLine("Ingrese base del triangulo: ");
            //double baseUno = double.Parse(Console.ReadLine());

            // Console.WriteLine("Ingrese altura del triangulo: ");
            //double alturaUno = double.Parse(Console.ReadLine());

            //// VISUALIZACION DE DATOS DEL TRIANGULO
            //Console.WriteLine(string.Format("El area del triangulo es {0}.",CalculoDeArea.CalcularTriangulo(baseUno, alturaUno)));
            //Console.ReadKey();

            //----------------------------------------------------

            // INGRESO DE DATOS DEL CIRCULO
            Console.WriteLine("Ingrese radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());

            // VISUALIZACION DE DEL CIRCULO
            Console.WriteLine(string.Format("El area del triangulo es {0}.", CalculoDeArea.CalcularCirculo(radio)));
            Console.ReadKey();


        }
    }
}
