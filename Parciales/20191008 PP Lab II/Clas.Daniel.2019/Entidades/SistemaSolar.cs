using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        //22. MostrarInformacionAstros(): método que retorna toda la información de los planetas, y sus satélites.
        #region Atributos

        List<Astro> planetas;

        #endregion

        #region Propiedades

        public List<Astro> Planetas { get; }

        #endregion

        #region Constructor

        private SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }

        #endregion

        #region Metodos

        public string MostrarInformacionAstros()
        {

        }

        #endregion

    }
}
