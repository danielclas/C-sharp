using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }
        public string this[int index]
        {
            get
            {
                string rtn = "";

                if (index >= 0 && index < paginas.Count)
                {
                    rtn = paginas[index];
                }

                return rtn;
            }

            set
            {
                if (index >= 0 && index < paginas.Count)
                {
                    paginas[index] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

        public void EscribirLibro(string libro)
        {
            List<string> lista = libro.Split(',', ' ', '.').ToList();

            int i = 0;

            foreach (string s in libro.Split(',', ' ', '.'))
            {
                this[i] = s;
                i++;
            }

        }

        public void LeerLibro()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (string s in paginas)
            {
                Console.Write($"{s} ");
            }
            Console.ResetColor();
        }

        public int Count()
        {
            return paginas.Count;
        }
    }
}
