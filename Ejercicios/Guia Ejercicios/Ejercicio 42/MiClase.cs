using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  //a.Crear una clase llamada MiClase y dentro colocar un método estático, otro de instancia y 2
  //constructores de instancia.
  //b.Dentro del método estático lanzar una excepción DivideByZeroException(sólo lanzarla).
  //c.Capturar la excepción del punto a en un constructor de instancia y relanzarla hacia otro
  //constructor de instancia.

  //e.Luego crear un método de instancia que capture la excepción anterior. Este método
  //generará una excepción propia llamada MiException y la lanzará.
  //f.MiException será capturada en el Main, mostrando el mensaje de error que esta almacena
  //por pantalla y los mensajes de todas las excepciones almacenadas en sus innerException.
  public class MiClase
  {
    public static void MetodoEstatico()
    {
      throw new DivideByZeroException();
    }

    public void MetodoInstancia()
    {
      try
      {
        new MiClase();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw e;        
      }
    }

    public MiClase(string m)
    {

    }

    public MiClase(int num)
    {
      try
      {
        MiClase.MetodoEstatico();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw e;
      }
    }

    public MiClase()
    {
      try
      {
        new MiClase(5);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw new UnaExcepcion($"Mensaje de UnaExcepcion", e);
      }
    }
  }

  public class UnaExcepcion : Exception
  {
    string mensaje;

    public UnaExcepcion(string mensaje, Exception e):base(mensaje,e)
    {
      this.mensaje = mensaje;
    }

    public UnaExcepcion(string mensaje):base(mensaje)
    {
      this.mensaje = mensaje;
    }
  }
}
