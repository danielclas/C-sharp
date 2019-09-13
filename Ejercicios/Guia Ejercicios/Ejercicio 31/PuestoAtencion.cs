using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class PuestoAtencion
  {
    private static int numeroActual;
    private Puesto puesto;
    public static int NumeroActual { get {return ++numeroActual; } }

    private PuestoAtencion()
    {
       numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto):this()
    {
      this.puesto = puesto;
    }

    public bool Atender(Cliente c)
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Cliente siendo atendido");
      Console.ResetColor();
      System.Threading.Thread.Sleep(2000);

      return true;
    }

    public enum Puesto
    {
      Caja1 = 0,
      Caja2 = 1
    }
  }
}
