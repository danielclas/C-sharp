using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 28";

            //Utilizar Diccionarios (Dictionary<string, int>)para realizar un contador de palabras, recorriendo el
            //texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
            //diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
            //Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
            //Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.

            Dictionary<string, int> dic = new Dictionary<string, int>();

            
        }
    }

    public static class Texto
    {
        public static string texto = "";
        private static string[] array = new string[1];

        public static void CapturarTexto(string texto)
        {
            Texto.texto = texto;
            array = Texto.texto.Split(' ');
        }


    }
}
