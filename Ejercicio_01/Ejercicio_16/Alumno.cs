using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        public string nombre;
        public string apellido;
        public string legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public void calcularFinal()
        {
            this.notaFinal = -1;
            Random objRandom = new Random();
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = objRandom.Next(5, 10);
            }
        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}, apellido: {1}, legajo: {2}, nota 1: {3}, nota 2: {4}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota Final: {0}.\n",this.notaFinal);
            }
            else
            {
                Console.WriteLine("Alumno desaprobado.\n");
            }
        }
    }
}
