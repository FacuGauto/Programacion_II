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
        private DirectorTecnico dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Crear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            int edad = (int)numericUpDownEdad.Value;
            int dni = (int)numericUpDownDni.Value;
            int experiencia = (int)numericUpDownExperiencia.Value;
            dt = new DirectorTecnico(nombre, apellido, edad, dni, experiencia);

            MessageBox.Show("Se ha creado el DT!");
        }

        private void button2_Validar_Click(object sender, EventArgs e)
        {
            if (dt is null)
            {
                MessageBox.Show("Aun no se ha credo el DT del formulario");
            }
            if (dt.ValidarAptitud() == true)
            {
                MessageBox.Show("El Dt es apto.");
            }
        }
    }
}
