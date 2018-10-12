using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciocio_42
{
    class Operaciones
    {
        public Operaciones(int num1,int num2)
        {
            try
            {
                division(num1, num2);
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }


        public static int division(int numeroUno, int numeroDos)
        {
            int resultado = 0;
            try
            {
                 resultado = numeroUno / numeroDos;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
            return resultado;
        }
    }
}
