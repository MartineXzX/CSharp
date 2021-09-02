using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 10;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        /// <summary>
        /// El metodo Pintar restara la tinta gastada, avisando si pudo pintar e informara el nivel de tinta que se gasto.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            if (gasto < this.tinta)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                for (int f = 0; f < this.tinta; f++)
                {
                    dibujo += "*";
                }
            }

             bool aux = this.tinta >= 0;
            SetTinta(gasto);
            return aux;
        }

        /// <summary>
        /// El metodo Recargar colocará a tinta en su nivel máximo de tinta.
        /// </summary>
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// El metodo SetTinta validara el nivel de tinta.
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

    }
}
