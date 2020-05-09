using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Lanza excepcion si hubo error en escritura/lectura de archivos
        /// </summary>
        /// <param name="innerException">Inner exception anterior</param>
        public ArchivosException(Exception innerException) : base("Excepcion", innerException)
        {

        }
    }
}
