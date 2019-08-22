using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
      una pirámide como la siguiente:
                            *
                           ***
                          *****
                         *******
                        *********
      Nota: Utilizar estructuras repetitivas y selectivas.*/

      Console.Title = "Ejercicio 10";

      int index = 0;
      int menos = 1;
      string aux = "";
      string pir = "";

      Console.WriteLine("Ingrese un nro.: ");
      aux = Console.ReadLine();

      if (int.TryParse(aux, out index) && index > 0)
      {
        


      }
      
      Console.ReadKey();
    }
  }
}
