using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio 08";

            char rta = 's';
            float valorHora;
            float horasTrabajadas;
            float bruto;
            float bonoAnt;
            float total;
            float descuentos;
            string nombre;
            int antiguedad;

            do {

                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese valor hora: $");
                valorHora = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese antigüedad: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de horas: ");
                horasTrabajadas = int.Parse(Console.ReadLine());

                bruto = horasTrabajadas * valorHora;
                bonoAnt = antiguedad * 150;
                bruto += bonoAnt;
                total = bruto;
                descuentos = total * (float)0.13;
                total-= descuentos;

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nombre: {0}", nombre);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Antigüedad: {0}", antiguedad);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Valor hora: {0}", valorHora);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Horas trabajadas {0}", horasTrabajadas);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Bruto a cobrar: ${0}", bruto);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Total descuentos: ${0}", descuentos);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Neto a cobrar: ${0}", total);

                Console.ResetColor();
                Console.WriteLine("Desea ingresar otro empleado? S/N");
                rta = char.Parse(Console.ReadLine());

                Console.Clear();

            } while (rta == 's');


            Console.ReadKey();
        }
    }
}
