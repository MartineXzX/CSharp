using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        public void Metodo()
        {
            try
            {
                MiClase m = new MiClase("");
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Error Otra clase", ex);
            }
        }
    }
}
