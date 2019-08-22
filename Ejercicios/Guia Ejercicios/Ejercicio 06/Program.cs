using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
        también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
       */

      bool b = false;
      string aux = "";
      string aux2 = "";
      int anio = 0;
      int anio2 = 0;
      int i = 0;
      char rta = 's';

      do
      {
        Console.WriteLine("Ingrese un año: ");
        aux = Console.ReadLine();

        Console.WriteLine("Ingrese otro año: ");
        aux2 = Console.ReadLine();

        if (int.TryParse(aux, out anio) && int.TryParse(aux2, out anio2))
        {
          Console.WriteLine("Años bisiestos: ");
          for (i = anio; i < anio2; i++)
          {
            b = false;

            if (i > 0 && i % 4 == 0)
            {
              if (i % 100 == 0)
              {
                if (i % 400 == 0)
                {
                  b = true;
                }
              }
              else
              {
                b = true;
              }
            }

            if (b)
            {
              Console.WriteLine($"{i}");
            }
          }                 
        }
        else
        {
          Console.WriteLine("Ingrese nro. valido!");
        }

        Console.WriteLine("Ingresar otro año? S/N: ");
        rta = char.Parse(Console.ReadLine());
        rta = char.ToLower(rta);
        Console.Clear();

      } while (rta != 'n');

      Console.ReadKey();

    }
  }
}
