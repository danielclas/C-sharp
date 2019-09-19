using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Centralita
  {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get; }
        public float GananciasPorProvincial { get;}
        public float GananciasPorTotal { get { return CalcularGanancia(); } }
        public List<Llamada> Llamadas { get;}

        //l.CalcularGanancia será privado.Este método recibe un Enumerado TipoLlamada y retornará
        //el valor de lo recaudado, según el criterio elegido(ganancias por las llamadas del tipo Local,
        //Provincial o de Todas según corresponda).
        //m.El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
        //y provinciales y el detalle de las llamadas realizadas.
        //n.La lista sólo se inicializará en el constructor por defecto Centralita().
        //o.Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el
        //precio de lo facturado según el criterio.Dichos valores se calcularán en el método
        //CalcularGanancia().

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa)
        {

        }

        public string Mostrar()
        {

        }

        public void OrdenarLlamadas()
        {

        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {

        }


    }
}
