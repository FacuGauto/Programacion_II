using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,
                suma = 0,
                promedio;
            string numLetra;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int numerosValidados = 0;
            Console.WriteLine("Ingrese 10 numeros entre -100 y 100");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numLetra = Console.ReadLine();
                numero = int.Parse(numLetra);
                if (Validacion.Validar(numero, -100, 100))
                {
                    numerosValidados++;
                    if (minimo > numero)
                    {
                        minimo = numero;
                    }
                    if (maximo < numero)
                    {
                        maximo = numero;
                    }
                    suma += numero;
                }
            }
            if(numerosValidados>0)
            {
                promedio = suma / 10;
                Console.WriteLine("El numero minimo es: {0}.\nEl numero maximo es: {1}.\nEl promedio es: {2}.",minimo,maximo,promedio);
            }
            else
            {
                Console.WriteLine("No se ingreso ningun numero valido");
            }
            Console.ReadKey();
        }
    }
}
