using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        private List<Alumno> alumnos;

        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}", this.anio, this.division);
            }
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
        public static bool operator ==(Curso c, Alumno a)
        {
            if (c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
    }
}
