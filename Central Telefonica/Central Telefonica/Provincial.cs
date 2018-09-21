using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Provincial: Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja { Franja_1, Franja_2, Franja_3 };
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) :this(miFranja,new Llamada(duracion,destino,origen))
        {
        }
        public string Mostrar()
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0}", base.);
        }
        private float CalcularCosto()
        {
            return
        }
    }
    


}
