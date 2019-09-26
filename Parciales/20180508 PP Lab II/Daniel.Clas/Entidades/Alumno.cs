using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Alumno:Persona
  {
    private short anio;
    private Divisiones division;

    public string AnioDivision { get { return ($"{this.anio}º{division.ToString()}"); } }

    public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre,apellido,documento)
    {
      this.anio = anio;
      this.division = division;
    }

    public override string ExponerDatos()
    {
      StringBuilder str = new StringBuilder(base.ExponerDatos());

      str.Append($" Año: {this.AnioDivision}");

      return str.ToString();
    }

    protected override bool ValidarDocumentacion(string doc)
    {
      bool rtn = false;
      string[] str;

      if (doc.Contains('-'))
      {
          str = doc.Split('-');     

          if (str.Length==3 && str[0].Length == 2 && str[1].Length == 4 && str[2].Length == 1)
          {
            rtn = true;
            for (int i = 0; i < str.Length; i++)
            {
              for (int j = 0; j < str[i].Length; j++)
              {
                if (!char.IsNumber((str[i])[j]))
                {
                  rtn = false;
                  break;
                }
              }
            }
          }
      }

      return rtn;
    }
  }

 
}
