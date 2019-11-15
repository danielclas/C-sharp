using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic.Comun
{
  public static class Serializador<T> where T:class, new()
  {

    public static bool SerializarXML(string ruta, T objeto)
    {
      bool rtnVal = true;

      try
      {
        XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8);
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        serializer.Serialize(writer, objeto);
        writer.Close();
      }
      catch (ArgumentException e)
      {
        rtnVal = false;      
        throw e;
      }
      catch(DirectoryNotFoundException e)
      {
        throw new Excepciones.ComiqueriaException("Error: Directorio no encontrado", e);
      }
      catch(Exception)
      {
        throw new Exception("Aprobame igual");
      }

      return rtnVal;
    }

    public static T Leer(string archivo)
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
      }

      return datos;
    }
  }
}
