using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
      dos grupos de números, cuyas sumas son iguales.
      El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
      cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a
      49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
      Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
      usuario ingrese por consola.
      Nota: Utilizar estructuras repetitivas y selectivas.*/

      Console.Title = "Ejercicio 05";

      string aux = "";
      int num = 0;
      int acum = 0;
      int acum2 = 0;
      bool centro = false;

      Console.WriteLine("Ingrese un nro.: ");
      aux = Console.ReadLine();

      if (int.TryParse(aux, out num))
      {
        Console.WriteLine("Centos numericos: ");
        for (int i = 1; i < num; i++)
        {
          acum = 0;
          acum2 = 0;
          centro = false;

          for (int j = 0; j < i; j++)
          {
            acum += j;
          }

          for (int k = i + 1; ; k++){
            acum2 += k;

            if (acum2 == acum)
            {
              centro = true;
              break;
            }
            else
            {
              if (acum2 > acum)
              {
                break;
              }

            }

          }

          if (centro) {
            Console.WriteLine("{0}", i);
          }

        }

      }
      else
      {
        Console.WriteLine("El dato ingresado no es un numero");
      }

      Console.ReadKey();



    }
  }
}
