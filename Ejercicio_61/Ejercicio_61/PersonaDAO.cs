using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio_61
{
    class PersonaDAO
    {
        public void Guardar(Persona p)
        { }
        public void Leer(Persona p)
        {
            Conexion conexion = new Conexion("SELECT * FROM dbo.Persona");

            try
            {
                conexion.abrir();
                SqlDataReader oDr = conexion.comando.ExecuteReader();

                while (oDr.Read())
                {
                    string aux = oDr["name"].ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
        public void LeerPorID(Persona p)
        { }
        public void Modificar(Persona p)
        { }
        public void Borrar(Persona p)
        { }
    }
}
