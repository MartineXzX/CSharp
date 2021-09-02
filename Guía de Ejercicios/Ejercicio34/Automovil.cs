using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Automovil: VehiculoTerrestre
    {
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad Pasajeros: " + this.cantidadPasajeros);

            return sb.ToString();
        }
    }
}
