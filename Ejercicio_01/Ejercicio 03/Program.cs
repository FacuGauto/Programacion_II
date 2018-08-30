    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            string num;
            int numero;
            int contador=0;

            Console.WriteLine("Ingrese un numero: ");
            num = Console.ReadLine();
            numero = int.Parse(num);

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("Numero primo {0}",i);
                }
                contador = 0;
            }
            Console.ReadKey();
        }
    }
}
