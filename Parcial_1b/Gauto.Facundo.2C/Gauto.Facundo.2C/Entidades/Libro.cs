using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLibro
{
    public abstract class Libro
    {
        private int altoHoja;
        private int anchoHoja;
        private List<string> pagina;
        private float tamanioLetra;
        private string titulo;

        private Libro()
        {
            this.pagina = new List<string>();
        }
        public Libro(string titulo, float tamanioLetra, int ancho, int alto):this()
        {
            this.titulo = titulo;
            this.tamanioLetra = tamanioLetra;
            this.anchoHoja = ancho;
            this.altoHoja = alto;
        }
        public int AltoHoja
        {
            get
            {
                return altoHoja;
            }
        }
        public int AnchoHoja
        {
            get
            {
                return anchoHoja;
            }
        }
        public int CantidadPaginas
        {
            get
            {
                return this.pagina.Count;
            }
        }

        /// <summary>
        /// Devuelve el tamaño de la letra y lo setea copn el valor ingresado solo si este es menor al 10% de la suma del ancho y alto de la hoja 
        /// </summary>
        public float TamanioLetra
        {
            get
            {
                return tamanioLetra;
            }
            set
            {
                if (value < ((this.altoHoja + this.anchoHoja) * 0.10))
                {
                    tamanioLetra = value;
                }
                else
                {
                    tamanioLetra = 12;
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return "";
            }
            set
            {
                this.pagina.Add(value);
            }
        }
        public abstract ETipoImpresion TipoImpresion { get; }

        public virtual string Mostrar()
        {
            return this.titulo;
        }

        public enum ETipoImpresion { Color,BlancoNegro,Mixto };
    }
}
