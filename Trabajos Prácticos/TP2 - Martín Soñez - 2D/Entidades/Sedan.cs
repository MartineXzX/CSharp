using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Atributos"
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor Sedan. Por defecto, "tipo" será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color): this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }
        /// <summary>
        /// Constructor Sedan opcion de asignación "tipo"
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        /// <param name="tipo">Tipo de Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo): base(chasis, marca, color)    
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve tamaño de Sedan (Mediano)
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Sobreescribe metodo heredado agregando propiedades de Sedan
        /// </summary>
        /// <returns>Cadena con informacion del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine("SEDAN");
            returnAux.AppendLine(base.Mostrar());
            returnAux.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            returnAux.AppendLine("TIPO : " + this.tipo);
            returnAux.AppendLine("-------------------------");

            return returnAux.ToString();
        }
        #endregion
    }
}
