using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesBiblioteca;
using EntidadesLibro;

namespace Test
{
    static class Mock
    {
        public static Biblioteca CargarDatos()
        {
            Biblioteca b = new Biblioteca(3);

            Libro l1 = new Novela(400, "100 años de soledad", 10, 100, 50);
            l1[1] = "Página Nº1 - 100 años";
            l1[2] = "Página Nº2 - 100 años";
            l1[3] = "Página Nº3 - 100 años";
            l1[4] = "Página Nº4 - 100 años";
            Libro l2 = new Novela(500, "El Psicoanalista", 50, 120, 50);
            l2[1] = "Página Nº1 - Psicoanalista";
            l2[2] = "Página Nº2 - Psicoanalista";
            Libro l3 = new Comic(50, "Batman: Año 1", 9, 90, 52);
            l3[1] = "Página Nº1 - Batman";
            l3[2] = "Página Nº2 - Batman";
            l3[3] = "Página Nº3 - Batman";
            l3[4] = "Página Nº4 - Batman";
            l3[5] = "Página Nº5 - Batman";
            Libro l4 = new Comic(25, "Daredevil: El hombre sin miedo", 8, 110, 48);
            l4[1] = "Página Nº1 - Daredevil";
            l4[2] = "Página Nº2 - Daredevil";
            l4[3] = "Página Nº3 - Daredevil";

            b = b + l1;
            b = b + l2;
            b = b + l3;
            b = b + l4;

            return b;
        }
    }
}
