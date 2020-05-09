using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        static Random random;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        public Profesor()
        {

        }

        /// <summary>
        /// Constructor estatico que inicializa el objeto Random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor que recibe 5 parametros
        /// </summary>
        /// <param name="id">ID del profesor</param>
        /// <param name="nombre">Nombre del profesor</param>
        /// <param name="apellido">Apellido del profesor</param>
        /// <param name="dni">DNI del profesor</param>
        /// <param name="nacionalidad">Nacionalidad del profesor</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Asigna dos clases aleatorias al profesor
        /// </summary>
        private void _randomClases()
        {
            int length = Enum.GetNames(typeof(Universidad.EClases)).Length;
            int random = Profesor.random.Next(1, length);

            this.clasesDelDia.Enqueue((Universidad.EClases)random);

            random = Profesor.random.Next(1, length);
            this.clasesDelDia.Enqueue((Universidad.EClases)random);
        }

        /// <summary>
        /// Expone los datos del objeto Profesor
        /// </summary>
        /// <returns>String con los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());

            datos.Append($"{this.ParticiparEnClase()}");

            return datos.ToString();

        }

        /// <summary>
        /// Expone las clases en las que participa el profesor
        /// </summary>
        /// <returns>String con las clases en las que participa el profesor</returns>
        protected override string ParticiparEnClase()
        {
            return $"\nClases del dia:\n{this.clasesDelDia.ElementAt(0)}\n{this.clasesDelDia.ElementAt(1)}";
        }

        /// <summary>
        /// Expone los datos del profesor llamando a MostrarDatos
        /// </summary>
        /// <returns>String con los datos del profesor</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Devuelve true si el profesor no dicta la clase recibida
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>True o False indicando si el profesor ya dicta esa clase</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        /// <summary>
        /// Devuelve true si el profesor dicta la clase recibida
        /// </summary>
        /// <param name="i">Profesor a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>True o False indicando si el profesor ya dicta esa clase</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }
        #endregion
    }
}
