using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Extension;
namespace Try_catch_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Generica<Clase1, Clase2> generica = new Generica<Clase1, Clase2>();
            generica.Escribir();

            Clase2 clase2 = new Clase2();
            Clase1 clase1 = new Clase1();
            string s = "Algo";
            s.Escribir();
            

            try
            {
                StreamWriter writer = new StreamWriter("H:\\");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.GetType());
                try
                {
                    StreamWriter writer = new StreamWriter("Z:\\");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.GetType());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
