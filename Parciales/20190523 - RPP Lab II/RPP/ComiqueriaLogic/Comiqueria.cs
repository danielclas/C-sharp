using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private Stack<comprob>
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto rtn = null;

                foreach (Producto p in productos)
                {
                    if ((Guid)p == codigo)
                    {
                        rtn = p;
                        break;
                    }
                }

                return rtn;
            }
        }

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public string ListarVentas()
        {
            StringBuilder str = new StringBuilder();

            ventas.Sort((v1, v2) => v1.Fecha.CompareTo(v2.Fecha));
            ventas.Reverse();

            foreach (Venta v in ventas)
            {
                str.AppendLine(v.ObtenerDescripcion());
            }

            return str.ToString();
        }       

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> dic = new Dictionary<Guid, string>();

            foreach (Producto p in productos)
            {
                if (!(dic.ContainsKey((Guid)p)))
                {
                    dic.Add((Guid)p, p.Descripcion);
                }
            }            

            return dic;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            ventas.Add(venta);
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool rtn = false;

            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }

    }
}
