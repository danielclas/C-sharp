using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        public short CantidadCombustible { get; set; }
        public bool EnCompetencia { get; set; }
        public string Escuderia { get; set; }
        public short Numero { get; set; }
        public short VueltasRestantes { get; set; }

        public string MostrarDatos()
        {

        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {

        }

        
    }
}
