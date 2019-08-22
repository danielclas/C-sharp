using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Escribir un programa que imprima por pantalla una pirámide como
      la siguiente:
      *
      ***
      *****
      *******
      *********
      El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
      ejemplo anterior la altura ingresada fue de 5.
      */

      Console.Title = "Ejercicio 09";

      string aux = "";
      string i = "*";
      string j = "**";
      int num = 0;

      Console.WriteLine("Ingrese un nro.: ");
      aux = Console.ReadLine();

      if (int.TryParse(aux, out num) && num>0)
      {
        Console.WriteLine("{0}", i);
        for (int k = 0; k < num; k++)
        {
          i += j;
          Console.WriteLine("{0}", i);
        }
      }

      Console.ReadKey();

    }
  }
}
