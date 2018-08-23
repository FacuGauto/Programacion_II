using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            int cantDePerfectos = 0;
            int contador = 1;
            int suma = 0;

            while (cantDePerfectos < 4)
            {
                for(int i = 1;i<contador;i++)
                {
                    if(i%contador==0)
                    {
                        suma += i; 
                    }
                }
                if(suma==contador)
                {
                    cantDePerfectos++;
                    Console.WriteLine("Numero perfecto: {0}", contador);
                }
                suma = 0;
                contador++;
            }
            Console.ReadKey();
        }
    }
}
