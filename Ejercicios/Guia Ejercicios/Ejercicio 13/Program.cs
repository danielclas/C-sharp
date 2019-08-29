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

            Console.Title = "Ejercicio 13";
            
            char rta = '1';
            string aux = "";
            string bin = "";
            double num = 0;

            do
            {
                Console.WriteLine("1. Decimal a binario");
                Console.WriteLine("2. Binario a decimal");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nOpcion: ");
                rta = char.Parse(Console.ReadLine());

                if (rta == '2')
                {
                    Console.WriteLine("Ingrese nro. binario (solo entero): ");
                    aux = Console.ReadLine();
                    num = Conversor.BinarioDecimal(aux);
                    //aux = Conversor.FormatearBinario(aux);
                    Console.Clear();
                    Console.WriteLine($"Binario: {aux}");
                    Console.WriteLine($"Decimal: {num}");
                }
                else if (rta == '1')
                {
                    Console.WriteLine("Ingrese nro. decimal (entero o con coma): ");
                    num = double.Parse(Console.ReadLine());
                    bin = Conversor.DecimalBinario(num);
                    //bin = Conversor.FormatearBinario(bin);
                    Console.Clear();
                    Console.WriteLine($"Decimal: {num}");
                    Console.WriteLine($"Binario: {bin}");
                }

                Console.ReadKey();
                Console.Clear();

            } while (rta != '3');
        }
    }
}
