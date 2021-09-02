using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Constructor de Ciclomotor
        /// </summary>
        /// <param name="marca">Marca del ciclomotor</param>
        /// <param name="chasis">Chasis del ciclomotor</param>
        /// <param name="color">Color del ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve tamaño de Ciclomotor (Chico)
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Sobreescribe metodo heredado agregando propiedades de Ciclomotor
        /// </summary>
        /// <returns>Cadena con informacion del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine("CICLOMOTOR");
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            returnAux.AppendLine("-------------------------");

            return returnAux.ToString();
        }
        #endregion
    }
}
