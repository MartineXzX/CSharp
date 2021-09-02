using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(float tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.colorTinta = color;
        }
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper e = new EscrituraWrapper(texto, this.colorTinta);
            this.tinta -= (texto.Length * 0.3f);
            return e;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Soy un Boligrafo");
            sb.AppendLine(" Color escritura:" + this.colorTinta);
            sb.AppendLine(" Nivel tinta:" + this.tinta);

            return sb.ToString();
        }
    }
}
