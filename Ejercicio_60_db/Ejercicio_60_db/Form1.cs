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
            Conexion conexion = new Conexion("SELECT name FROM Production.Product");

            try
            {
                conexion.abrir();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                SqlDataReader oDr = conexion.comando.ExecuteReader();

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
                conexion.cerrar();
                MessageBox.Show("Se cerró la conexión.");
            }
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion("INSERT INTO dbo.Ejemplo(id,nombre,apellido) VALUES(2,'Juan','Argento');");

            try
            {
                conexion.abrir();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                conexion.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.cerrar();
                MessageBox.Show("Se cerró la conexión.");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion("UPDATE dbo.Ejemplo SET nombre = 'Tuvi' WHERE id = 2;");

            try
            {
                conexion.abrir();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                conexion.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.cerrar();
                MessageBox.Show("Se cerró la conexión.");
            }
        }
    }
}
