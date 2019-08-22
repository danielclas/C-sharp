using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
            siguiente firma: bool Validar(int valor, int min, int max):
            a.valor: dato a validar
            b.min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
            anteriormente que esten dentro del rango - 100 y 100.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.*/

            Console.Title = "Ejercicio 11";

            int cont = 0;
            int valor = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;
            bool valid;
            float prom = 0;
            string aux;

            do
            {
                valid = false;
                Console.WriteLine($"Ingrese nro. #{cont + 1}: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor))
                {
                    if (Validacion.Validar(valor, -100, 100))
                    {
                        valid = true;
                        acum += valor;
                        if (valor > max)
                        {
                            max = valor;
                        }
                        else if (valor<min)
                        {
                            min = valor;
                        }
                    }
                }

                if(!valid)
                {
                    Console.WriteLine("Valor no valido!");
                    cont--;
                    Console.ReadKey();
                }

                Console.Clear();
                cont++;

            } while (cont < 10);

            prom = (float)acum / 10;

            Console.WriteLine($"Promedio: {prom}, Min: {min}, Max: {max}");
            Console.ReadKey();
        }
    }

    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool valid = false;

            if (valor >= min && valor <= max)
            {
                valid = true;
            }

            return valid;
        }

    }
}
