using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza { get { return caballosDeFuerza; } set { caballosDeFuerza = value; } }

        public AutoF1(short numero, string escuderia):base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza):this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public string mostrarDatos()
        {
            return ($"\n{base.MostrarDatos()} Caballos: {CaballosDeFuerza}");  
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.caballosDeFuerza==a2.caballosDeFuerza;            
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
