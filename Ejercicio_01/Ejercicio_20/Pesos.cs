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
            Pesos.cotizRespectoDoloar = 0.5698F;
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

    }
}
