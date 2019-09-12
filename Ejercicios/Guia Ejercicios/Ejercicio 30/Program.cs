using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 30";

      Competencia comp = new Competencia(50, 5);
      AutoF1 a1 = new AutoF1(5, "Fiat");
      AutoF1 a2 = new AutoF1(10, "Ford");
      AutoF1 a3 = new AutoF1(15, "Renault");

      Console.Write("Datos a1: ");
      Console.WriteLine(a1.mostrarDatos());

      if (comp+a1)
      {
        Console.WriteLine("Auto 1 agregado correctamente");
      }
      else
      {
        Console.WriteLine("No pudo agregarse el auto 1");
      }

      if (comp + a2)
      {
        Console.WriteLine("Auto 2 agregado correctamente");
      }
      else
      {
        Console.WriteLine("No pudo agregarse el auto 2");
      }

      if (comp + a1)
      {
        Console.WriteLine("Auto 1 agregado correctamente");
      }
      else
      {
        Console.WriteLine("No pudo agregarse el auto 1");
      }

      if (comp + a3)
      {
        Console.WriteLine("Auto 3 agregado correctamente");
      }
      else
      {
        Console.WriteLine("No pudo agregarse el auto 3");
      }

      Console.WriteLine(comp.MostrarDatos());

      if (comp - a1)
      {
        Console.WriteLine("Auto 1 restado correctamente");
      }
      else
      {
        Console.WriteLine("No pudo restarse el auto 1");
      }

      Console.WriteLine(comp.MostrarDatos());

      Console.ReadKey();

    }
  }
}
