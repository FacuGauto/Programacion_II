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


namespace Ejercicio63_threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            while(a < 100)
            {
                AsignarHora();
                System.Threading.Thread.Sleep(5000);
                a++;
            }   
        }

        private void AsignarHora()
        {
            lblHora.Text = DateTime.Now.ToString();
        }

    }
}
