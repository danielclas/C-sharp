using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 42";

      MiClase miClase = new MiClase("Mensaje");

      try
      {
        miClase.MetodoInstancia();
      }
      catch (Exception e)
      {
        Console.WriteLine("Desde el main: {0}", e.Message);
      }

      Console.ReadKey();
    }
  }


}
