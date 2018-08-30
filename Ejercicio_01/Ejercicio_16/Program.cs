using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            alumnoUno.nombre = "Bruno";
            alumnoUno.apellido = "Lopez";
            alumnoUno.legajo = "0001";
            alumnoUno.Estudiar(10, 8);
            alumnoUno.calcularFinal();

            alumnoDos.nombre = "Julia";
            alumnoDos.apellido = "Lopez";
            alumnoDos.legajo = "0002";
            alumnoDos.Estudiar(7, 3);
            alumnoDos.calcularFinal();

            alumnoTres.nombre = "Mariano";
            alumnoTres.apellido = "Gomez";
            alumnoTres.legajo = "0003";
            alumnoTres.Estudiar(5, 8);
            alumnoTres.calcularFinal();

            alumnoUno.Mostrar();
            alumnoDos.Mostrar();
            alumnoTres.Mostrar();

            Console.ReadKey();
        }
    }
}
