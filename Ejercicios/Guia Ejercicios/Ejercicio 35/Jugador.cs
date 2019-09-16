using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados { get { return partidosJugados; } set { partidosJugados = value; } }
        public float PromedioGoles { get { return (float)TotalGoles / PartidosJugados; } set { } }
        public int TotalGoles { get { return totalGoles; } set { totalGoles = value; } }

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            TotalGoles = totalGoles;
            PartidosJugados = totalPartidos;
        }

        public new string MostrarDatos()
        {
            return ($"{base.MostrarDatos()}- Goles: {TotalGoles} - Partidos: {PartidosJugados} - Promedio: {PromedioGoles}");
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni ? true : false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
