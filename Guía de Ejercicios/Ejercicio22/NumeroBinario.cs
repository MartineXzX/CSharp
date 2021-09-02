using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Ejercicio22
{
    public class NumeroBinario
    {
        public string numero;
        private NumeroBinario(string aux)
        {
            this.numero = aux;
        }
        //public double BinarioADecimal()
        //{
        //    return Conversor.BinarioDecimal(this.numero);
        //}

        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }

        public static implicit operator NumeroBinario(string b)
        {
            return new NumeroBinario(b);
        }
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.DecimalBinario((int)d.numero + Conversor.BinarioDecimal(b.numero));
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.DecimalBinario((int)d.numero - Conversor.BinarioDecimal(b.numero));

        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (int)d.numero == Conversor.BinarioDecimal(b.numero);
        }
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return b == d;
        }
    }
}
