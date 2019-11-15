using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Excepciones
{
  interface IArchivoTexto<T>
  {
    string Ruta { get; }
    string Texto { get; }
  }
}
