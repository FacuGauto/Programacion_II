using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public enum Franja { Franja_1, Franja_2, Franja_3 };
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(duracion,destino,origen)
        {
        }
        protected override string Mostrar()
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0}", base.Mostrar());
            myStringBuilder.AppendFormat("El costo de la llamada es:{0} .", this.CostoLlamada);
            myStringBuilder.AppendFormat("La franja horaria es:{0} .", this.franjaHoraria);

            return myStringBuilder.ToString();
        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99F;
                    break;
                case Franja.Franja_2:
                    costo = 1.25F;
                    break;
                case Franja.Franja_3:
                    costo = 0.66F;
                    break;
            }
            return base.Duracion * costo;
        }
        public override bool Equals(object obj)
        {
            if(obj is Provincial)
            return true;

            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
