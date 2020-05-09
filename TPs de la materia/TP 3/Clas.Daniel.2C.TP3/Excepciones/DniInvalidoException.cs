using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Atributos
        private static string mensajeBase = "DNI Invalido";
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de excepcion sin parametros
        /// </summary>
        public DniInvalidoException() : base(mensajeBase)
        {

        }

        /// <summary>
        /// Constructor de excepcion que recibe una excepcion
        /// </summary>
        /// <param name="e">Excepcion anterior</param>
        public DniInvalidoException(Exception e) : this(mensajeBase, e)
        {

        }

        /// <summary>
        /// Constructor de excepcion que recibe un mensaje
        /// </summary>
        /// <param name="message">Mensaje de la excepcion</param>
        public DniInvalidoException(string message) : base(message)
        {

        }

        /// <summary>
        /// Constructor de excepcion que recibe un mensaje y una excepcion
        /// </summary>
        /// <param name="message">Mensaje de la excepcion</param>
        /// <param name="e">Excepcion anterior</param>
        public DniInvalidoException(string message, Exception e) : base(message, e)
        {

        }
        #endregion
    }
}
