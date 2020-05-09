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

namespace FrmPpal
{
    public partial class FormPpal : Form
    {
        Correo correo;

        public FormPpal()
        {
            InitializeComponent();
            correo = new Correo();
        }

        /// <summary>
        /// Actualiza el estado del paquete
        /// </summary>
        private void ActualizarEstados()
        {
            this.lstEstadoEntregado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoIngresado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(p);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(p);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(p);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Informar si hubo un error
        /// </summary>
        /// <param name="mensaje">Mensaje del error</param>
        private void InformarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        /// <summary>
        /// Evento click del boton agregar
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ID, direccion;
            Paquete paquete;

            if (!string.IsNullOrEmpty(this.mtxtTrackingID.Text) && !string.IsNullOrEmpty(this.txtDireccion.Text))
            {
                ID = this.mtxtTrackingID.Text;
                direccion = this.txtDireccion.Text;

                paquete = new Paquete(direccion, ID);
                paquete.InformaEstado += this.paq_InformaEstado;

                try
                {
                    this.correo += paquete;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.ActualizarEstados();
        }

        /// <summary>
        /// Evento click del boton mostrar todos
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Evento closing del form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void FormPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        /// <summary>
        /// Muestra la informacion de un elemento
        /// </summary>
        /// <param name="elemento">Elemento a mostrar</param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!ReferenceEquals(elemento, null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                try
                {
                    this.rtbMostrar.Text.Guardar("salida.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error guardando en el archivo");
                }           
            }
        }

        /// <summary>
        /// Informa el estado del paquete
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        /// <summary>
        /// Evento click de tool strip menu
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        /// <summary>
        /// Metodo load del form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void FormPpal_Load(object sender, EventArgs e)
        {
            PaqueteDAO.excepcionBDD += this.InformarError;
        }
    }
}
