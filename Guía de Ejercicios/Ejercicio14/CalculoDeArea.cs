using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2); // calculamos el area del cuadrado, el "Math.Pow" nos permite calcular potencias.
                                      // otra forma de calcularlo (lado * lado)
        }
        public static double CalcularTriangulo(double baseNum, double alturaNum)
        {
            return (baseNum * alturaNum) / 2; // Area del triangulo: base por altura dividio dos.
        }

        public static double CalcularCirculo(double radio)
        {
            double pi = 3.14;
            return Math.Pow((pi * radio), 2); 
        }
    }
}
