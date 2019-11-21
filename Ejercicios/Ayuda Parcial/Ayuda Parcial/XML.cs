using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ayuda_Parcial
{
    public class XML<T> : IArchivo<T>
    {
        public T Leer(string path)
        {
            T datos;

            try
            {
                XmlTextReader reader = new XmlTextReader(path);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                datos = (T)serializer.Deserialize(reader);

                reader.Close();

            }
            catch (Exception)
            {
                datos = default(T);
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
            catch (Exception)
            {
                rtnVal = false;
            }

            return rtnVal;
        }
    }
}
