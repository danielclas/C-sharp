using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos
{
    interface IFiles<T>
    {
        void Guardar(string nombreArchivo, T objeto);
        void Guardar(string nombreArchivo, T objeto, Encoding encoding);
        bool Leer(string nombreArchivo, out T objeto);
        bool Leer(string nombreArchivo, out T objeto, Encoding encoding);

    }
}
