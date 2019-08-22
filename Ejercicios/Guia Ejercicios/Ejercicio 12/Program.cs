using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            cualquier otro valor.*/

            Console.Title = "Ejercicio 12";

            int num = 0;
            int acum = 0;
            char rta;
            string aux;

            do {

                Console.WriteLine($"Suma: {acum}");
                Console.WriteLine("Ingrese un numero: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out num))
                {
                    acum += num;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor ingresado no valido");
                    Console.ReadKey();
                    Console.ResetColor();
                }

                Console.WriteLine("Seguir sumando? S/N");
                rta = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (ValidarRespuesta.ValidaS_N(rta));

            Console.WriteLine($"Suma final: {acum}");

            Console.ReadKey();
        }
    }

    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool valid = false;
            c = char.ToLower(c);

            if (c == 's')
            {
                valid = true;
            }

            return valid;

        }
    }
}
