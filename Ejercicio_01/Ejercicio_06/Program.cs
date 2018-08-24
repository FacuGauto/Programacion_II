using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            int año;
            string añoLetras;
            Console.WriteLine("Ingrese un año: ");
            añoLetras = Console.ReadLine();
            año = int.Parse(añoLetras);

            if((año % 4) ==0)
            {
                if ((año % 100) == 0)
                {
                    if((año % 400)==0)
                    {
                        Console.WriteLine("Año bisiesto: {0}", año);
                    }
                    else
                    {
                        Console.WriteLine("No es un año bisiesto.");
                    }
                }
                else
                {
                    Console.WriteLine("Año bisiesto: {0}", año);
                }
            }
            else
            {
                Console.WriteLine("No es un año bisiesto.");
            }
            Console.ReadKey();
        }
    }
}
