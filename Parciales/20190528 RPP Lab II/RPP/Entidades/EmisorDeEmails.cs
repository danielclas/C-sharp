using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeEmails : Emisor
    {
        private string email;
        private bool enviado;

        public EmisorDeEmails(string mensaje, EProducto producto, string email) : base(mensaje, producto)
        {
            this.email = email;
            this.enviado = false;
        }

        public override string EnviarMensaje()
        {
            StringBuilder s = new StringBuilder((string)this);

            if (enviado)
            {
                s.AppendLine("\nError, el mensaje ya fue enviado");
            }
            else
            {
                s.AppendLine("\nSe envia el mensaje");
                enviado = true;
            }

            return s.ToString();
        }

        public static explicit operator string(EmisorDeEmails emisor)
        {
            return ($"Email: {emisor.email} Enviado: {emisor.enviado} {emisor.ToString()}");
        }
    }
}
