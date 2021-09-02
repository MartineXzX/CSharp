using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancias(Llamada.TipoLlamada tipo)
        {
            float acum = 0;

            foreach (Llamada aux in this.listaDeLlamadas)
            {
                //LOCAL
                if (aux is Local)
                {
                    if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                    {
                        acum += ((Local)aux).CostoLlamada;
                    }
                }
                //PROVINCIAL
                else if (aux is Provincial)
                {
                    if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                    {
                        acum += ((Provincial)aux).CostoLlamada;
                    }
                }
            }
            return acum;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social:" + this.razonSocial);
            sb.AppendLine("Ganancia Total:" + this.GananciasPorTotal);
            sb.AppendLine("Ganancia Provincial:" + this.GananciasPorProvincial);
            sb.AppendLine("Ganancia Local:" + this.GananciasPorLocal);

            foreach (Llamada aux in listaDeLlamadas)
            {
                sb.AppendLine("\nDetalle de Llamada: " + aux.Mostrar());
            }

            sb.AppendLine("------------------------------");
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
