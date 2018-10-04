using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int edad;
        private int dni;

        public Persona(string nombre,string apellido,int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public virtual string Mostrar()
        {
            StringBuilder myStringbuilder = new StringBuilder();
            myStringbuilder.AppendFormat("{0}, {1}, {2}, {3}", this.Apellido, this.Dni, this.Edad, this.Nombre);
            return myStringbuilder.ToString();
        }
       // public abstract bool ValidarAptitud();
    }
}
