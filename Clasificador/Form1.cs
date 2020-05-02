using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace Clasificador
{
    public partial class Form1 : Form
    {
        private string CadenaRecibida;
        public Form1()
        {

            //Creación de hilo
            Thread t = new Thread(new ThreadStart(SplashStart));
            //Arrancamos el hilo
            t.Start();
            //Tiempo para dormir la forma principal
            Thread.Sleep(5000);
            InitializeComponent();
            //Finalizamos el hilo 
            t.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        //Método para buscar los puertos en el equipo
        private void BuscarPuertos()
        {
            //Obtener el nombre de puertos existentes en el equipo
            string[] NombresPuertos = SerialPort.GetPortNames();
            //Eliminar los elementos del control ComboBox
            cmbPuertos.Items.Clear();
            //Ciclo para agregar los nombres de los puertos al control ComboBox
            foreach (string Nombre in NombresPuertos)
                cmbPuertos.Items.Add(Nombre);
            //Agregar el mensaje en la propiedad del control
            cmbPuertos.Text = "Seleccione Puerto";
        }

        //Método que se genera al hacer clic en el botón Actualizar
        private void btnActualizarPuertos_Click(object sender, EventArgs e)
        {
            BuscarPuertos();
        }
        //Método que se genera cuando se cambia el índice del ComboBox cmbPuertos
        private void cmbPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Asignar el nombre actual del ComboBox a la propiedad PortName del puerto
            serialPort1.PortName = cmbPuertos.SelectedItem.ToString();
        }
        //Método que se genera cuando se hace clic en el botón para Conectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el puerto
                serialPort1.Open();
                MessageBox.Show("Puerto Abierto");
                tmrActualizarDatos.Start();
            }
            catch (Exception error)
            {
                //Si ocurre una excepción, enviar el mensaje al usuario 
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Evento que se genera cuando se hace clic en el botón desconectar
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Puerto Cerrado");
                tmrActualizarDatos.Stop();
            }
            else
                MessageBox.Show("El puerto está cerrado");
        }
        //Evento que se genera cuando se reciben datos por el puerto
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Espera 1000 ms
            Thread.Sleep(1000);
            //Asignar los datos existentes en el búfer al atributo CadenaRecibida
            CadenaRecibida = serialPort1.ReadExisting();
        }
        //Evento que se genera cada que transcurren 100ms del Timer
        private void tmrActualizarDatos_Tick(object sender, EventArgs e)
        {
            txtRecibidos.Text = CadenaRecibida;
        }
        //Evento que se genera cuando se hace clic en el botón Enviar 
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.WriteLine(txtEnviar.Text);
            else
                MessageBox.Show("Necesita conectar al puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
