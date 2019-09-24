using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{

    public partial class FormDT : Form
    {
        DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);

            MessageBox.Show("Se ha creado el DT!");
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if (ReferenceEquals(dt, null))
            {
                mensaje = "Aun no se ha creado el DT del formulario";
            }
            else
            {
                mensaje = dt.ValidarAptitud() ? "El DT es apto" : "El DT no es apto";
            }

            MessageBox.Show(mensaje);
        }
    }
}
