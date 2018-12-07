using System.Windows.Forms;
using System;
using Entidades;
using Archivos;

namespace VistaForm
{
    public partial class FormAgencia : Form
    {
        private Agencia agencia;

        public FormAgencia()
        {
            InitializeComponent();
            agencia = new Agencia("Agencia UTN");
            string[] items = new string[] { "Micro", "Avión" };
            this.cmbTipoPasaje.DataSource = items;
            this.cmbTipoPasaje.SelectedIndex = 0;
            this.nudEscalas.Enabled = false;


            this.txtNombre.Text = "Nombre";
            this.txtApellido.Text = "Apellido";
            this.txtDni.Text = "33444555";
            this.txtOrigen.Text = "Buenos Aires";
            this.txtDestino.Text = "Cordoba";
            cmbTipoServicio.DataSource = Enum.GetValues(typeof(Servicio));
        }

        private void btnEmitirPasaje_Click(object sender, System.EventArgs e)
        {
            Pasajero pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, txtDni.Text);
            float precio = float.Parse(txtPrecio.Text);
            DateTime fecha = DateTime.Parse(dtpFechaPartida.Text);

            if (cmbTipoPasaje.Text == "Micro")
            {
                Pasaje pasajeMicro = new PasajeMicro(txtOrigen.Text, txtDestino.Text, pasajero, precio, fecha, Servicio.Comun);
                this.agencia.PasajesVendidos.Add(pasajeMicro);
            }
            else if (cmbTipoPasaje.Text == "Avión")
            {
                Pasaje pasajeAvion = new PasajeAvion(txtOrigen.Text, txtDestino.Text, pasajero, precio, fecha, int.Parse(nudEscalas.Value.ToString()));
                this.agencia.PasajesVendidos.Add(pasajeAvion);
            }
            //
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            rtbMostrar.Text = (string)this.agencia;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Xml<Agencia> xml = new Xml<Agencia>(); 
                xml.Guardar("Agencia.xml",this.agencia);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al al serializar");
            }
        }

        private void cmbTipoPasaje_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cmbTipoPasaje.SelectedIndex == 0)
            {
                this.nudEscalas.Enabled = false;
                this.nudEscalas.Value = 0;
                this.cmbTipoServicio.Enabled = true;
            }
            else
            {
                this.nudEscalas.Enabled = true;
                this.cmbTipoServicio.Enabled = false;
            }
        }

        private void FormAgencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAgencia_Load(object sender, EventArgs e)
        {
            this.agencia.informar += MostrarMensaje;
        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
