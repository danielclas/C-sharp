using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool rtn = false;
            int i = 0;

            if (e.cantidadDeJugadores > e.jugadores.Count)
            {
                for (; i< e.jugadores.Count;i++)
                {
                    if (j == e.jugadores[i])
                    {
                        break;
                    }
                }

                if (i==e.jugadores.Count)
                {
                    e.jugadores.Add(j);
                    rtn = true;
                }
            }

            return rtn;
        }
    }
}
