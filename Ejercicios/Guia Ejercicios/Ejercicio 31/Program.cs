using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 31";

      Negocio n = new Negocio("Negocio 1");
      PuestoAtencion p = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
      Cliente c1 = new Cliente(1, "Cliente 1");
      Cliente c2 = new Cliente(2, "Cliente 2");
      Cliente c3 = new Cliente(3, "Cliente 3");

      if (n+c1)
      {
        Console.WriteLine("Pudo agregarse C1");
        Console.WriteLine($"Nombre: {c1.Nombre}, #{c1.Numero}");
      }
      else
      {
        Console.WriteLine("No pudo agregarse C1");
      }

      if (n+c2)
      {
        Console.WriteLine("Pudo agregarse C2");
        Console.WriteLine($"Nombre: {c2.Nombre}, #{c2.Numero}");
      }
      else
      {
        Console.WriteLine("No pudo agregarse C2");
      }

      if (n+c3)
      {
        Console.WriteLine("Pudo agregarse C3");
        Console.WriteLine($"Nombre: {c3.Nombre}, #{c3.Numero}");
      }
      else
      {
        Console.WriteLine("No pudo agregase C3");
      }

      Console.WriteLine("\nPruebo agregar C1 de vuelta");

      if (n+c1)
      {
        Console.WriteLine("Pude sumar C1");
      }
      else
      {
        Console.WriteLine("No pude sumar C1");
      }

      Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");

      if (~n)
      {
        Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
      }
      else
      {
        Console.WriteLine("No pudo atenderse al cliente");
      }

      if (~n)
      {
        Console.WriteLine($"Clientes pendientes: {n.ClientesPendientes}");
      }
      else
      {
        Console.WriteLine("No pudo atenderse al cliente");
      }

      Console.ReadKey();
    }
  }
}
