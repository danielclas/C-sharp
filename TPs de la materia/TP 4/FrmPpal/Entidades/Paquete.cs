using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega { get { return this.direccionEntrega; } set { this.direccionEntrega = value; } }
        public EEstado Estado { get { return this.estado; } set { this.estado = value; } }
        public string TrackingID { get { return this.trackingID; } set { this.trackingID = value; } }

        /// <summary>
        /// Simula el envio de un paquete
        /// </summary>
        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.Estado = this.Estado + 1;
                InformaEstado.Invoke(this, null);
            }

            PaqueteDAO.Insertar(this);
        }

        /// <summary>
        /// Expone la informacion del objeto
        /// </summary>
        /// <param name="elemento">Elemento a mostrar</param>
        /// <returns>Informacion del paquete</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;

            return String.Format($"{p.trackingID} para {p.direccionEntrega}");
        }

        /// <summary>
        /// Constructor del objeto patente
        /// </summary>
        /// <param name="direccionEntrega">Direccion de entrega del paquete</param>
        /// <param name="trackingID">Tracking ID del paquete</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        /// <summary>
        /// Convierte a string el objeto
        /// </summary>
        /// <returns>Informacion del paquete</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Compara dos pauqetes
        /// </summary>
        /// <param name="p1">Paquete 1</param>
        /// <param name="p2">Paquete 2</param>
        /// <returns>True si son distintos, false si no lo son</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Compara dos pauqetes
        /// </summary>
        /// <param name="p1">Paquete 1</param>
        /// <param name="p2">Paquete 2</param>
        /// <returns>True si son iguales, false si no lo son</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1.TrackingID == p2.TrackingID;
        }
    }
}
