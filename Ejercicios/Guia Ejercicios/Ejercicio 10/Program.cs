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

            int num = 0;
            string aux = "";
            StringBuilder pir = new StringBuilder("");

            Console.WriteLine("Ingrese un nro.: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out num) && num > 0)
            {

                pir.Insert(0, " ", num+1);
                pir[pir.Length - 1] = '*';
                Console.WriteLine("{0}", pir);

                for(int i=num-1; i >=0; i--)
                {
                    pir.Append('*');
                    pir[i] = '*';
                    Console.WriteLine("{0}", pir);
                }
            }

            Console.ReadKey();
        }
    }
}
