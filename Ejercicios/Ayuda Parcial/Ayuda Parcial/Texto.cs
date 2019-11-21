using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ayuda_Parcial
{
    public class Texto<T>
    {
        public bool Guardar(string path, T objeto)
        {
            bool rtnVal = true;

            try
            {
                if (!File.Exists(path))
                {
                    string texto = objeto.ToString();
                    File.AppendAllLines(path, new string[] { texto });
                }
            }
            catch (Exception)
            {
                rtnVal = false;
            }

            return rtnVal;
        }
    }
}
