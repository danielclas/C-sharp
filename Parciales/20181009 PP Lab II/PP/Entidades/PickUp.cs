using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
    public class PickUp:Vehiculo
    {
        private string modelo;
        private static int valorHora;

        public override string ConsultarDatos()
        {
            return ($"{base.ToString()} Modelo: {this.modelo} ${PickUp.valorHora}/hora");
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj is PickUp)
            {
                equals = ((PickUp)obj).Patente == this.Patente;
            }
            return equals;
        }

        public override string ImprimirTicket()
        {
            double hours = (DateTime.Now - base.ingreso).Hours;

            hours *= PickUp.valorHora;

            return ($"{base.ImprimirTicket()} Costo: ${hours}");
        }

        static PickUp()
        {
            PickUp.valorHora = 70;
        }

        public PickUp(string patente, string modelo):base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora):this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }


    }
}
