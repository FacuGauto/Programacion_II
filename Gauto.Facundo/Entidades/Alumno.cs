using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}",this.anio,this.division);
            }
        }
        public Alumno(string nombre,string apellido,string documento,short anio,Divisiones division) :base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }
        public override string ExponerDatos()
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0}{1}", base.ExponerDatos(),this.AnioDivision);
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
