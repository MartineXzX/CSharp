using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            // INSTANCIAMOS ALUMNOS
            Alumno alum1 = new Alumno("Fulanito", "detal", 12352);
            Alumno alum2 = new Alumno("Juanito", "Gomez", 45252);
            Alumno alum3 = new Alumno("Lucas", "Polo", 1112);

            //SETEAMOS NOTAS
            alum1.Estudiar(4,2);
            alum2.Estudiar(4,5);
            alum3.Estudiar(5,8);

            //CALCULA NOTA FINAL
            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            //MOSTRAMOS DATOS DE LOS ALUMNOS
            Console.WriteLine(alum1.Mostrar());
            Console.WriteLine(alum2.Mostrar());
            Console.WriteLine(alum3.Mostrar());
            Console.ReadKey();        
        }
    }
}
