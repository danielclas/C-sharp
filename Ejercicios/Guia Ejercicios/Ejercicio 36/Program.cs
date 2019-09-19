using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 36";

      Competencia comp = new Competencia(50, 5);
      Competencia comp2 = new Competencia(10, 3);

      AutoF1 a1 = new AutoF1(5, "Fiat");
      AutoF1 a2 = new AutoF1(10, "Ford");
      AutoF1 a3 = new AutoF1(15, "Renault");

      MotoCross m1 = new MotoCross(12, "Toyota", 100);
      MotoCross m2 = new MotoCross(19, "Ducati", 120);

      Console.WriteLine(a1.GetType().ToString());

      Console.Write("Datos a1: ");
      Console.WriteLine(a1.mostrarDatos());

      if (comp + a1)
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

      Console.WriteLine($"\nIntento agregar moto: m1\n");

      if (comp + m1)
      {
        Console.WriteLine("Se pudo agregar la moto m1");
      }
      else
      {
        Console.WriteLine("\nNo se pudo agregar la moto m1");
      }

      if (comp2 + m1)
      {
        Console.WriteLine($"Agrego primer moto en competencia nueva: {m1.MostrarDatos()}");
      }
      else
      {
        Console.WriteLine("No pudo agregarse m1 a competencia nueva");
      }

      if (comp2 + m2)
      {
        Console.WriteLine($"Agrego segunda moto en competencia nueva: {m2.MostrarDatos()}");
      }
      else
      {
        Console.WriteLine("No pudo agregarse m2 a competencia nueva");
      }

      Console.WriteLine($"\nAgrego competencia de motos: {comp2.MostrarDatos()}");
      Console.ReadKey();
    }
  }
}
