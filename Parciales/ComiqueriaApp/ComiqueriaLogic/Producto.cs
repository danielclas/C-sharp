using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        protected Guid codigo;
        protected string descripcion;
        protected double precio;
        protected int stock;

        public string Descripcion { get { return descripcion; } }
        public double Precio { get { return precio; } }

        public int Stock { get { return stock; } set { if (value >= 0) stock = value; } }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str = str.Append($"Descripcion: {Descripcion}\nCodigo: {codigo.ToString()}\nPrecio: ${Precio}\nStock: {stock}");

            return str.ToString();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
    }
}
