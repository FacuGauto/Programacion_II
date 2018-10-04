using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    class Centralita
    {
        protected string razonSocial;
        List<Llamada> listaDeLlamadas;

        public Centralita()
        {
            List<Llamada> listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        /*public float GananciasPorLocal
        {
            get
            {
                return;
            }
        }*/

        private float CalcularGanacia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                       // if (listaDeLlamadas[i] is Local)
                            //Local auxlocal = new Local();
                        //retorno += Local.
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        break;
                    case Llamada.TipoLlamada.Todas:
                        break;
                    default:
                        break;
                }
            }
            return retorno;
        }
    }
}
