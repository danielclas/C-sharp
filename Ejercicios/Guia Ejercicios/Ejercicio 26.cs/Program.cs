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

            Console.Title = "Ejercicio 26";            Random random = new Random();            string mayores = "";            string menores = "";            string sArray = "";            int[] array = new int[20];            int[] may= new int[20];            int[] men= new int[20];            int j=0, k=0, aux=0;            Console.WriteLine("Array sin ordenar: \n");            //For que asigna al array gral., y al de mayores o menores segun corresponda            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                if (array[i]<0)
                {
                    men[j] = array[i];
                    j++;
                }
                else
                {
                    may[k] = array[i];
                    k++;
                }
                //Cada nro. se agrega al string
                sArray += ($"{array[i].ToString()}, ");
            }

            //Remove de la ultima coma e imprimo
            sArray = sArray.Remove(sArray.Length - 2);
            Console.WriteLine(sArray);

            Console.WriteLine("\nMenores ordenados creciente\n");
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
                menores += ($"{men[i].ToString()}, ");
            }

            menores = menores.Remove(menores.Length - 2);
            Console.WriteLine(menores);

            Console.WriteLine("\nMayores ordenados decreciente\n");
            for (int a = 0; a < k - 1; a++)
            {
                for (int b = a + 1; b < k; b++)
                {
                    if (may[b] > may[a])
                    {
                        aux = may[b];
                        may[b] = may[a];
                        may[a] = aux;
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                mayores += ($"{may[i].ToString()}, ");
            }

            mayores = mayores.Remove(mayores.Length - 2);
            Console.WriteLine(mayores);

            Console.ReadKey();

        }
    }
}
