using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio_60_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            //Connection conexion = new Connection("SELECT name FROM Production.Product");
            string connectionStr = "Data Source=LAB3PC24\\SQLEXPRESS;Initial Catalog =AdventureWorks2012; Integrated Security = True";
            SqlConnection conexion = new SqlConnection(connectionStr);
            SqlCommand comando;
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Connection = conexion;

            comando.CommandText = "SELECT name FROM Production.Product";


            try
            {
                //conexion.abrir();
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    string aux = oDr["name"].ToString();
                    cmbProduct.Items.Add(aux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
        }
    }
}
