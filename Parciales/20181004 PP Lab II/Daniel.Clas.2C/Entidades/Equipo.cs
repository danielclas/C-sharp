using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico { get; set; }
        public string Nombre { get; }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : base()
        {
            this.nombre = nombre;
        }

        public bool ValidarEquipo(Equipo e)
        {

        }

        public static explicit operator string(Equipo e)
        {

        }

        public static bool operator ==(Equipo e, Jugador j)
        {

        }

        public static bool operator !=(Equipo e, Jugador j)
        {

        }

        public static bool operator +(Equipo e, Jugador j)
        {

        }


    }
}
