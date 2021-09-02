using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42

{
    public class MiClase
    {
        public MiClase(string mensaje)
        {
            try
            {
                MiClase m = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Error clase 2", ex);
            }
        }

        public MiClase()
        {
            try
            {
                MetodoException();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public static void MetodoException()
        {
            throw new DivideByZeroException();
        }

    }
}
