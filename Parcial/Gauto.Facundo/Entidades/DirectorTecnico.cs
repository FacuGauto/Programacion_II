using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) :base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get
            {
                return añosExperiencia;
            }
            set
            {
                añosExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            StringBuilder myStringbuilder = new StringBuilder();
            myStringbuilder.AppendFormat("{0}, {1}", base.Mostrar(), this.AñosExperiencia);
            return myStringbuilder.ToString();
        }

        public bool ValidarAptitud()
        {
            bool retorno = false;
            if((this.Edad < 65) &&(this.AñosExperiencia>=2))
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
