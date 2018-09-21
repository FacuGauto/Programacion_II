using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Local: Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo): base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion,string destino,float costo) :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return costo;
            }
        }
        public new string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("{0}. ", base.Mostrar());
            mystringBuilder.AppendFormat("{0}. ", this.CostoLlamada);

            return mystringBuilder.ToString();
        }
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

    }
}
