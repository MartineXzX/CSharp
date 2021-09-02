using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string resto = "";

            for (; num >= 2;)
            {
                resto += num % 2; // obtenemos el resto de la division 
                num = num / 2;    // obtenemos cociente de la division 
                                  // otra forma de hacerlo es (num /=2)
            }
            resto += num;
            return Conversor.Invertir(resto);
        }

        public static int BinarioDecimal(string bin)
        {
            int valor = 0;
            bin = Conversor.Invertir(bin);

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    valor += (int)Math.Pow(2, i);
                }
            }
            return valor;
        }

        public static string Invertir(string cadena)
        {
            string cadenaInvertida = "";
            for (int i = cadena.Length - 1; i >= 0; i--)//recorremos el string para invertirlo
            {
                cadenaInvertida += cadena[i];
            }
            return cadenaInvertida;
        }

    }
}
