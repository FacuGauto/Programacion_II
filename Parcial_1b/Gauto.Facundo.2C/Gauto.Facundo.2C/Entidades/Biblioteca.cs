using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesLibro;

namespace EntidadesBiblioteca
{
    public class Biblioteca
    {
        private short cantidad;
        private List<Libro> libros;

        static Biblioteca()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.cantidad = 10;
        }
        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        public Biblioteca(short cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Agrega un nuevo libro a la lista si hay lugar y si este no se encuntra ya en la lista
        /// </summary>
        /// <param name="b">Objeto de tipo Biblioteca</param>
        /// <param name="l">Objeto de tipo Libro</param>
        /// <returns>devuelve un objeto de tipo Biblioteca</returns>
        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if (b.cantidad > b.libros.Count)
            {
                return b;
            }
            for (int i = 0; i < b.libros.Count; i++)
            {
                if (b.libros[i] == l)
                    return b;
            }
            b.libros.Add(l);
            return b;
        }

        /// <summary>
        /// Ingresando una objeto de tipo biblioteca devuelve su lista de libros
        /// </summary>
        /// <param name="b">retorna la lista de libros</param>
        public static explicit operator List<Libro>(Biblioteca b)
        {
            return b.libros;
        }


    }
}
