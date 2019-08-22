using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicios
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
            Ingresar 5 números por consola, guardándolos 
            en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.
            */

      Console.Title = "Ejercicio 01";

      int num = 0, acum = 0, cont = 0, max = 0, min = 0;
      float prom = 0;

      do
      {
        Console.WriteLine("Ingrese nro. {0}: ", cont + 1);
        num = int.Parse(Console.ReadLine());

        acum += num;

        if (cont == 0)
        {
          max = num;
          min = num;
        }
        else
        {
          if (num > max)
          {
            max = num;
          }
          else
          {
            if (num < min)
            {
              min = num;
            }
          }
        }

        cont++;
      } while (cont < 5);

      prom = (float)acum / 5;

      Console.WriteLine("Max: {0}, Min: {1}, Sum: {2}, Prom: {3}", max, min, acum, prom);
      Console.ReadKey();

      Console.Clear();



    }
  }
}
