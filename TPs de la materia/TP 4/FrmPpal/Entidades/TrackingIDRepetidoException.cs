using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIDRepetidoException:Exception
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        public TrackingIDRepetidoException(string mensaje):base(mensaje)
        {

        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        /// <param name="inner">Inner exception a ser guardada</param>
        public TrackingIDRepetidoException(string mensaje, Exception inner):base(mensaje, inner)
        {

        }
    }
}
