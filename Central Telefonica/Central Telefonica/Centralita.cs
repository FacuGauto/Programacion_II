using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Centralita
    {
        protected string razonSocial;
        public List<Llamada> listaDeLlamadas;

        public Centralita()
        {
           this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanacia(Llamada.TipoLlamada.Local);
            }
        }

        public float GanaciasPorProvincial
        {
            get
            {
                return CalcularGanacia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GanaciasPorTotal
        {
            get
            {
                return CalcularGanacia(Llamada.TipoLlamada.Todas);
            }
        }

        private float CalcularGanacia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            
            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                if ((tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas) && listaDeLlamadas[i] is Local)
                {
                    Local aux = (Local)listaDeLlamadas[i];
                    retorno += aux.CostoLlamada; 
                }
                if ((tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas) && listaDeLlamadas[i] is Provincial)
                {
                    Provincial aux = (Provincial)listaDeLlamadas[i];
                    retorno += aux.CostoLlamada;
                }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("Razon Social:{0}, Ganacia Local:{1}, Ganacia Provincial:{2}, Ganancia Total: {3}", this.razonSocial,this.GananciasPorLocal,this.GanaciasPorProvincial,this.GanaciasPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    Local aux = (Local)llamada;
                    aux.Mostrar();
                }
                if (llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    aux.Mostrar();
                }
            }

            return mystringBuilder.ToString();
        }

        public void ordenarLlamada()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
