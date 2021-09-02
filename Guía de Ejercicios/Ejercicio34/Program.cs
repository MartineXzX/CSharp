using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> vh = new List<VehiculoTerrestre>();

            vh.Add(new Camion(4, 4, 3, Colores.Azul, 5000));
            vh.Add(new Moto(2, 0, 5, Colores.Negro, 8));
            vh.Add(new Automovil(4, 4, 4, Colores.Gris, 5));

            foreach (VehiculoTerrestre aux in vh)
            {
                Console.WriteLine(aux.Mostrar());
            }

            Console.ReadKey();
        }
    }
}
