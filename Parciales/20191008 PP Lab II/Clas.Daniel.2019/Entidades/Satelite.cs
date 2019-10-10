using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        #region Propiedades

        public string Nombre {
            get {
                return (string)this;
            }
        }

        #endregion

        #region Constructor

        public Satelite(int duraOrbita, int duraRotacion, string nombre):base(duraOrbita, duraRotacion, nombre)
        {

        }

        #endregion

        #region Metodos

        public override string Orbitar()
        {
            return ($"Orbitar el satelite: {this.Nombre}");
        }

        public override string ToString()
        {
            return base.Mostrar();
        }

        #endregion

    }
}
