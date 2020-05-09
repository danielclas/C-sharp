using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
  public class Texto : IArchivo<string>
  {
    public bool Guardar(string archivo, string datos)
    {
      bool rtnVal = true;

      try
      {
        StreamWriter writer = new StreamWriter(archivo, true);
        writer.WriteLine(datos);
        writer.Close();
      }
      catch (Exception e)
      {
        rtnVal = false;
        throw new ArchivosException(e);
      }

      return rtnVal;

    }

    public bool Leer(string archivo, out string datos)
    {
      bool rtnVal = true;
      StringBuilder lineas = new StringBuilder();

      try
      {
        StreamReader reader = new StreamReader(archivo);

        while (!reader.EndOfStream)
        {
          lineas.AppendLine(reader.ReadLine());
        }

        reader.Close();
      }
      catch (Exception e)
      {
        rtnVal = false;
        throw new ArchivosException(e);
      }

      datos = lineas.ToString();

      return rtnVal;
    }
  }
}
