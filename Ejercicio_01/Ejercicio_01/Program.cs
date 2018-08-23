using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            int i,num;
            int maximo = int.MaxValue;
            int minimo = int.MinValue;
            int suma = 0;
            int promedio;
            string numero;

            Console.Title = "Ejerciocio  Nro 01";

            for(i=0;i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Console.ReadLine();
                num = int.Parse(numero);
                suma += num;
                
                if(maximo<num)
                {
                    maximo = num;
                }
                if(minimo>num)
                {
                    minimo = num;
                }
            }
            promedio = suma/5;
            Console.WriteLine("Numero Maximo: {0}",maximo);
            Console.WriteLine("Numero Minimo: {0}",minimo);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();
        }
    }
}
