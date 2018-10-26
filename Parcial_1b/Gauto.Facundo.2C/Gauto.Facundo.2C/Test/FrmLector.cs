using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesLibro;
using EntidadesBiblioteca;

namespace Test
{
    public partial class FrmLector : Form
    {
        private enum EPagina
        {
            Inicio,Fin,Avance,Retroceso
        }

        Biblioteca miBiblioteca;
        Libro libroActual;
        int pagina;

        public FrmLector()
        {
            InitializeComponent();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            this.miBiblioteca = Mock.CargarDatos();

            // Cargar ComboBox
            List<Libro> libros = (List<Libro>)this.miBiblioteca;
            for (int i = 0; i < libros.Count; i++)
            {
                cmbLibros.Items.Add(libros[i]);
            }
            
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Libro> libros = (List<Libro>)this.miBiblioteca;
            if (cmbLibros.SelectedIndex <= libros.Count)
            {
                // Selecciono el libro abierto
                this.libroActual = libros[cmbLibros.SelectedIndex];
                // Coloco el título en la barra
                this.Text = string.Format("Lector: {0}", this.libroActual.Mostrar());
                // Configuro la ProgressBar
                this.tspAvance.Maximum = this.libroActual.CantidadPaginas-1;

                this.SetPagina(EPagina.Inicio);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.SetPagina(EPagina.Avance);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.SetPagina(EPagina.Retroceso);
        }

        /// <summary>
        /// Seteo la página que piden por parámetro
        /// </summary>
        /// <param name="p"></param>
        private void SetPagina(EPagina p)
        {
            switch (p)
            {
                case EPagina.Inicio:
                    pagina = 0;
                    break;
                case EPagina.Fin:
                    pagina = this.libroActual.CantidadPaginas;
                    break;
                case EPagina.Avance:
                    pagina++;
                    break;
                case EPagina.Retroceso:
                    pagina--;
                    break;
            }
            // Valido página de inico y fin
            if (pagina > this.libroActual.CantidadPaginas)
                pagina = this.libroActual.CantidadPaginas;
            else if (pagina < 0)
                pagina = 0;

            // Habilito los botones
            this.btnProximo.Enabled = true;
            this.btnAnterior.Enabled = true;
            // Invalido los botones de próximo y anterior según corresponda
            if (pagina >= this.libroActual.CantidadPaginas-1)
                this.btnProximo.Enabled = false;
            if (pagina == 0)
                this.btnAnterior.Enabled = false;


            // Muestro la página actual

            this.rtbPagina.AppendText(pagina.ToString());

            // Muestro el avance en la ProgressBar
            this.tspAvance.Value = pagina;
            // Muestro la página actual
            this.tssPaginas.Text = string.Format("{0} de {1} páginas", pagina + 1, this.libroActual.CantidadPaginas);
        }
    }
}
