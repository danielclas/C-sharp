using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_prueba
{
    public class Generica<Comodin, U> where U:Comodin, new()
    {
        public void Escribir()
        {
            Console.WriteLine(this.GetType());
        }
    }
}
