using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        public Universitario() : base()
        {

        }

        /// <summary>
        /// Constructor que reibe 5 parametros
        /// </summary>
        /// <param name="legajo">Legajo del universitario</param>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve true si el ambos objetos son iguales
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>True or False indicando si son iguales o no</returns>
        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj.GetType() == typeof(Universitario))
            {
                equals = this == (Universitario)obj;
            }

            return equals;
        }

        /// <summary>
        /// Expone los datos del objeto Universitario
        /// </summary>
        /// <returns>String con los datos del objeto</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.ToString());

            datos.Append($"\nLegajo: {this.legajo}");

            return datos.ToString();
        }

        /// <summary>
        /// Metodo abstracto ParticiparEnClase
        /// </summary>
        /// <returns>String</returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Operadores

        /// <summary>
        /// Recibe dos objetos Universitario y los compara
        /// </summary>
        /// <param name="pg1">Objeto tipo universitario</param>
        /// <param name="pg2">Objeto tipo universitario</param>
        /// <returns>True o False indicando si son iguales o no</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool mismoTipo = pg1.GetType() == pg2.GetType();

            return mismoTipo && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
        }

        /// <summary>
        /// Recibe dos objetos Universitario y los compara
        /// </summary>
        /// <param name="pg1">Objeto tipo universitario</param>
        /// <param name="pg2">Objeto tipo universitario</param>
        /// <returns>True o False indicando si son iguales o no</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
