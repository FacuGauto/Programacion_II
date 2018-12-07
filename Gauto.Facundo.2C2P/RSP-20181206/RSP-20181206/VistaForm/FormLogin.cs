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
    public partial class FormLogin : Form
    {
        Usuario usuario;
        public FormLogin()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //ALUMNO
            try
            {
                UsuarioDAO sql = new UsuarioDAO();
                this.usuario = sql.Leer(txtUsuario.Text, txtClave.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar recuperar el usuario");
            }
            /*catch (Exception)
            {
                throw;
            }*/
            if (usuario != null)
            {
                this.Hide();
                FormAgencia f2 = new FormAgencia();
                f2.ShowDialog();
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            usuario = new Usuario(txtUsuario.Text,txtClave.Text);
            //ALUMNO
            try
            {
                UsuarioDAO sql = new UsuarioDAO();
                if (sql.Guardar(usuario))
                {
                    MessageBox.Show("Usuario registrado.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar el usuario");
            }

            //limpio los controles después del registro
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            usuario = null;

        }
    }
}
