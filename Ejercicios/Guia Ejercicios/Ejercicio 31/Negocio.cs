using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Cliente { get { return clientes.Dequeue(); } set { clientes.Enqueue(value);} }
    public int ClientesPendientes { get { return clientes.Count; }}

    private Negocio()
    {
      clientes = new Queue<Cliente>();
      nombre = "Caja 1";
    }

    public Negocio(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      bool rtn = false;

      foreach (Cliente c2 in n.clientes)
      {
        if (c.Numero == c2.Numero)
        {
          rtn = true;
          break;
        }
      }

      return rtn;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      return !(n == c);
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool rtn = false;

      if (n != c)
      {
        n.clientes.Enqueue(c);
        rtn = true;
      }

      return rtn;
    }

    public static bool operator ~(Negocio n)
    {
      return n.caja.Atender(n.Cliente);
    }


  }
}
