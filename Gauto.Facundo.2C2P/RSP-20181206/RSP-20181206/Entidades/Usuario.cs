using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string clave;

        public Usuario()
        { }

        public Usuario(string nombre, string clave)
        {
            this.nombre = nombre;
            this.Clave = clave;
        }

        public string Nombre { get => nombre; }
        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                //ALUMNO
                if(value.Length < 8)
                {
                    throw new ClaveInvalidaException("La clave debe contener al menos 8 digitos!");
                }
                else
                {
                    clave = value;
                }
            }
        }
    }
}
