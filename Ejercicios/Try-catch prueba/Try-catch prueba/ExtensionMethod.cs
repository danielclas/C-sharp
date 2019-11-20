using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class ExtensionMethod
    {
        public static void Escribir(this string s)
        {
            Console.WriteLine(s);
        }
    }
}
