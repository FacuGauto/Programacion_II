using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            int numero;
            string num;
            int sumaMenores = 0;
            int sumaMayores = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = Console.ReadLine();
            numero = int.Parse(num);

            for (int i = 2; i < numero; i++)
            {
                for (int j = (i - 1); j > 0; j--)
                {
                    sumaMenores += j;
                }
                /*if (sumaMenores == (i + 1))
                {
                    Console.WriteLine("Centro numerico: {0}",i);
                }
                else if(sumaMenores> (i + 1))
                {*/
                    for (int a = (i+1); a < numero; a++)
                    {
                        sumaMayores += a; 
                        if(sumaMenores == sumaMayores)
                        {
                            Console.WriteLine("Centro numerico: {0}", i);
                        }
                    }
                //}
                sumaMenores = 0;
                sumaMayores = 0;
            }
            Console.ReadKey();
        }
    }
}
