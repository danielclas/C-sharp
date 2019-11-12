using System;
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

            Console.WriteLine("5 es: "+ConvertirARomano(5));
            Console.ReadKey();
        }

        public static string ConvertirARomano(int num)
        {
            int[] valores = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
            string[] letras = new string[] { "I", "V", "X", "L", "C", "D", "M" };

            int resto=num;
            StringBuilder romano = new StringBuilder();
            string rtnVal = "";

            do
            {
                for (var i = 6; i >= 0; i--)
                {
                    Console.WriteLine(valores[i]);
                    if (num - valores[i] * 3 >= 0)
                    {

                        romano.Append(letras[i]);
                        resto = num - valores[i] * 3;

                    }
                    else if (num - valores[i] * 2 >= 0)
                    {

                        romano.Append(letras[i]);
                        resto = num - valores[i] * 2;

                    }
                    else if (num - valores[i] * 1 >= 0)
                    {

                        romano.Append(letras[i]);
                        resto = num - valores[i] * 1;
                    }

                    if (resto==0)
                    {
                        break;
                    }
                }
            } while (resto > 0);

            rtnVal = (string)romano.ToString().Reverse();

            return rtnVal;
        }
    }
}
