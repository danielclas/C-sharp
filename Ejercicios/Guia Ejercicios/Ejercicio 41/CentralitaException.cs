using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
      //b.En el operador + de Centralita, lanzar la excepción CentralitaExcepction en el caso de que la
      //llamada se encuentre registrada en el sistema.
      //c.Capturar dicha excepción tanto en la versión para Consola como en la de Formularios y
      //mostrar el mensaje de forma “amigable” al usuario.

    class CentralitaException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get;}
        public string NombreMetodo { get; }

        public CentralitaException(string mensaje, string clase, string metodo)
        {

        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
        {

        }
    }
}
