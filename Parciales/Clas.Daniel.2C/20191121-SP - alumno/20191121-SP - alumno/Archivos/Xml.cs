using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T>:IFiles<T>
    {
        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el path del escritorio
        /// </summary>
        /// <returns>El path del escritorio</returns>
        public string GetDirectoryPath { get{ return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; } }
        #endregion

        #region Metodos
        /// <summary>
        /// Corrobora si el archivo existe
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo a evaluar</param>
        /// <returns>True or False segun exista el archivo o no</returns>
        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(this.GetDirectoryPath+nombreArchivo);
        }

        /// <summary>
        /// Guarda el objeto recibido con el nombre recibido
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo a guardar</param>
        /// <param name="objeto">Objeto a guardar</param>
        public void Guardar(string nombreArchivo, T objeto)
        {
            this.Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        /// <summary>
        /// Guarda el objeto recibido con el nombre recibido
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo a guardar</param>
        /// <param name="objeto">Objeto a guardar</param>
        /// <param name="encoding">Codificacion de caracteres en la cual guardar</param>
        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer = new XmlTextWriter(this.GetDirectoryPath + nombreArchivo, Encoding.UTF8);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("No pudo guardarse en XML", e);
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Lee un objeto de un archivo XML
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo a leer</param>
        /// <param name="objeto">Referencia donde se guardara lo leido</param>
        /// <returns>True or False pudo leer el objeto</returns>
        public bool Leer(string nombreArchivo, out T objeto)
        {
            return this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        /// <summary>
        /// Lee un objeto de un archivo XML
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo a leer</param>
        /// <param name="objeto">Referencia donde se guardara lo leido</param>
        /// <param name="encoding">Codificacion de caracteres en la cual leer, no se usa</param>
        /// <returns>True or False pudo leer el objeto</returns>
        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            XmlTextReader reader = new XmlTextReader(this.GetDirectoryPath+nombreArchivo);
            bool objetoLeido = true;

            try
            {                
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                objeto = default(T);
                objetoLeido = false;
                throw new ErrorArchivosException("No pudo leerse de XML", e);
            }
            finally
            {
                reader.Close();
            }

            return objetoLeido;
        }
        #endregion
    }
}
