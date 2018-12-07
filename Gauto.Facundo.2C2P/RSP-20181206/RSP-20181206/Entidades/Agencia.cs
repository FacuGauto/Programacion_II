using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoMensaje(string mensaje);
    public class Agencia
    {
        private string nombre;
        private List<Pasaje> pasajesVendidos;
        public event DelegadoMensaje informar;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Pasaje> PasajesVendidos { get => pasajesVendidos; set => pasajesVendidos = value; }

        private Agencia()
        {
            pasajesVendidos = new List<Pasaje>();
        }

        public Agencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Agencia a, Pasaje p)
        {
            foreach (Pasaje pasaje in a.PasajesVendidos)
            {
                if(pasaje == p)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Agencia a, Pasaje p)
        {
            return !(a == p);
        }

        public static Agencia operator +(Agencia a, Pasaje p)
        {
            if (a != p)
            {
                a.PasajesVendidos.Add(p);
                a.informar.Invoke("Pasaje emitido correctamente");
            }
            else
            {
                a.informar.Invoke("El pasaje ya fue emitido");
            }
            return a;
        }

        public float CalcularGanancia()
        {
            float total = 0;
            foreach (Pasaje p in this.PasajesVendidos)
            {
                total += p.PrecioFinal;
            }
            return total;
        }

        public static explicit operator string(Agencia a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Agencia: " + a.Nombre);
            sb.AppendLine("Pasajes vendidos:");
            foreach (Pasaje p in a.PasajesVendidos)
            {
                sb.AppendLine(p.Mostrar());
            }
            sb.AppendLine("Ganancia: " + a.CalcularGanancia());

            return sb.ToString();
        }
    }
}
