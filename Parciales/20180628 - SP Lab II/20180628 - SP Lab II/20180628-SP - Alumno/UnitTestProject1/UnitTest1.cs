using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using Excepciones;
using System.Collections.Generic;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    int cont=0;
   
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
      //Arrange
      Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();

      senadores.Add("1", Votacion.EVoto.Abstencion);
      senadores.Add("2", Votacion.EVoto.Afirmativo);
      senadores.Add("3", Votacion.EVoto.Negativo);
      senadores.Add("4", Votacion.EVoto.Afirmativo);
      senadores.Add("5", Votacion.EVoto.Negativo);
      senadores.Add("6", Votacion.EVoto.Afirmativo);

      Votacion votacion = new Votacion("Ley", senadores);
      votacion.EventoVotoEfectuado += ManejadorVoto;
      int suma = 0;      

      //Act
      votacion.Simular();
      suma = votacion.Afirmativos + votacion.Negativos + votacion.Abstenciones;

      //Assert
      Assert.IsTrue(suma == cont);

    }

    public void ManejadorVoto(string senador, Votacion.EVoto voto)
    {
      cont++;
    }
  }
}
