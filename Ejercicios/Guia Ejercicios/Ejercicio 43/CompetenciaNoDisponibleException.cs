using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
  class CompetenciaNoDisponibleException:Exception
  {
    //a.La sobreescritura del método ToString retonará un mensaje con el siguiente formato por
    //líneas:
    //i. "Excepción en el método {0} de la clase {1}:"
    //ii.Mensaje propio de la excepción
    //iii.Todos los InnerException con una tabulación('\t').
    
    //c.Modificar el Main para agregar un Vehiculo que no corresponda con la competencia,
    //capturar la excepción y mostrar el error por pantalla.

    private string nombreClase;
    private string nombreMetodo;

    public string NombreClase { get { return this.nombreClase; } }
    public string NombreMetodo { get { return this.nombreMetodo; } }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo):base(mensaje)
    {

    }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje, innerException)
    {

    }

    public override string ToString()
    {
      StringBuilder str = new StringBuilder($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");

      str.AppendLine($"Mensje: {base.Message}");

      return str.ToString();
    }


  }
}
