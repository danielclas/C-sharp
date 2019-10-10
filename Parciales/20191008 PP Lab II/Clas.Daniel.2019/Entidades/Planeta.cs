using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        #region Atributos

        private int cantSatelites;
        private Tipo tipo;

        #endregion

        #region Propiedades

        public List<Astro> Satelites { get }

        #endregion

        #region Operadores

        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {

        }

        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            return ((string)planeta==(string)planeta);
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {

        }

        public static bool operator +(Planeta planeta, Satelite satelite)
        {

        }
        #endregion

        #region Metodos

        public static Orbitar()
        {

        }

        public override string Rotar()
        {
            return ($"Orbita el planeta: {(string)this}");
        }

        #endregion

        #region Constructores

        public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites, Tipo tipo)
        {

        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre)
        {

        }

        #endregion

    }
}
