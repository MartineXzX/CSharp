using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ejercicio42;

namespace Ejercicio45
{
    [TestClass]
    public class Ejercicio45
    {
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void VerificarMetodo()
        {
            MiClase c = new MiClase("clase 2");          
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void VerificarMetodo2()
        {
            OtraClase e = new OtraClase();
            e.Metodo();
        }

    }
}
