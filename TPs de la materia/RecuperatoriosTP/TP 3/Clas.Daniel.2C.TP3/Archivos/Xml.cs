using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public bool Guardar(string archivo, T dato)
    {
      bool rtnVal = true;

      try
      {
        XmlTextWriter writer = new XmlTextWriter(archivo, System.Text.Encoding.UTF8);
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        serializer.Serialize(writer, dato);
      }
      catch (Exception e)
      {
        rtnVal = false;
        throw new ArchivosException(e);
      }

      return rtnVal;
    }

    public bool Leer(string archivo, out T datos)
    {
      bool rtnVal = true;

      try
      {
        XmlTextReader reader = new XmlTextReader(archivo);
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        datos = (T)serializer.Deserialize(reader);

        reader.Close();

      }
      catch (Exception e)
      {
        rtnVal = false;
        datos = default(T);
        throw new ArchivosException(e);
      }

      return rtnVal;
    }
  }
}
