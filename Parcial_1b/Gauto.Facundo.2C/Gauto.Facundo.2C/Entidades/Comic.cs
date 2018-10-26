using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibro
{
    public class Comic:Libro
    {
        private int cantCuadros;

        public override ETipoImpresion TipoImpresion
        {
            get
            {
                return Libro.ETipoImpresion.Color;
            }
        }
        public Comic(int cantCuadros, string titulo, float tamanioLetra, int ancho, int alto):base(titulo,tamanioLetra,ancho,alto)
        {
            this.cantCuadros = cantCuadros;
        }

        public override string Mostrar()
        {
            return String.Format("El titulo del comic es: {0}, su cantidad de cuadros es: {1} y el tipo de impresion que usa es: {2}", base.Mostrar(), this.cantCuadros, this.TipoImpresion);
        }
    }
}
