using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLLamada
        {
            get;
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                if (llamada1.Duracion > llamada2.Duracion)
                {
                    return 1;
                }
            }
            return 0;
        }
        protected virtual string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("La duracion es: {0}. ", this.Duracion);
            mystringBuilder.AppendFormat("El numero de destino es: {0}. ", this.NroDestino);
            mystringBuilder.AppendFormat("El numero de origen es: {0}. ", this.NroOrigen);

            return mystringBuilder.ToString();
        }
        public enum TipoLlamada { Local, Provincial, Todas };

        public static bool operator ==(Llamada l1,Llamada l2)
        {
            if(l1.Equals(l2) && (l1.NroDestino == l2.NroDestino) && (l1.Duracion == l2.Duracion))
            return true;

            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            if(!(l1 == l2))
            return true;

            return false;
        }

    }
}
