using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        private List<Emisor> emisores;
        private string region;

        private ManejadorDeEmisores() { emisores = new List<Emisor>(); }

        public ManejadorDeEmisores(string region):this()
        {
            this.region = region;
        }

        public string EnviarMensajes()
        {
            //EnviarMensajes usa todos sus emisores para tratar de enviar los mensajes.Retorna las respuestas
            //de todos los mensajes junto con el nombre de la región.
            StringBuilder s = new StringBuilder();            foreach (Emisor e in emisores)
            {
                s.Append(e.EnviarMensaje());
            }            return s.ToString();
        }

        public override string ToString()
        {
            //ToString retorna el nombre de la región y la información de todos los emisores (usar StringBuilder).
            StringBuilder s = new StringBuilder();            s.Append($"Region {region}");            foreach (Emisor e in emisores)
            {
                s.Append(e.ToString());
                Console.WriteLine("HOLA");
            }            return s.ToString();
        }

        public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool rtn = false;

            foreach (Emisor e in manejador.emisores)
            {
                if (e==emisor)
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador==emisor);
        }

        public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool rtn = false;            if (manejador!=emisor)
            {
                manejador.emisores.Add(emisor);
                rtn = true;
            }            return rtn;
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool rtn = false;

            foreach (Emisor e in manejador.emisores)
            {
                if (e==emisor)
                {
                    manejador.emisores.Remove(e);
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }
    }
}
