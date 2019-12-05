using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException:Exception
    {
        #region Constructores
        /// <summary>
        /// Constructor de la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        /// <param name="e">InnerException capturada</param>
        /// <returns>Objeto ErrorArchivosException</returns>
        public ErrorArchivosException(string mensaje, Exception e) : base(mensaje, e)
        {

        }

        /// <summary>
        /// Constructor de la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        /// <returns>Objeto ErrorArchivosException</returns>
        public ErrorArchivosException(string mensaje) : base(mensaje)
        {

        }
        #endregion

    }
}
