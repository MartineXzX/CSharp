using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public abstract class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public short cantidadMarchas;
        public Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
        }


        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad Ruedas: "+ this.cantidadRuedas);
            sb.AppendLine("Cantidad Puertas: " + this.cantidadPuertas);
            sb.AppendLine("Cantidad Marchas: " + this.cantidadMarchas);
            sb.AppendLine("Color: " + this.color);

            return sb.ToString();
        }


    }
}
