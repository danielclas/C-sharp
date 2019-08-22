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

            Console.Title = "Ejercicio 13";            char rta = '1';            string aux = " ";            double num = 0;            do {

                Console.WriteLine("1. Decimal a binario");
                Console.WriteLine("2. Binario a decimal");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nOpcion: ");
                rta = char.Parse(Console.ReadLine());

                if (rta == '2') {
                    Console.WriteLine("Ingrese nro. binario: ");
                    aux = Console.ReadLine();
                    num=Conversor.BinarioDecimal(aux);
                    Console.WriteLine($"Decimal: {num}");
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
            string bin=" ";





            return bin;

        }

        public static double BinarioDecimal(string num)
        {
            double dec=0;

            for (int i = num.Length - 1, exp = 0; i >= 0; i--, exp++)
            {
                if (num[i] == '1')
                {
                    dec += Math.Pow(2, exp);
                }
            }

            return dec;

        }
    }
}
