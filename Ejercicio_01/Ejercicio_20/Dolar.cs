using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDoloar;

        private Dolar()
        {
            Dolar.cotizRespectoDoloar = 1F;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;   
        }

        public Dolar(double cantidad,float cotizacion) :this(cantidad)
        {
            Dolar.cotizRespectoDoloar = cotizacion;
        }

        public Double Getcantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDoloar;
        }
        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.Getcantidad() / Euro.GetCotizacion());
            return euro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos peso = new Pesos(d.Getcantidad() * Pesos.GetCotizacion());
            return peso;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
    }
}
