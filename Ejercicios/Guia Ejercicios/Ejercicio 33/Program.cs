using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 33";

            //El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango
            //correcto, sino retornará un string vacio “”. En el set, la asignará si esta ya existe. Si el índice es superior al
            //máximo existente, agregará una nueva página.
            //Generar el código en el Main para probar la clase.

            Libro libro = new Libro();
            int index, i = 0;

            Console.WriteLine("\nPara escribir un libro, copie y pegue un texto despues de los dos puntos debajo.");
            Console.WriteLine("\nLa funcion EscribirLibro() indexara en la lista automaticamente cada palabras");
            Console.WriteLine("\nLa funcion leer libro leera desde esos mismos indices con un espacio entre cada palabras");

            Console.WriteLine("\nEscribir libro: ");
            libro.EscribirLibro(Console.ReadLine());

            Console.WriteLine("\nLeer libro: ");
            libro.LeerLibro();

            do
            {
                Console.WriteLine($"\n\nIngrese un indice para agregar una palabra mayor a 0 y menor a {libro.Count()}: ");
                Console.Write("\nIndice: ");
                index = int.Parse(Console.ReadLine());
                Console.Write("Palabra: ");
                libro[index] = Console.ReadLine();

                Console.WriteLine("\nLeer libro nuevamente: ");
                libro.LeerLibro();

                i++;

            } while (i < 3);            

            Console.ReadKey();
        }
    }
}
