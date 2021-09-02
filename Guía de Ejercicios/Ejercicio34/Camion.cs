using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Camion : VehiculoTerrestre
    {
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color)
        {
            this.pesoCarga = pesoCarga;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Peso Carga: "+ this.pesoCarga);

            return sb.ToString();
        }
        

    }
}
