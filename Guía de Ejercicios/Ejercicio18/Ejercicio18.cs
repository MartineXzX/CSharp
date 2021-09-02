using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;

namespace PruebaGeometria
{
    public class Ejercicio18
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

            //INSTANCIAMOS PUNTOS
            Punto p1 = new Punto(10, 3);
            Punto p2 = new Punto(2, 7);
            Punto p3 = new Punto(4, 4);
            Punto p4 = new Punto(1, 6);

            //INSTANCIAMOS RECTANGULOS
            Rectangulo r1 = new Rectangulo(p1, p3);
            Rectangulo r2 = new Rectangulo(p2, p4);

            //MOSTRAMOS LOS DATOS DE RECTANGULO
            Console.WriteLine(Mostrar(r1));
            Console.WriteLine(Mostrar(r2));
            Console.ReadKey();
        }

        public static string Mostrar(Rectangulo r)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Area: " + r.Area());
            sb.AppendLine("Perimetro: " + r.Perimetro());

            return sb.ToString();
        }

    }
}


