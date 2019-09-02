using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //26.Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
            //cero de forma aleatoria utilizando la clase Random.
            //a.Mostrar el vector tal como fue ingresado
            //b.Luego mostrar los positivos ordenados en forma decreciente.
            //c.Por último, mostrar los negativos ordenados en forma creciente.

            Console.Title = "Ejercicio 26";            Random random = new Random();            int[] array = new int[20];            int[] may = new int[20];            int[] men = new int[20];            int j=0, k=0, aux=0;            Console.WriteLine("Array sin ordenar: \n");            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                if (array[i]<0)
                {
                    array[j] = array[i];
                    j++;
                }
                else
                {
                    array[k] = array[i];
                    k++;
                }
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Menores ordenados creciente\n");
            //J es Length de mayores
            for (int a = 0; a < j-1; a++)
            {
                for (int b = a+1; b < j; b++)
                {
                    if (men[b] < men[a])
                    {
                        aux = men[b];
                        men[b] = men[a];
                        men[a] = aux;
                    }
                }
            }

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(men[i]);
            }

            Console.WriteLine("Mayores ordenados decreciente\n");
            //K es Length de mayores
            for (int a = 0; a < k - 1; a++)
            {
                for (int b = a + 1; b < k; b++)
                {
                    if (may[b] < may[a])
                    {
                        aux = may[b];
                        may[b] = may[a];
                        may[a] = aux;
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(may[k]);
            }


            Console.ReadKey();

        }
    }
}
