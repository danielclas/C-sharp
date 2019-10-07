using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {   
        protected DateTime ingreso;
        private string patente;

        public string Patente { get{ return this.patente; } set { if (value.Length == 6) this.patente = value; } }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder str = new StringBuilder(this.ToString());

            str.AppendLine($"Ingreso: {this.ingreso}");

            return str.ToString();

        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Equals(v2));
        }

        public override string ToString()
        {
            return String.Format($"Patente: {this.Patente}");
        }

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
    }
}
