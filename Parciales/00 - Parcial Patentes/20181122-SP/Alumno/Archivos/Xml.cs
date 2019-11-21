using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            string path = Path.Combine("C:\\Users\\Dani\\Downloads\\20181122 - SP Lab II\\20181122-SP", archivo);

            try
            {
                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(writer, datos);
                writer.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Leer(string archivo, out T datos)
        {
            string path = Path.Combine("C:\\Users\\Dani\\Downloads\\20181122 - SP Lab II\\20181122-SP", archivo);
            T obj = default(T);

            try
            {
                XmlTextReader reader = new XmlTextReader(path);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                datos = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                datos = default(T);
                throw e;
            }

            datos = obj;
        }
    }
}
