using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";

            string fechaNacimiento;
            TimeSpan diasVividos;

            Console.WriteLine("Ingrese dia, mes y año de nacimiento: (mm/dd/aaaa)?");
            fechaNacimiento = Console.ReadLine();

            diasVividos = DateTime.Now - Convert.ToDateTime(fechaNacimiento);

            Console.WriteLine(string.Format("Dias vividos: {0}", diasVividos.Days));
            Console.ReadKey();
        }
    }
}
