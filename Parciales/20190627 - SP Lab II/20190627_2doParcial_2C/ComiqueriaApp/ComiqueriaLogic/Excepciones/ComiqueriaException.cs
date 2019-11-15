using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Excepciones
{
  public class ComiqueriaException:Exception, IArchivoTexto<Exception>
  {
    public string Ruta { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt"); } }
    public string Texto {
      get
      {
        Exception ex=this, inner;
        StringBuilder message = new StringBuilder(DateTime.Now.ToString());

        while(!(ex.InnerException is null))
        {
          inner = ex.InnerException;
          message.AppendLine(inner.Message);
          ex = inner;
        }

        return message.ToString();
      }
    }

    public ComiqueriaException(string message, Exception innerException):base(message, innerException)
    {

    }
  }
}
