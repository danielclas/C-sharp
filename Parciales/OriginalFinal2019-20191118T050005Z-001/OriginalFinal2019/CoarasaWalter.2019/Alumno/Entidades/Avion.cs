using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate int ReporteDeEstado(int horasTotales, int horasRestantes);

    public enum EstadoVuelo
    {
        Programado,
        Volando,
        Atrerrizado
    }
    public class Avion : IAvion
    {
        private int horasVuelo;
        private Thread vuelo;
        public event ReporteDeEstado ReportarEstado;

        public Thread Vuelo
        { get {return this.vuelo; }
          set {this.vuelo = value; }
        }
        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        public EstadoVuelo Estado
        {
            get
            {
                EstadoVuelo estado;

                if (ReferenceEquals(this.vuelo, null))
                {
                    estado = EstadoVuelo.Programado;
                }
                else if (this.vuelo.IsAlive)
                {
                    estado = EstadoVuelo.Volando;
                }
                else
                {
                    estado = EstadoVuelo.Atrerrizado;
                }

                return estado;
            }
        }

        public int HorasDeVuelo
        {
            get { return this.horasVuelo; }
        }

      //   12. Volar:
      //  a.Dormirá el hilo durante 1 segundo.
      // b.Descontará una Hora Restante al vuelo.
      //c.Invocará el evento Reportar Estado con las horas totales del vuelo y las horas restantes como
      //argumentos. El método retornará el porcentaje ya completado.
        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
               this.ReportarEstado.Invoke(this.HorasDeVuelo, horasRestantes);

            }
        }
        void IAvion.Despegar()
        {
            Vuelo = new Thread(Volar);
            Vuelo.Start();
            
        }

        void IAvion.Estrellar()
        {
            if (Vuelo.IsAlive)
            {
                Vuelo.Abort();
            }            
        }
            
                
    }
}
