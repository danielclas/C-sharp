using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        private bool numeroCargado;
        private int numeroTelefono;

        public int NumeroTelefono
        {
            get { return numeroTelefono; }
            set
            {
                if (value>=1500000000 && value<1599999999)
                {
                    numeroCargado = true;
                    numeroTelefono = value;
                }
            }
        }

        public EmisorDeWhatsapp(string mensaje, EProducto producto):base(mensaje, producto)
        {
            numeroCargado = false;
        }

        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            StringBuilder s = new StringBuilder(emisor.ToString());

            if (emisor.numeroCargado)
            {
                s.AppendLine($".{emisor.numeroTelefono}");
            }
            else
            {
                s.AppendLine($".No cargado");
            }

            return s.ToString();
        }

        public override string EnviarMensaje()
        {
            StringBuilder s = new StringBuilder(this.ToString());

            if (numeroCargado)
            {                
                s.AppendLine("\nEnviando mensaje");
            }
            else
            {
                s.AppendLine("\nNo se pudo enviar el mensaje");
            }

            return s.ToString();

        }
    }
}
