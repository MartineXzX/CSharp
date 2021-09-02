using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Moto: VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color)
        {
            this.cilindrada = cilindrada;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cilindrada: " + this.cilindrada);

            return sb.ToString();
        }
    }
}
