using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Curso
    {
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        private List<Alumno> alumnos;

        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short anio,Divisiones division,Profesor profesor) :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public static explicit operator string(Curso c)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            foreach (Alumno item in c.alumnos)
            {
                myStringBuilder.AppendFormat(item.ExponerDatos());
            }
            return myStringBuilder.ToString();
        }
    }
}
