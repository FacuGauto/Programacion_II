using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDoloar;

        private Pesos()
        {
            Pesos.cotizRespectoDoloar = 17.55F;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(Double cantidad, float cotizacion) :this(cantidad)
        {
            Pesos.cotizRespectoDoloar = cotizacion;
        }

        public Double Getcantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDoloar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.Getcantidad() / Pesos.GetCotizacion());
            return dolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro euro = new Euro(p.Getcantidad() / Pesos.GetCotizacion() * Euro.GetCotizacion());
            return euro;
        }
    }
}
