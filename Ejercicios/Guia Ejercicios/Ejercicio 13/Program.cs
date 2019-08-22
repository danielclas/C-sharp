using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
            string DecimalBinario(double). Convierte un número de entero a binario.
            double BinarioDecimal(string). Convierte un número binario a entero.*/

            Console.Title = "Ejercicio 13";            char rta = '1';            string aux = "";            string bin = "";            double num = 0;            do
            {

                Console.WriteLine("1. Decimal a binario");
                Console.WriteLine("2. Binario a decimal");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nOpcion: ");
                rta = char.Parse(Console.ReadLine());

                if (rta == '2')
                {
                    Console.WriteLine("Ingrese nro. binario: ");
                    aux = Console.ReadLine();
                    num = Conversor.BinarioDecimal(aux);
                    Console.WriteLine($"Decimal: {num}");
                }
                else if (rta == '1')
                {
                    Console.WriteLine("Ingrese nro. decimal: ");
                    num = double.Parse(Console.ReadLine());
                    bin = Conversor.DecimalBinario(num);
                    bin = Conversor.FormatearBinario(bin);
                    Console.WriteLine($"Binario: {bin}");

                }

                Console.ReadKey();
                Console.Clear();

            } while (rta != '3');

        }
    }

    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string bin = "";
            string auxBin = "";
            StringBuilder aux = new StringBuilder("");
            int module;
            int result = (int)num;

            do
            {
                module = result % 2;
                result = result / 2;
                aux.Append(module.ToString());

            } while (result / 2 != 1);

            module = result % 2;
            result = result / 2;
            aux.Append(module.ToString());
            aux.Append(result.ToString());

            auxBin = aux.ToString();

            for (int i = auxBin.Length - 1; i >= 0; i--)
            {
                bin += auxBin[i];
            }

            return bin;

        }

        public static double BinarioDecimal(string num)
        {
            double dec = 0;

            for (int i = num.Length - 1, exp = 0; i >= 0; i--, exp++)
            {
                if (num[i] == '1')
                {
                    dec += Math.Pow(2, exp);
                }
            }

            return dec;

        }

        public static string FormatearBinario(string bin)
        {
            string newBin="";
            int resto = 0;
            int i;

            if (bin.Length >= 5)
            {
                resto = bin.Length % 4;

                for (i = 0; i < resto; i++)
                {
                    newBin += bin[i];
                }

                newBin += ' ';
                for (int j=1 ; i < bin.Length; i++, j++)
                {
                    newBin += bin[i];
                    if (j%4==0)
                    {
                        newBin += ' ';
                        j = 1;
                    }
                }


            }
            else
            {
                newBin = bin;
            }

            return newBin;

        }
    }
}
