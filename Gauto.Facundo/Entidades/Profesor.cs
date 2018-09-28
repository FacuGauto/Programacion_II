using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Profesor: Persona
    {
        private DateTime fechaIngreso;
        
        public int Antiguedad
        {
            get
            {
                DateTime now = DateTime.Now;
                TimeSpan dias = now - this.fechaIngreso;
                int cantidadDias = dias.Days;
                return cantidadDias;
            }
        }
    
        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        { }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso= fechaIngreso;
        }
        public override string ExponerDatos()
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0}{1}", base.ExponerDatos(), this.fechaIngreso);
            return myStringBuilder.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if (doc.Length == 9)
                for (int i = 0; i < doc.Length; i++)
                {
                    int aux = 0;
                    if ((i == 2 || i == 7) && doc[i] == '-')
                    {
                        continue;
                    }
                    else if ((i != 2 || i != 7) && int.TryParse(doc[i].ToString(), out aux))
                    {
                        retorno = true;
                    }
                    else
                        break;
                }
            return retorno;
        }
    }
    
}
