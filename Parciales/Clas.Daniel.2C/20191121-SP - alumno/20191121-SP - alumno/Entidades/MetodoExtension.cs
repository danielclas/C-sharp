using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        /// <summary>
        /// Extiende el string y devuelve el estado de la rotacion
        /// </summary>
        /// <param name="str">Objeto tipo string que invoca el metodo</param>
        /// <param name="estado">Bool que indica si se encuentra orbitando o no</param>
        /// <returns>String segun el estado de la orbita</returns>
        public static string EstadoSimulacion(this string str, bool estado)
        {
            return estado ? "Orbitando" : "Detenido";
        }
    }
}
