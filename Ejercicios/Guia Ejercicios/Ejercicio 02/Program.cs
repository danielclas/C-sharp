using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
  class Program
  {
    static void Main(string[] args)
    {

      /*
      Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
        mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
       */

      Console.Title = "Ejercicio 02";

      int num = 0;
      string aux = "";
      bool k = false;

      Console.WriteLine("Ingrese un nro.: ");
      aux = Console.ReadLine();

      do { 
          if (int.TryParse(aux, out num))
          {
            if (num > 0)
            {
              Console.WriteLine("Cuadrado: {0}, Cubo {1}", Math.Pow(num, 2), Math.Pow(num, 3));
              k = true;
            }
          }
          else
          {
            Console.WriteLine("Error! Reingresar numero");
          }
      } while (!k);

      Console.ReadKey();
    }
  }
}
