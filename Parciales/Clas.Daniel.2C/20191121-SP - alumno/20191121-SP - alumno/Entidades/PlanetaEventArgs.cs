using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs:EventArgs
    {
        #region Atributos
        private short avance;
        private short radioRespectoSol;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el avance del planetaEventArgs
        /// </summary>
        public short Avance { get { return this.avance; } }

        /// <summary>
        /// Propiedad que devuelve el radio respecto del sol
        /// </summary>
        public short RadioRespectoSol { get { return this.radioRespectoSol; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de PlanetaEventArgs
        /// </summary>
        /// <param name="avance">Avance del planeta</param>
        /// <param name="radio">Radio del planeta</param>
        /// <returns>Objeto tipo PlanetaEventArgs</returns>
        public PlanetaEventArgs(short avance, short radio)
        {
            this.avance = avance;
            this.radioRespectoSol = radio;
        }
        #endregion



    }
}
