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
        private string documento;
        private string nombre;

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if(this.ValidarDocumentacion(value))
                    this.documento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
         }
        public virtual string ExponerDatos()
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0},{1},{2}", this.Apellido, this.Documento, this.nombre);
            return myStringBuilder.ToString();
        }
        public Persona(string nombre,string apellido,string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }
        protected abstract bool ValidarDocumentacion(string doc);
        



    }
}
