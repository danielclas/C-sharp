﻿using System;
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
            Console.WriteLine("Lista: \n");

            List<int> lista = new List<int>();
            List<int> men = new List<int>();
            List<int> may = new List<int>();
            Random random = new Random();
            string menores = "", mayores = "", sLista = "";

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100, 100));
                sLista += ($"{lista[i]}, ");
            }

            Console.WriteLine("Lista sin ordenar: \n");
            sLista = sLista.Remove(sLista.Length - 2);
            Console.WriteLine(sLista);

            foreach (int n in lista)
            {
                if (n < 0)
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

            Queue<int> enteros = new Queue<int>();
            Queue<int> qMen = new Queue<int>();
            Queue<int> qMay = new Queue<int>();
            string sCola = "";

            menores = "";
            mayores = "";

            for (int i = 0; i < 20; i++)
            {
                enteros.Enqueue(random.Next(-100, 100));
                sCola += ($"{enteros.ElementAt(i)}, ");
            }

            Console.WriteLine("Cola: \n");
            Console.WriteLine("Sin ordenar: \n");
            sCola = sCola.Remove(sCola.Length - 2);
            Console.WriteLine(sCola);

            foreach (int n in enteros)
            {
                if (n <= 0)
                {
                    qMen.Enqueue(n);
                }
                else
                {
                    qMay.Enqueue(n);
                }
            }

            men = qMen.ToList();
            men.Sort();
            qMen = new Queue<int>(men);

            foreach (int n in qMen)
            {
                menores+= ($"{n}, ");
            }

            menores = menores.Remove(menores.Length - 2);
            Console.WriteLine("\nMenores ordenados: \n");
            Console.WriteLine(menores);

            may = qMay.ToList();
            may.Sort();
            may.Reverse();
            qMay = new Queue<int>(may);

            foreach (int n in qMay)
            {
                mayores+= ($"{n}, ");
            }

            mayores = mayores.Remove(mayores.Length - 2);
            Console.WriteLine("\nMayores ordenados: \n");
            Console.WriteLine(mayores);

            Console.ReadKey();
            Console.Clear();

            //----------------------------------------------------//

            Console.WriteLine("Pila: ");
            Stack<int> pila = new Stack<int>();
            Stack<int> pMen = new Stack<int>();
            Stack<int> pMay = new Stack<int>();
            string sPila = "";

            menores = "";
            mayores = "";

            for (int i = 0; i < 20; i++)
            {
                pila.Push(random.Next(-100, 100));
            }            

            foreach (int n in pila)
            {
                if (n<0)
                {
                    pMen.Push(n);
                }
                else
                {
                    pMay.Push(n);
                }

                sPila += ($"{n}, ");
            }

            Console.WriteLine("\nPila sin ordenar: \n");
            sPila = sPila.Remove(sPila.Length - 2);
            Console.WriteLine(sPila);

            men = pMen.ToList();
            men.Sort();
            men.Reverse();
            pMen = new Stack<int>(men);

            foreach (int n in pMen)
            {
                menores += ($"{n}, ");
            }

            Console.WriteLine("\nMenores ordenados: \n");
            menores = menores.Remove(menores.Length - 2);
            Console.WriteLine(menores);

            may = pMay.ToList();
            may.Sort();
            pMay = new Stack<int>(may);

            foreach (int n in pMay)
            {
                mayores += ($"{n}, ");
            }

            Console.WriteLine("\nMayores ordenados: \n");
            mayores = mayores.Remove(mayores.Length - 2);
            Console.WriteLine(mayores);

            Console.ReadKey();
        }
    }
}
