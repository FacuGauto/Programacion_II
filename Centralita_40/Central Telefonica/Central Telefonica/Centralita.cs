using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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
                    retorno += aux.CostoLLamada; 
                }
                if ((tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas) && listaDeLlamadas[i] is Provincial)
                {
                    Provincial aux = (Provincial)listaDeLlamadas[i];
                    retorno += aux.CostoLLamada;
                }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("\nRazon Social: {0}.\nGanacia Local: {1}, Ganacia Provincial: {2}.\nGanancia Total: {3}\n\n", this.razonSocial,this.GananciasPorLocal,this.GanaciasPorProvincial,this.GanaciasPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    Local aux = (Local)llamada;
                    mystringBuilder.AppendLine(aux.ToString());
                }
                else if (llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    mystringBuilder.AppendLine(aux.ToString());
                }
                mystringBuilder.AppendLine("");
            }
            return mystringBuilder.ToString();
        }

        public void ordenarLlamada()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar(); 
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c,Llamada nuevallamada)
        {
            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == nuevallamada)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada nuevallamada)
        {
            return !(c == nuevallamada);
        }
        public static Centralita operator +(Centralita c,Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
                c.AgregarLlamada(nuevaLlamada);

            return c;
        }
    }
}
