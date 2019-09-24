using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
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
