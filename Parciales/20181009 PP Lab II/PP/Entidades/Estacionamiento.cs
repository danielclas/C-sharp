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
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder str = new StringBuilder($"Nombre: {e.nombre} Espacio disponible: {e.espacioDisponible}");

            e.vehiculos.ForEach(k => str.AppendLine(k.ConsultarDatos()));

            return str.ToString();
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return estacionamiento.vehiculos.Contains(vehiculo);
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string str = "El vehiculo no es parte del estacionamiento";

            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                str = vehiculo.ImprimirTicket();
            }

            return str;
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento!=vehiculo && estacionamiento.vehiculos.Count< estacionamiento.espacioDisponible)
            {
                if (vehiculo.Patente!="")
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }

            return estacionamiento;
        }


    }
}
