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
            int numero = 1;
            int suma = 0;

            while (cantDePerfectos < 4)
            {
                for(int i = 1;i<numero;i++)
                {
                    if((numero%i)==0)
                    {
                        suma += i; 
                    }
                }
                if(suma==numero)
                {
                    cantDePerfectos++;
                    Console.WriteLine("Numero perfecto: {0}", numero);
                }
                suma = 0;
                numero++;
            }
            Console.ReadKey();
        }
    }
}
