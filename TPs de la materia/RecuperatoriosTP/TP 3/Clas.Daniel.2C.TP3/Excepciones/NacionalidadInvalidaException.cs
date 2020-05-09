using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion sin parametros
        /// </summary>
        public NacionalidadInvalidaException() : base("La nacionalidad no se condice con el numero de DNI")
        {

        }

        /// <summary>
        /// Constructor de la excepcion que recibe un mensaje
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepcion</param>
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {

        }

    }
}
