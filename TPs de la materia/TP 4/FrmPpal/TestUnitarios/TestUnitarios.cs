using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TestListNull()
        {
            Correo correo=new Correo();            

            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void TestTrackingID()
        {
            Paquete paquete = new Paquete("Direccion", "1111");
            Paquete paquete2 = new Paquete("Direccion", "1111");
            Correo correo = new Correo();
            Exception ex = null;

            try
            {
                correo += paquete;
                correo += paquete2;
            }
            catch (Exception e)
            {
                ex = e;
            }

            Assert.IsInstanceOfType(ex, typeof(TrackingIDRepetidoException));
        }
    }
}
