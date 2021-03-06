﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 3, 4, 5, 9, 12, 16, 29, 44, 45, 68, 83, 97, 99, 400, 500 };

            list.ForEach(n => Console.WriteLine("VALOR: "+n+" ROMANO: "+ConvertirARomano(n)));

            Console.ReadKey();
        }

        public static string ConvertirARomano(int num)
        {
            int[] valores = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
            string[] letras = new string[] { "I", "V", "X", "L", "C", "D", "M" };

            int resto = num;
            StringBuilder romano = new StringBuilder();
            string rtnVal = "";

            for (var i = 6; i >= 0; i--)
            {
                if (num - valores[i] * 3 >= 0)
                {

                    romano.Append(letras[i]);
                    romano.Append(letras[i]);
                    romano.Append(letras[i]);
                    resto = num - valores[i] * 3;

                }
                else if (num - valores[i] * 2 >= 0)
                {

                    romano.Append(letras[i]);
                    romano.Append(letras[i]);
                    resto = num - valores[i] * 2;

                }
                else if (num - valores[i] * 1 >= 0)
                {

                    romano.Append(letras[i]);
                    resto = num - valores[i] * 1;
                }

                if (resto == 0)
                {
                    break;
                }
            }


            for (int i = romano.Length - 1; i >= 0; i--)
            {
                rtnVal += romano[i];
                Console.WriteLine("RESTO: " + resto);
            }

            return rtnVal;
        }
    }
}
