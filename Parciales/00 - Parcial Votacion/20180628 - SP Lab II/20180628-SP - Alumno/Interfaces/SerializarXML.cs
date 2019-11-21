using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
  public class SerializarXML<T> : IArchivo<T>
  {
    public T Leer(string archivo)
    {
      T datos;

      try
      {
        XmlTextReader reader = new XmlTextReader(archivo);
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        datos = (T)serializer.Deserialize(reader);

        reader.Close();

      }
      catch (Exception e)
      {
        datos = default(T);
        throw new ErrorArchivoExcepcion(e);
      }

      return datos;
    }

    public bool Guardar(string rutaArchivo, T objeto)
    {
      bool rtnVal = true;

      try
      {
        XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        serializer.Serialize(writer, objeto);
        writer.Close();
      }
      catch (Exception e)
      {
        rtnVal = false;
        throw new ErrorArchivoExcepcion(e);
      }

      return rtnVal;
    }

  }
}
