using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class VehiculoT
    {
        private short ruedas;
        private short puertas;
        private Program.Colores color;

        public VehiculoT(short ruedas, short puertas, Program.Colores color)
        {
            this.ruedas = ruedas;
            this.puertas = puertas;
            this.color = color;
        }

        
        protected string Datos()
        {
            return ($"Ruedas: {ruedas} Puertas: {puertas} Color: {color} ");
        }
        
    }
}
