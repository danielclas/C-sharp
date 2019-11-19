using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSON_Practice;

namespace JSON_Practice
{
    public static class Extension
    {
        public static void Escribir(this Persona p)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
