using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 04";

      //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
      //(excluido el mismo) que son divisores del número.
      //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
      //Escribir una aplicación que encuentre los 4 primeros números perfectos.
      //Nota: Utilizar estructuras repetitivas y selectivas.
      int cont = 0;
      int acum = 0;

      Console.WriteLine("Los cuatro primeros nros. perfectos son: ");

      for (int i = 2; cont < 4; i++)
      {
        for (int j = 1; j < i; j++)
        {
          if (i % j == 0)
          {
            acum += j;
          }

        }

        if (acum == i)
        {
          cont++;
          Console.WriteLine(i);
        }

        acum = 0;
      }

      Console.ReadKey();
    }
  }
}
