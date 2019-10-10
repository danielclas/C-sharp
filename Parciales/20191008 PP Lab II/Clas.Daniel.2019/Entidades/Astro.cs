using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        #region Atributos

        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        #endregion

        #region Constructor

        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        #endregion

        #region Metodos

        protected string Mostrar()
        {
            return ($"Nombre: {this.nombre} - Orbita: {this.duracionOrbita} - Rotacion: {this.duracionRotacion}");
        }

        public abstract string Orbitar();      

        public virtual string Rotar()
        {
            return ($"Rotando. Tiempo estimado: {this.duracionRotacion}");
        }

        #endregion

        #region Operadores

        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
        }

        #endregion
    }
}
