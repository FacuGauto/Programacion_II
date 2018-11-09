using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Ejercicio_60_db
{
    public class Conexion
    {
        public string connectionStr;
        public SqlConnection conexion;
        public SqlCommand comando;

        public Conexion()
        {
            this.connectionStr = "Data Source = LAB3PC24\\SQLEXPRESS; Initial Catalog = AdventureWorks2012; Integrated Security = True";
            this.conexion = new SqlConnection(connectionStr);
            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = conexion;
        }

        public Conexion(string consulta) : this()
        {
            this.comando.CommandText = consulta;
        }

        public string ConnectionStr
        {
            get
            {
                return this.connectionStr;
            }
        }

        public void abrir()
        {
            this.comando.Connection.Open();
        }
        public void cerrar()
        {
            this.comando.Connection.Close();
        }

    }
}
