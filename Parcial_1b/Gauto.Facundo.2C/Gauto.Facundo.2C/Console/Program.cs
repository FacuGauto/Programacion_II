using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesLibro;
using EntidadesBiblioteca;
using Test;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagina;
            Libro l1 = new Novela(400, "100 años de soledad", 10, 100, 50);
            l1[1] = "Página Nº1 - 100 años";
            l1[2] = "Página Nº2 - 100 años";
            l1[3] = "Página Nº3 - 100 años";
            l1[4] = "Página Nº4 - 100 años";

            System.Console.WriteLine("Que pagina desea abrir");
            pagina = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(l1[pagina]);
            System.Console.ReadLine();
        }
    }
}
