using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        public static int Calcular(int numUno, int numDos, string operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = numUno + numDos;
                    break;
                case "-":
                    resultado = numUno - numDos;
                    break;
                case "*":
                    resultado = numUno * numDos;
                    break;
                default:
                    if (Calculadora.Calcular(numDos))
                    {
                        resultado = numUno / numDos;
                    }
                    break;
            }
            return resultado;
        }

        static bool Calcular(int numDos)
        {
            return numDos != 0;
        }



    }
}
