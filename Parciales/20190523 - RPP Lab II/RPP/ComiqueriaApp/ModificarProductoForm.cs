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

namespace ComiqueriaApp
{
    public partial class ModificarProductoForm : Form
    {
        Producto producto;
        public ModificarProductoForm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            lblDescripcion.Text = producto.Descripcion;
            txtPrecioActual.Text = ($"{producto.Precio:0.00}");
            txtPrecioActual.ReadOnly = true;
        }

        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double precio;

            if (double.TryParse(txtNuevoPrecio.Text, out precio))
            {
                DialogResult=MessageBox.Show("Confirmar modificacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult==DialogResult.Yes)
                {
                    producto.Precio = precio;
                    txtNuevoPrecio.Text = "";
                    txtPrecioActual.Text = ($"{producto.Precio:0.00}");
                }
            }
            else
            {
                lblError.Text = "Error.Debe ingresar un precio válido.";
            }
        }

        private void txtPrecioActual_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            double d;

            if (!double.TryParse(txtNuevoPrecio.Text, out d) && txtNuevoPrecio.Text!="")
            {
                lblError.Text = "Error.Debe ingresar un precio válido.";
            }
            else
            {
                lblError.Text = "";
            }
        }
    }
}
