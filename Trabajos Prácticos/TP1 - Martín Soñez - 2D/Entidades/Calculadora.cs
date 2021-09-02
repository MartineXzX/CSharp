using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que no sea un operador invalido, y de ser asi asigna "+" por default
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double returnValue = 0;
            char charOperator;

            if (String.IsNullOrEmpty(operador) || (operador != "+" && operador != "-" && operador != "*" && operador != "/"))
            {
                operador = "+";
            }

            if (char.TryParse(operador, out charOperator))
            {
                switch (ValidarOperador(charOperator))
                {
                    case "+":
                        returnValue = num1 + num2;
                        break;
                    case "-":
                        returnValue = num1 - num2;
                        break;
                    case "*":
                        returnValue = num1 * num2;
                        break;
                    case "/":
                        returnValue = num1 / num2;
                        break;
                    default:
                        returnValue = num1 + num2;
                        break;
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Valida que el operador recibido sea válido o retorna "+" en caso contrario.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador recibido o "+" en caso de un operador inválido</returns>
        private static string ValidarOperador(char operador)
        {
            string returnValue = String.Empty;

            switch (operador)
            {
                case '+':
                    returnValue = "+";
                    break;
                case '-':
                    returnValue = "-";
                    break;
                case '*':
                    returnValue = "*";
                    break;
                case '/':
                    returnValue = "/";
                    break;
                default:
                    returnValue = "+";
                    break;
            }

            return returnValue;
        }
    }
}
