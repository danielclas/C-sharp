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
        private int valorHora;

        public string ConsultarDatos()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string ImprimirTicket()
        {

        }

        private PickUp()
        {

        }

        public PickUp(string patente, string modelo)
        {

        }

        public PickUp(string patente, string modelo, int valorHora)
        {

        }


    }
}
