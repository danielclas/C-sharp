using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        public DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico { set { if (value.ValidarAptitud()) directorTecnico = value; } }
        public string Nombre { get { return nombre; } }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            int[] arr = new int[4];
            bool rtn = false;

            if(!ReferenceEquals(e.directorTecnico, null))
            {
                foreach (Jugador j in e.jugadores)
                {
                    switch (j.Posicion)
                    {
                        case Posicion.Arquero:
                            arr[0]++;
                            break;
                        case Posicion.Defensor:
                            arr[1]++;
                            break;
                        case Posicion.Central:
                            arr[2]++;
                            break;
                        case Posicion.Delantero:
                            arr[3]++;
                            break;
                        default:
                            break;
                    }
                }

                if (e.jugadores.Count == Equipo.cantidadMaximaJugadores)
                {
                    if (arr[0] == 1)
                    {
                        rtn = true;
                        for (int i = 1; i < arr.Length; i++)
                        {
                            if (arr[i] == 0)
                            {
                                rtn = false;
                                break;
                            }
                        }
                    }
                }
            }            

            return rtn;

            
        }

        public static explicit operator string(Equipo e)
        {
            string DT;
            StringBuilder str = new StringBuilder();

            if (ReferenceEquals(e.directorTecnico, null))
            {
                DT = "Sin DT asignado";
            }
            else
            {
                DT = e.directorTecnico.Mostrar();
            }

            e.jugadores.ForEach(k => str.AppendLine(k.Mostrar()));
            str.AppendLine(DT);

            return str.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.jugadores.Contains(j);
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }

            return e;
        }



        


    }
}
