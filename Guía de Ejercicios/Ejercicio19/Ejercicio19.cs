using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Ejercicio19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();

            //PROBAMOS LA PRIMERA PARTE DEL CODIGO
            Console.WriteLine(s1.Sumar(100, 258));
            Console.WriteLine(s2.Sumar("hola", "pompito"));

            //PROBAMOS LA SEGUNDA PARTE DEL CODIGO

            //Llamamos al Operador Explicit (Int).
            int aux1 = (int)s2;

            //Llamamos al Operador (+) 
            long aux2 = s2 + s1;

            //Llamamos al Operador (|)
            bool aux3 = s2 | s1;

            Console.WriteLine(aux1);
            Console.WriteLine(aux2);
            Console.WriteLine(aux3);
            Console.ReadKey();
        }
    }
}
