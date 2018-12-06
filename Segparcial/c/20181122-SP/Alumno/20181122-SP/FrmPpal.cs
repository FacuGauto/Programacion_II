using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Patentes;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
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
            this.vistaPatente1.finExposicion += ProximaPatente;
            this.vistaPatente2.finExposicion += ProximaPatente;
        }

        private void ProximaPatente(Patentes.VistaPatente vp)
        {
            if (this.cola.Count > 0)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                thread.Start(vp);
                this.threads.Add(thread);
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<Queue<Patente>> xml = new Xml<Queue<Patente>>();
                xml.Leer("patentes.xml", out this.cola);
                this.IniciarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
                texto.Leer("patentes.txt", out this.cola);
                this.IniciarSimulacion();
            }
            /*catch (PatenteInvalidaException a)
            {
                MessageBox.Show(a.Message);
            }*/
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.Leer("Patentes", out this.cola);
                this.IniciarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread t in this.threads)
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }
    }
}
