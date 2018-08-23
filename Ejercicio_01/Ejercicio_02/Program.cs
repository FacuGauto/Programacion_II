using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            string numero;
            int num;
            long cuadrado;
            long cubo;

            Console.Title = "Ejercicio Nro 02";
            Console.WriteLine("Ingrese un numero: ");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            cuadrado = (long)Math.Pow(num,2);
            cubo = (long)Math.Pow(num, 3);

            Console.WriteLine("Numero al cuadrado: {0}", cuadrado);
            Console.WriteLine("Numero al cubo: {0}", cubo);
            Console.ReadKey();
        }
    }
}
