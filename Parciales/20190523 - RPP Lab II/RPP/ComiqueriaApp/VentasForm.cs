using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
using ComiqueriaApp;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        public VentasForm(Producto productoSeleccionado, Comiqueria comiqueria)
        {
            double precioProducto; 

            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
            this.lblDescripcion.Text = productoSeleccionado.Descripcion;

            precioProducto = productoSeleccionado.Precio * 1.21;
            precioProducto *= (double)numericUpDownCantidad.Value;

            lblPrecioFinal.Text = ($"Precio final: ${precioProducto:0.00}");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            double precioProducto = productoSeleccionado.Precio * 1.21;
            precioProducto *= (double)numericUpDownCantidad.Value;
            
            lblPrecioFinal.Text = ($"Precio final: ${precioProducto:0.00}");                        
                                
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //Al presionar el botón vender se validará que la cantidad sea menor o igual al stock
            //disponible.
            //i.Si es mayor se deberá mostrar un MessageBox informando al usuario que superó el
            //stock disponible y debe disminuir la cantidad de unidades a vender.El mensaje
            //debe tener un título, un ícono de error y sólo un botón de aceptar.
            //ii.Si es menor o igual se venderá el producto.Utilizar el método de la comiquería que
            //corresponda.Además, establecer la propiedad DialogResult del formulario con el
            //valor DialogResult.OK.Por último, cerrar el formulario.
            if (productoSeleccionado.Stock < numericUpDownCantidad.Value)
            {
                MessageBox.Show("Stock superado, ingrese cantidad menor", "Stock superado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comiqueria.Vender(productoSeleccionado, (int)numericUpDownCantidad.Value);
                this.DialogResult=DialogResult.OK;
            }


        }
    }
}
