using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {

        }

        public Estacionamiento(string nombre, int espacioDisponible)
        {

        }

        public static explicit operator string(Estacionamiento e)
        {

        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {

        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {

        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {

        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {

        }


    }
}
