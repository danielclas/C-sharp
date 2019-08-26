using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta,
            //multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            //operación que desea realizar(pulsando el caracter +, -, *ó /).
            //El usuario decidirá cuándo finalizar el programa.
            //Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):
            //a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
            //operación matemática.El método devolverá el resultado de la operación.
            //b.Validar(privado): Recibirá como parámetro el segundo número. Este método se debe
            //utilizar sólo cuando la operación elegida sea la DIVISIÓN.Este método devolverá
            //TRUE si el número es distinto de CERO

            Console.Title = "Ejercicio 15";

            double a, b;
            char o;
            int times = 0;

            do
            {
                Console.WriteLine("Ingrese nro. a: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nro. b: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese operando: ");
                o = char.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: {0}", Calculadora.Calcular(a, b, o));

                Console.ReadKey();
                Console.Clear();
                times++;

            } while (times < 5);
        }
    }

    class Calculadora
    {
        public static double Calcular(double a, double b, char o)
        {
            double result = 0;

            switch (o)
            {
                case '+':
                    result = a + b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (Validar(b))
                    {
                        result = a / b;
                    }
                    else
                    {
                        result = 1;
                    }                    
                    break;
                case '-':
                    result = a - b;
                    break;
                default:
                    break;
            }

            return result;

        }

        private static bool Validar(double b)
        {
            bool rtn = false;

            if (b != 0)
            {
                rtn = true;
            }
            
            return rtn;

        }
    }
}
