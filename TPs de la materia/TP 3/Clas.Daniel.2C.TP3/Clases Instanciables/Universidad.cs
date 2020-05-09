using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Enum
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
        #endregion

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }
            set
            {
                this.jornadas[i] = value;
            }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que no recibe parametros e inicializa listas
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Guarda en archivo los datos de la universidad recibida
        /// </summary>
        /// <param name="uni">Universidad a guardar en archivo</param>
        /// <returns>True o False indicando si pudo guarda en archivo</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> cargar = new Xml<Universidad>();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";
            bool rtnVal;

            try
            {
                rtnVal = cargar.Guardar(archivo, uni);
            }
            catch (Excepciones.ArchivosException)
            {
                rtnVal = false;
            }

            return rtnVal;
        }

        /// <summary>
        /// Lee desde un archivo un objeto de tipo Universidad
        /// </summary>
        public Universidad Leer()
        {
            Xml<Universidad> reader = new Xml<Universidad>();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";
            Universidad uni = this;

            try
            {
                reader.Leer(archivo, out uni);
            }
            catch (Excepciones.ArchivosException)
            {
                uni = null;
            }

            return uni;
        }

        /// <summary>
        /// Muestra los datos de la universidad
        /// </summary>
        /// <param name="uni">Universidad a mostrar</param>
        /// <returns>String con los datos de la universidad</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Jornada: \n");

            foreach (Jornada j in uni.jornadas)
            {
                datos.AppendLine($"{j.ToString()}\n");
            }

            return datos.ToString();
        }

        /// <summary>
        /// Muestra los datos de la universidad
        /// </summary>
        /// <returns>String con los datos de la universidad</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Compara una universidad con un alumno
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>True o False si el alumno esta incluido en la universida o no</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Compara una universidad con un profesor
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="i">Profesor a comparar</param>
        /// <returns>True o False si el profesor esta incluido en la universida o no</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Compara una universidad con una clase
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>El primer profesor de la universidad que no brinde esa clase</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor profesor = null;

            foreach (Profesor p in g.Instructores)
            {
                if (p != clase)
                {
                    profesor = p;
                    break;
                }
            }

            return profesor;
        }

        /// <summary>
        /// Compara una universidad con un alumno
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>True o False si el alumno esta incluido en la universida o no</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool contains = false;

            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        /// <summary>
        /// Compara una universidad con un profesor
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="i">Profesor a comparar</param>
        /// <returns>True o False si el profesor esta incluido en la universida o no</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            return g.Instructores.Contains(i);
        }

        /// <summary>
        /// Compara una universidad con una clase
        /// </summary>
        /// <param name="g">Universidad a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>El primer profesor de la universidad que brinde esa clase</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor profesor = null;

            foreach (Profesor p in g.Instructores)
            {
                if (p == clase)
                {
                    profesor = p;
                    break;
                }
            }

            if (ReferenceEquals(profesor, null))
            {
                throw new SinProfesorException();
            }

            return profesor;
        }

        /// <summary>
        /// Agrega la clase recibida a la universidad si esta no esta incluida
        /// </summary>
        /// <param name="g">Universidad donde se agregara la clase</param>
        /// <param name="clase">Clase a agregar</param>
        /// <returns>La universidad con la clase agregada si fue posible la operacion</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, g == clase);

            foreach (Alumno a in g.Alumnos)
            {
                if (a == clase)
                {
                    jornada.Alumnos.Add(a);
                }
            }

            g.Jornadas.Add(jornada);

            return g;
        }

        /// <summary>
        /// Agrega el alumno recibido a la universidad si esta no esta incluido
        /// </summary>
        /// <param name="g">Universidad donde se agregara la clase</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>La universidad con el alumno agregada si fue posible la operacion</returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        /// <summary>
        /// Agrega el profesor recibido a la universidad si esta no esta incluida
        /// </summary>
        /// <param name="g">Universidad donde se agregara la clase</param>
        /// <param name="i">Profesor a agregar</param>
        /// <returns>La universidad con el profesor agregado si fue posible la operacion</returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.Instructores.Add(i);
            }

            return g;
        }
        #endregion

    }
}
