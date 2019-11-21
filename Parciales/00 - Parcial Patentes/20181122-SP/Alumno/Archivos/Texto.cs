using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            string path = Path.Combine("C:\\Users\\Dani\\Downloads\\20181122 - SP Lab II\\20181122-SP", archivo);
            StringBuilder texto = new StringBuilder();

            try
            {
                foreach (Patente patente in datos)
                {
                    texto.AppendLine(patente.ToString());
                }

                File.AppendAllLines(path, new string[] { texto.ToString() });
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            string path = Path.Combine("C:\\Users\\Dani\\Downloads\\20181122 - SP Lab II\\20181122-SP", archivo);
            Queue<Patente> queue=new Queue<Patente>();

            try
            {
                if (File.Exists(path))
                {
                    var arr = File.ReadAllLines(path);

                    foreach (string s in arr)
                    {
                        queue.Enqueue(s.ValidarPatente());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            datos = queue;
        }
    }
}
