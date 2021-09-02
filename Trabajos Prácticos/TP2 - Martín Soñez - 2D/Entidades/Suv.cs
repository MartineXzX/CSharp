using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Constructor de SUV
        /// </summary>
        /// <param name="marca">Marca del SUV</param>
        /// <param name="chasis">Chasis del SUV</param>
        /// <param name="color">Color del SUV</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)       
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve el tamaño del SUV
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Sobreescribe metodo heredado agregando propiedades de SUV
        /// </summary>
        /// <returns>Cadena con informacion del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine("SUV");
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            returnAux.AppendLine("-------------------------");

            return returnAux.ToString();
        }
        #endregion
    }
}
