using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibro
{
    public class Novela:Libro
    {
        private int cantPaginas;

        public Novela(int cantPaginas, string titulo, float tamanioLetra, int ancho, int alto) :base(titulo,tamanioLetra,ancho,alto)
        {
            this.cantPaginas = cantPaginas;
        }
        public override ETipoImpresion TipoImpresion
        {
            get
            {
                return Libro.ETipoImpresion.BlancoNegro;
            }
        }

        /// <summary>
        /// Muestra titulo, cantidad de paginas y btipo de impresion de la Novela
        /// </summary>
        /// <returns>Devuelve un string con los datos de la novela</returns>
        public override string Mostrar()
        {
            return String.Format("El titulo de la novela es: {0}, su cantidad de paginas es: {1} y el tipo de impresion que usa es: {2}", base.Mostrar(), this.CantidadPaginas, this.TipoImpresion) ;
        }

        /// <summary>
        /// Compara la igualdad de dos novelas
        /// </summary>
        /// <param name="n1">Primer objeto de tipo novela</param>
        /// <param name="n2">Segunda objeto de tipo novela</param>
        /// <returns>True si son la misma novela, false sino</returns>
        public static bool operator ==(Novela n1, Novela n2)
        {
            if (n1.Mostrar() == n2.Mostrar())
                return true;

            return false;
        }

        /// <summary>
        /// compara la desigualdad de dos novelas
        /// </summary>
        /// <param name="n1">Primer objeto de tipo novela</param>
        /// <param name="n2">Segundo objeto de tipo novela</param>
        /// <returns>True si son distintas novelas, false sino</returns>
        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }
    }
}
