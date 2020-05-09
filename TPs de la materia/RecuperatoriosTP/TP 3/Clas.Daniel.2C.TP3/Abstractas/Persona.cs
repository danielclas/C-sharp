using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Enum
        public enum ENacionalidad
        { Argentino, Extranjero }
        #endregion

        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido(value); }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.nacionalidad, value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidarNombreApellido(value); }
        }

        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.nacionalidad, value); }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor que  recibe tres parametros
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nacionalidad = nacionalidad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Constructor que recibe cuatro parametros
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor que recibe cuatro parametros
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Expone los datos de la persona
        /// </summary>
        /// <returns>Los datos del objeto Persona</returns>
        public override string ToString()
        {
            return $"Nombre completo: {this.Apellido}, {this.Nombre}. \nNacionalidad: {this.Nacionalidad}";
        }

        /// <summary>
        /// Valida el DNI recibido
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI a validar</param>
        /// <returns>DNI validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int dni;

            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                dni = dato;
            }
            else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                dni = dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }

            return dni;
        }

        /// <summary>
        /// Valida el DNI recibido
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI a validar</param>
        /// <returns>DNI validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni, dniValidado;

            if (int.TryParse(dato, out dni) && dni >= 1 && dni <= 99999999)
            {
                dniValidado = this.ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoException();
            }

            return dni;
        }

        /// <summary>
        /// Valida el nombre o apellido recibido
        /// </summary>
        /// <param name="dato">Cadena a validar</param>
        /// <returns>Dato validado</returns>
        private string ValidarNombreApellido(string dato)
        {
            bool esValido = Regex.IsMatch(dato, @"^[a-zA-z]+$");
            string nombre = "Nombre incorrecto";

            if (esValido)
            {
                nombre = dato;
            }

            return nombre;
        }
        #endregion

    }
}
