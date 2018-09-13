using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDoloar;

        private Euro()
        {
            Euro.cotizRespectoDoloar = 1.3642F;
        }

        public Euro(Double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(Double cantidad, float cotizacion) :this(cantidad)
        {
            Euro.cotizRespectoDoloar = cotizacion;
        }

        public Double Getcantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDoloar;
        }
        public static explicit operator Dolar(Euro p)
        {
            Dolar dolar = new Dolar(p.Getcantidad() * Euro.GetCotizacion());
            return dolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos peso = new Pesos(e.Getcantidad() * Euro.GetCotizacion() * Pesos.GetCotizacion());
            return peso;
        }
    }
}
