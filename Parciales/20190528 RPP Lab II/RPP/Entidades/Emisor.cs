using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        protected string mensaje;
        protected EProducto producto;

        protected Emisor(string mensaje, EProducto producto)
        {
            this.mensaje = mensaje;
            this.producto = producto;
        }

        public abstract string EnviarMensaje();       

        public override string ToString()
        {
            return ($"\n. {producto} \n. {mensaje}");
        }

        public static bool operator ==(Emisor emisor, Emisor emisorDos)
        {
            return emisor.mensaje == emisorDos.mensaje && emisor.producto == emisorDos.producto ? true : false;
        }

        public static bool operator !=(Emisor emisor, Emisor emisorDos)
        {
            return !(emisor == emisorDos);
        }

        public enum EProducto
        {
            SQLDatabase,
            MonitoringApp,
            AppHosting
        }

    }

    
}
