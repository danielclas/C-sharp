using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
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

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que recibe dos parametros
        /// </summary>
        /// <param name="clase">Clase de la jornada</param>
        /// <param name="instructor">Instructor de la jornada</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Guarda en un archivo la jornada recibida
        /// </summary>
        /// <returns>Booleano indicando si pudo o no guardar en archivo</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto guardar = new Texto();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";
            bool rtnVal;

            try
            {
                rtnVal = guardar.Guardar(archivo, jornada.ToString());
            }
            catch (Excepciones.ArchivosException)
            {
                rtnVal = false;
            }

            return rtnVal;
        }

        /// <summary>
        /// Lee de un archivo un objeto de tipo Jornada
        /// </summary>
        /// <returns>String con la informacion leida</returns>
        public static string Leer()
        {
            Texto reader = new Texto();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";
            string datos = "";

            try
            {
               reader.Leer(archivo, out datos);
            }
            catch (Excepciones.ArchivosException)
            {
                datos = "No pudo leerse";
            }

            return datos;
        }

        /// <summary>
        /// Expone la informacion del objeto tipo Jornada
        /// </summary>
        /// <returns>String con los datos de la jornada</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder($"Clase de {this.clase} Por {this.instructor.ToString()}\n\nAlumnos:\n");

            foreach (Alumno a in this.alumnos)
            {
                datos.AppendLine($"{a.ToString()}\n");
            }

            datos.AppendLine("< ----------------------------------------------------------->");

            return datos.ToString();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Compara una jornada con un alumno
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>True o False indicando si el alumno esta contenido en la jornada</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Compara una jornada con un alumno
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">Alumno a comparar</param>
        /// <returns>True o False indicando si el alumno esta contenido en la jornada</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool contains = false;

            foreach (Alumno alumno in j.Alumnos)
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
        /// Agrega un alumno a una jornada
        /// </summary>
        /// <param name="j">Jornada</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>La jornada recibida mas el alumno recibido</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
        }
        #endregion
    }
}
