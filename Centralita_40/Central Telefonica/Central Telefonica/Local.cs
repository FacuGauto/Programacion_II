using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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

        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        protected override string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("LLamada Local: \n{0}", base.Mostrar());
            mystringBuilder.AppendFormat("\tEl costo de la llamada es: {0}. ", this.CostoLLamada);

            return mystringBuilder.ToString();
        }
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override bool Equals(object obj)
        {
            if(obj is Local)
            return true;

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
