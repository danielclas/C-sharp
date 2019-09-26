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
    public partial class Form1 : Form
    {
        Curso curso;
        List<Alumno> lista;
        public Form1()
        {
            InitializeComponent();
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            lista = new List<Alumno>();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtNombreCurso.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            curso = new Curso((short)nudAnioCurso.Value, division, profesor);

            if (lista.Count > 0)
            {
                lista.ForEach(k => curso += k);
            }           

            MessageBox.Show("El curso fue agregado");

            btnCrear.Enabled = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(curso, null))
            {
                MessageBox.Show("Aun no se ha agregado un curso", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbDatos.Text = (string)curso;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);
            string mensaje = "";

            if (ReferenceEquals(curso, null))
            {
                lista.Add(alumno);
                mensaje = ", aun no se ha agregado un curso";
            }
            else
            {
                curso += alumno;
                rtbDatos.Text = (string)curso;
            }

            MessageBox.Show("El alumno fue creado"+mensaje);
        }
    }
}
