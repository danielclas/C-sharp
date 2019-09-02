using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.Crear dos constructores:

            //i.Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
            //ii.Sumador() inicializa cantidadSumas en 0.Reutilizará al primer constructor.

            //b.El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
            //siguiente lógica:

            //i.En el caso de Sumar(long, long) sumará los valores numéricos
            //ii.En el de Sumar(string, string) concatenará las cadenas de texto.

            //Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.

            //c.Generar una conversión explícita que retorne cantidadSumas.

            //d.Sobrecargar el operador + (suma)para que puedan sumar cantidadSumas y retornen un long
            //con dicho valor.

            //e.Sobrecargar el operador | (pipe)para que retorne True si ambos sumadores tienen igual
            //cantidadSumas.

            //Agregar un segundo objeto del tipo Sumador en el Main y probar el código

            Console.Title = "Ejercicio 19";

            Sumador s1 = new Sumador(); //Inicializa con 0
            Sumador s2 = new Sumador(10); //Inicializa con 10

            Console.WriteLine($"Sumador 1 10+10: {s1.Sumar(10,10)} Sumador 1 aaa + bbb: {s1.Sumar("aaa","bbb")}");
            Console.WriteLine($"Sumador 2 15+15: {s2.Sumar(15, 15)} Sumador 2 Hola + Mundo: {s2.Sumar("Hola ", "Mundo")}");

            //Sumar de cantidad de sumar
            Console.WriteLine($"Cant. de sumas de ambos: {s1+s2}");

            //Uso de operador pipe 
            Console.WriteLine($"Misma cantidad de sumas: {s1|s2}");

            //Conv. explicita de int
            Console.WriteLine((int)s2);

            Console.ReadKey();
        }
    }
}
