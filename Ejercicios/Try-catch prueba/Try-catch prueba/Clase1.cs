using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_prueba
{

    public class Clase1 : Interface1<int>
    {
        private delegate void HacerAlgo();

        private event HacerAlgo evento;
        void Interface1<int>.Mostrar()
        {
            Console.WriteLine("Mostrar 1");
        }
        
        
        public void MostrarClase()
        {
          
        }


        public string nombre;

        public Clase1()
        {

        }
        public Clase1(string nombre)
        {
            this.nombre = nombre;
        }

        public static void Metodo(this string texto)
        {
            Console.WriteLine(texto);
        }
    }

    public class Clase2 : Clase1
    {
        public Clase2()
        {
            evento += Mostrar3;
            evento += Mostrar4;
            evento2 += Mostrar3;
        }
        public void Mostrar3()
        {

        }

        public void Mostrar4() { }
    }
}
