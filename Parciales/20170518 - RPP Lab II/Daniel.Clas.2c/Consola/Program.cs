using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      DirectorTecnico dt = new DirectorTecnico("Gustavo", "Alfaro");
      Equipo equipo = new Equipo("Boca Juniors", dt);

      Jugador j1 = new Jugador("Carlos", "Tevez", 32, true);
      Jugador j2 = new Jugador("Wanchope", "Abila", 9, false);
      Jugador j3 = new Jugador("Esteban", "Andrada", 1, false);
      Jugador j4 = new Jugador("Carlos", "Tevez", 32, false);
      Jugador j5 = new Jugador("Franco", "Soldano");
      Jugador j6 = new Jugador("Frank", "Fabra");
      Jugador j7 = new Jugador("Marcelo", "Weigandt");
      Jugador j8 = new Jugador("Mauro", "Zarate");

      Console.WriteLine("Muestro equipo sin jugadores: \n");
      Console.WriteLine(equipo);

      equipo += j1;
      equipo += j2;
      equipo += j3;
      equipo += j4;
      equipo += j5;
      equipo += j6;
      equipo += j7;
      equipo += j8;

      Console.WriteLine("Muestro equipo habiendo agregado los 8 jugadores: \n");
      Console.WriteLine(equipo);

      Console.WriteLine($"J1 equals J1: {j1.Equals(j1)}");
      Console.WriteLine($"J1 equals J2: {j1.Equals(j2)}");

      Console.WriteLine($"\nJ1 == J1: {j1==j1}");
      Console.WriteLine($"J1 == J2: {j1==j2}");

      Console.WriteLine("Resto Tevez y Zarate y muestro: \n");
      equipo -= j1;
      equipo -= j8;
      Console.WriteLine(equipo);

      Console.WriteLine("Intento agregar a Fabra nuevamente: ");
      equipo += j7;
      Console.WriteLine(equipo);

      Console.ReadKey();
    }
  }
}
