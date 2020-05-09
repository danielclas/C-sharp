using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        /// <summary>
        /// Constructor que inicializa las listas
        /// </summary>
        public Correo()
        {
            this.Paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        /// <summary>
        /// Termina las entregas
        /// </summary>
        public void FinEntregas()
        {
            this.mockPaquetes.ForEach(t => t.Abort());
        }

        /// <summary>
        /// Muestra los datos del correo
        /// </summary>
        /// <param name="elementos">Correo</param>
        /// <returns>String con la informacion del correo</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder text = new StringBuilder();
            Correo correo = (Correo)elementos;

            foreach (Paquete p in correo.Paquetes)
            {
                text.AppendLine(String.Format($"{p.TrackingID} para {p.DireccionEntrega} ({p.Estado.ToString()})"));
            }

            return text.ToString();
        }

        /// <summary>
        /// Agrega un paquete a un correo
        /// </summary>
        /// <param name="c">Correo</param>
        /// <param name="p">Paquete</param>
        /// <returns>El correo con el paquete agregado</returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            bool contains = false;

            foreach (Paquete p2 in c.Paquetes)
            {
                if (p2 == p)
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                throw new TrackingIDRepetidoException("Ya existe un paquete con ese tracking ID");
            }
            else
            {
                c.Paquetes.Add(p);
            }

            c.mockPaquetes.Add(new Thread(p.MockCicloDeVida));
            c.mockPaquetes.Last().Start();

            return c;
        }


    }
}
