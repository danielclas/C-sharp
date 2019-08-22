using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
  class Program
  {
    static void Main(string[] args)
    {

      /*
       Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
      por consola.
      Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
      */

      Console.Title = "Ejercicio 03";

      string aux = "";
      int num = 0;
      bool k = false;
      bool primo = false;

      do
      {
        Console.WriteLine("Ingrese nro.: ");
        aux = Console.ReadLine();

        if (int.TryParse(aux, out num))
        {
          if (num > 0)
          {

            k = true;
            Console.WriteLine("Los numeros primos son: ");

            for (int i = 1; i < num; i++)
            {
              primo = true;

              for (int j = i-1; j > 1; j--)
              {
                if (i % j == 0)
                {
                  primo = false;
                }
              }

              if (primo)
              {
                Console.WriteLine("-{0,5}", i);
              }
            }

          }
        }
      } while (!k);

      Console.ReadLine();
    }
  }
}
