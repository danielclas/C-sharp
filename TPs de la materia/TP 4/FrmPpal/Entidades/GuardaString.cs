using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Extiende string y retorna un path
        /// </summary>
        /// <param name="texto">Objeto que invoca al metodo</param>
        /// <param name="archivo">Nombre del archivo</param>
        /// <returns>True si pudo guardar, false si no pudo</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
            bool rtn = false;

            try
            {                
               File.AppendAllLines(path, new string[] { texto });                            
               rtn = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return rtn;
        }
    }
}
