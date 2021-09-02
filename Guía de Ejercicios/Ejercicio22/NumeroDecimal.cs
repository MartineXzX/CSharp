using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Ejercicio22
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double aux)
        {
            this.numero = aux;
        }
        //public string DecimalABinario()
        //{
        //    return Conversor.DecimalBinario((int)this.numero);
        //}

        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }

        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return Conversor.BinarioDecimal(b.numero) + d.numero;
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return Conversor.BinarioDecimal(b.numero) - d.numero;
        }
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return Conversor.BinarioDecimal(b.numero) == d.numero;
        }
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return b == d;
        }
    }
}
