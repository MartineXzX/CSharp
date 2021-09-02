using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio8";

            StringBuilder sb = new StringBuilder();
            string seguir = "s";
            float importeBruto, importeNeto, descuento;

            while (seguir.ToLower() == "s")
            {
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad:");
                int antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese valor hora:");
                int valorHoras = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese horas trabajadas:");
                int horasTrabajadas = int.Parse(Console.ReadLine());

                importeBruto = ((valorHoras * horasTrabajadas) + (antiguedad * 150));
                descuento = importeBruto * 0.13f;
                importeNeto = importeBruto - descuento;

                sb.AppendLine("Nombre: " + nombre);
                sb.AppendLine("Antiguedad: " + antiguedad);
                sb.AppendLine("Valor hora: " + valorHoras);
                sb.AppendLine("Importe Bruto a cobrar: " + importeBruto);
                sb.AppendLine("Descuentos: " + descuento);
                sb.AppendLine("Importe Neto a cobrar: " + importeNeto);
                
                sb.AppendLine("---------------------------------------");

                Console.WriteLine("Desea ingresar otro empleado?: (S/N) ");
                seguir = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}

