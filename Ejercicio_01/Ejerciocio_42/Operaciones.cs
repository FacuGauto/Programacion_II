using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciocio_42
{
    class Operaciones : Exception
    {
        public Operaciones(Exception e)
        {
            throw new ExcepcionPropia("Error en contructor", e);
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
