using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Camion : VehiculoT
    {
        private short marchas;
        private int carga;

        public Camion(short ruedas, short puertas, Program.Colores color, short marchas, int carga) : base(ruedas, puertas, color)
        {
            this.marchas = marchas;
            this.carga = carga;
        }

        public string MostrarDatos()
        {
            return ($"{base.Datos()} Marchas: {marchas} Carga: {carga}");
        }
    }
}
