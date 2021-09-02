using Ejercicio17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17Practica
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string dibujito1, dibujito2;

            //INSTANCIAMOS BOLIGRAFO
            Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(3, ConsoleColor.Red);

            //LLAMAMOS AL METODO PINTAR

            if (!b1.Pintar(12, out dibujito1))
            {
                Console.WriteLine("El boligrafo se quedo sin tinta");
            }
            if (b2.Pintar(50, out dibujito2))
            {
                Console.WriteLine("El boligrafo se quedo sin tinta");
            }

            //LLAMAMOS AL METODO RECARGAR
            b1.Recargar();
            b2.Recargar();

            //SEATEMOS EL COLOR
            Console.ForegroundColor = b1.GetColor();
            Console.WriteLine(dibujito1);

            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine(dibujito2);

            Console.ReadKey();
        }
    }
}
