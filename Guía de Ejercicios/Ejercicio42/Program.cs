using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 42";

            try
            {
                OtraClase e = new OtraClase();
                e.Metodo();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
