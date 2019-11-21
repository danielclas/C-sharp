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
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        /*        
        14. Agregar el manejador del evento de la clase VistaPatente con el nombre ProximaPatente.
        15. En el evento Load del formulario, asociar el evento VistaPatente para los objetos vistaPatente1 y vistaPatente2 con el manejador.
        16. En cada botón leer del origen que corresponda (SQL, XML, TXT) agregar los datos a la cola de Patentes. También capturar las excepciones y llamar al método IniciarSimulacion.
        17. IniciarSimulacion:
        a. Finalizará los hilos activos.
        b. Llamará al método ProximaPatente para cada uno de los objetos del tipo VistaPatente del formulario.
        18. ProximaPatente, si hay elementos en la cola de patentes:
        a. Instanciará un hilo parametrizado para el método MostrarPatente del objeto VistaPatente recibido.
        b. Inicializará el hilo recién creado con el próximo elemento de la cola.
        c. Agregará el hilo a la lista.                        
        */
        Queue<Patente> cola;
        List<Thread> threads;         

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            this.threads.ForEach(t => t.Abort());
        }
    }
}
