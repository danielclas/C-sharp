using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobantesLogic;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private static Stack<Comprobante> comprobantes;
        private List<Producto> productos;
        private List<Venta> ventas;
        
        public List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                List<Comprobante> lista = new List<Comprobante>();

                foreach (Comprobante c in Comiqueria.comprobantes)
                {
                    if (((Producto)c.Venta)==producto)
                    {
                        lista.Add(c);
                    }
                }

                if (ordenar)
                {
                    lista.Sort((j,k)=>j.Venta.Fecha.CompareTo(k.Venta.Fecha));
                }

                return lista;
            }
        }
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

        public bool AgregarComprobante(Comprobante comprobante)
        {
            bool rtn = false;

            if (this!=comprobante)
            {
                Comiqueria.comprobantes.Push(comprobante);
                rtn = true;
            }

            return rtn;
        }

        public bool AgregarComprobante(Venta venta)
        {
            Factura f = new Factura(venta, Factura.TipoFactura.E);

            return AgregarComprobante(f);
        }

        static Comiqueria()
        {
            comprobantes = new Stack<Comprobante>();
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

        public static bool operator ==(Comiqueria comiqueria, Comprobante comprobante)
        {
            bool rtn = false;

            foreach (Comprobante c in Comiqueria.comprobantes)
            {
                if (c==comprobante)
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante)
        {
            return !(comiqueria == comprobante);
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
