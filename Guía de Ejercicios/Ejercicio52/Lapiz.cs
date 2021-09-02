using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper e = new EscrituraWrapper(texto, this.Color);
            this.tamanioMina -= (texto.Length * 0.1f);
            return e;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Soy un Lapiz");
            sb.AppendLine(" Color escritura:" + this.Color);
            sb.AppendLine(" Tamaño mina:" + this.tamanioMina);

            return sb.ToString();
        }
    }
}
