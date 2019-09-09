using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            promedioGoles = (float)totalGoles / partidosJugados;

            return promedioGoles;
        }

        public string mostrarDatos()
        {
            string rtn="";

            rtn += ($"{dni}, {nombre}. Goles: {totalGoles} - Partidos: {partidosJugados} - Promedio: {promedioGoles}");

            return rtn;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool rtn = false;

            if (j1.dni == j2.dni)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }
       

    }
}
