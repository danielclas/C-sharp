using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using Excepciones;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
   /*
    10.2.	Realizar un test que compruebe que el evento de la clase Votacion tantas veces
    como Senadores haya. O sea, si hay 2 senadores el evento será invocado 2 veces.
    */
    [TestMethod]
    public void TestSerializacion()
    {
      //Arrange
      SerializarXML<Votacion> serializer = new SerializarXML<Votacion>();
      Exception ex=null;

      //Act
      try
      {
        serializer.Guardar("H:\\", new Votacion("Ley", null));
      }
      catch (Exception e)
      {
        ex = e;
      }

      //Assert
      Assert.IsInstanceOfType(ex, typeof(Excepciones.ErrorArchivoExcepcion));
    }

    [TestMethod]
    public void TestSenadores()
    {

    }
  }
}
