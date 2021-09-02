using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            if (franjaHoraria == Franja.Franja_1)
            {
                return base.duracion * 0.99f;
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                return base.duracion * 1.25f;
            }
            else
            {
                return base.duracion * 0.66f;
            }
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.CostoLlamada.ToString());
            sb.AppendLine("Franja horaria: " + this.franjaHoraria);

            return sb.ToString();
        }




    }
}
