using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);

    public class Planeta
    {

        #region Atributos
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public event InformacionDeAvance InformarAvance;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor del objeto planeta
        /// </summary>
        /// <param name="velocidad">Velocidad del planeta</param>
        /// <param name="posicion">Posicion del planeta</param>
        /// <param name="radioRespectoSol">Radio respecto del sol del planeta</param>
        /// <param name="objetoVisual">Objeto visula del planeta</param>
        /// <returns>Objeto tipo Planeta</returns>
        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.VelocidadTraslacion = velocidad;
            this.PosicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.RadioRespectoSol = radioRespectoSol;
        }

        /// <summary>
        /// Constructor del ojeto planeta
        /// </summary>
        /// <returns>Objeto tipo Planeta</returns>
        public Planeta()
        {

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve o asigna la velocidad de traslacion
        /// </summary>
        public short VelocidadTraslacion { get { return this.velocidadTraslacion; } set { this.velocidadTraslacion = value; } }

        /// <summary>
        /// Propiedad que devuelve o asigna la posicion actual
        /// </summary>
        public short PosicionActual { get { return this.posicionActual; } set { this.posicionActual = value; } }

        /// <summary>
        /// Propiedad que devuelve o asigna el radio respecto del sol
        /// </summary>
        public short RadioRespectoSol { get { return this.radioRespectoSol; } set { this.radioRespectoSol = value; } }

        #endregion

        #region Metodos

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                PlanetaEventArgs args = new PlanetaEventArgs(this.Avanzar(), this.RadioRespectoSol);
                this.InformarAvance.Invoke(this, args);
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
            } while (true);
        }

        /// <summary>
        /// Guarda un planeta en XML, utilizado para unit test
        /// </summary>
        public void GuardarXML()
        {
            Xml<Planeta> xml = new Xml<Planeta>();

            xml.Guardar("Planeta.xml", this);
        }

        /// <summary>
        /// Lee un planeta de un archivo XML, utilizado para UnitTest
        /// </summary>
        /// <returns>Objeto Planeta segun lo leido del archivo</returns>
        public Planeta LeerXML()
        {
            Planeta planeta=null;
            Xml<Planeta> xml = new Xml<Planeta>();

            xml.Leer("Planeta.xml", out planeta);

            return planeta;
        }
        #endregion

    }
}
