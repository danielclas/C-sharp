using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic.Comun
{
    public static class ArchivoTexto
    {
        public static bool Escribir(Excepciones.IArchivoTexto<Excepciones.ComiqueriaException> objeto, bool append)
        {
            bool escrito = false;
            string path = objeto.Ruta;

            try
            {
                if (append && File.Exists(path))
                {
                    File.AppendAllLines(path, new string[] { objeto.Texto }, Encoding.UTF8);
                }
                else
                {
                    File.WriteAllLines(path, new string[] { objeto.Texto }, Encoding.UTF8);                    
                }

                escrito = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return escrito;
        }

        public static string Leer(string ruta)
        {
            StringBuilder leer = new StringBuilder();
            string[] arr=null;

            try
            {
                if (File.Exists(ruta))
                {
                    arr = File.ReadAllLines(ruta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            if (!ReferenceEquals(null,arr))
            {
                foreach (string s in arr)
                {
                    leer.AppendLine(s);
                }
            }

            return leer.ToString();

        }


    }
}
