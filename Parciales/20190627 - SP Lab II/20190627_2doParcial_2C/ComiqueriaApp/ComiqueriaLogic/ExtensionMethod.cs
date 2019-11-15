using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public static class ExtensionMethod
  {    
    //a.Utilice FormatearPrecio en el método ObtenerDescripcionBreve de la clase Venta para
    //que se devuelva el precio final formateado

    public static string FormatearPrecio(this double num)
    {
      return String.Format("${0:0.00}", num);
    }
  }
}
