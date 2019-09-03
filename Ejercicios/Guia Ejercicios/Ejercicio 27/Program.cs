using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";
            Console.WriteLine("Lista: ");
         
            List<int> lista = new List<int>();
            List<int> men = new List<int>();
            List<int> may = new List<int>();
            Random random = new Random();
            string menores = "", mayores = "", sLista = "";

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100,100));
                sLista += ($"{lista[i]}, ");
            }

            Console.WriteLine("Lista sin ordenar: \n");
            sLista=sLista.Remove(sLista.Length - 2);
            Console.WriteLine(sLista);

            foreach (int n in lista)
            {
                if (n<0)
                {
                    men.Add(n);
                }
                else
                {
                    may.Add(n);
                }
            }

            men.Sort();
            foreach (int n in men)
            {
                menores += ($"{n}, ");
            }

            Console.WriteLine("\nMenores ordenados: \n");
            menores = menores.Remove(menores.Length - 2);
            Console.WriteLine(menores);

            may.Sort();
            may.Reverse();
            foreach (int n in may)
            {
                mayores += ($"{n}, ");
            }

            Console.WriteLine("\nMayores ordenados: \n");
            mayores = mayores.Remove(mayores.Length - 2);
            Console.WriteLine(mayores);

            Console.ReadKey();
            Console.Clear();

            //---------------------------------------------------------//




        }
    }
}
