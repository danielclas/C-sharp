using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Comprueba que un objeto guardado y leido sean identicos
        /// </summary>
        [TestMethod]
        public void TestGuardarYLeer()
        {
            //Arrange
            Planeta planeta = new Planeta(1000, 20, 50, null);
            Planeta planetaLeido;
            short velocidadA, velocidadB;
            short posicionA, posicionB;
            short radioA, radioB;

            //Act
            planeta.GuardarXML();
            planetaLeido = planeta.LeerXML();

            velocidadA = planeta.VelocidadTraslacion;
            velocidadB = planetaLeido.VelocidadTraslacion;

            posicionA = planeta.PosicionActual;
            posicionB = planetaLeido.PosicionActual;

            radioA = planeta.RadioRespectoSol;
            radioB = planeta.RadioRespectoSol;

            //Assert
            Assert.IsTrue(velocidadA == velocidadB && posicionA == posicionB && radioA == radioB);
        }

        /// <summary>
        /// Comprueba la excepcion lanzada por la clase XML sea la esperada
        /// </summary>
        [TestMethod]
        public void TestExcepcion()
        {
            //Arrange
            Planeta planeta;
            Xml<Planeta> xml = new Xml<Planeta>();
            Exception ex = null;

            //Act
            try
            {
                xml.Leer("H:\\", out planeta);
            }
            catch (Exception e)
            {
                ex = e;
            }

            //Assert
            Assert.IsInstanceOfType(ex, typeof(ErrorArchivosException));
        }
    }
}
