using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Enum
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Constructor que recibe 6 parametors
        /// </summary>
        /// <param name="id">ID del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="clasesQueToma">Clases que toma el alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma) : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma, EEstadoCuenta.Deudor)
        {

        }

        /// <summary>
        /// Constructor que recibe 7 parametors
        /// </summary>
        /// <param name="id">ID del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="clasesQueToma">Clases que toma el alumno</param>
        /// <param name="estadoCuenta">Estado de cuenta del alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCuenta) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.estadoCuenta = estadoCuenta;
            this.claseQueToma = clasesQueToma;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Expone los datos del objeto Alumno
        /// </summary>
        /// <returns>String con los datos del objeto</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());

            datos.Append($"\nCuenta: {this.estadoCuenta}\nClase: {this.claseQueToma}");

            return datos.ToString();
        }

        /// <summary>
        /// Expone las clases tomadas por el alumno
        /// </summary>
        /// <returns>String con las clases que el alumno toma</returns>
        protected override string ParticiparEnClase()
        {
            return $"Toma clase de: {this.claseQueToma}";
        }

        /// <summary>
        /// Expone los datos del objeto Alumno
        /// </summary>
        /// <returns>String con los datos del alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Compara un alumno con una clase y devuelve False si este la toma
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>True o False indicando si son iguales</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }

        /// <summary>
        /// Compara un alumno con una clase y devuelve True si este la toma
        /// </summary>
        /// <param name="a">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>True o False indicando si son iguales</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma==clase && a.estadoCuenta!=EEstadoCuenta.Deudor;
        }
        #endregion
    }
}
