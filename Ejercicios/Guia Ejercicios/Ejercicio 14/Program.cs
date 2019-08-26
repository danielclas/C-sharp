using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
            cálculo del área que corresponda:
            a. double CalcularCuadrado(double)
            b. double CalcularTriangulo(double, double)
            c. double CalcularCirculo(double)
            El ingreso de los datos como la visualización se deberán realizar desde el método Main().
             */

            Console.Title = "Ejercicio 14";

            char rta = ' ';
            double lado1 = 0;
            double lado2 = 0;
            double area = 0;

            do
            {

                Console.WriteLine("1. Area cuadrado");
                Console.WriteLine("2. Area triangulo");
                Console.WriteLine("3. Area circulo");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Opcion: ");
                rta = char.Parse(Console.ReadLine());

                switch (rta)
                {
                    case '1':
                        Console.WriteLine("Ingrese lado: ");
                        lado1 = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCuadrado(lado1);
                        Console.WriteLine(area);
                        break;
                    case '2':
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularTriangulo(lado1, lado2);
                        Console.WriteLine(area);
                        break;
                    case '3':
                        Console.WriteLine("Ingrese radio del circulo: ");
                        lado1 = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCirculo(lado1);
                        Console.WriteLine(area);
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (rta != '3');
        }
    }

    class CalculoDeArea
    {
        static public double CalcularCuadrado(double lado)
        {
            double area;

            area = lado * lado;

            return area;
        }

        static public double CalcularTriangulo(double lado1, double lado2)
        {
            double area;
            double a, b;

            if (lado1 == lado2)
            {
                area = Math.Sqrt(3) / 4;
                area *= lado1 * lado1;
            }
            else
            {
                if (lado1 > lado2)
                {
                    a = lado1;
                    b = lado2;
                }
                else
                {
                    a = lado2;
                    b = lado1;
                }

                area = (a * a) / 4;
                area = (b * b) - area;
                area = Math.Sqrt(area);
                area *= b;
                area = area / 2;
            }

            return area;
        }

        static public double CalcularCirculo(double lado)
        {
            double area;

            area = Math.PI * (lado * lado);

            return area;
        }



    }
}
