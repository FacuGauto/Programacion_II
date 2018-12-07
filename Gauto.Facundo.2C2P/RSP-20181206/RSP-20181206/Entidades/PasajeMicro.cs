using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeMicro: Pasaje
    {
        Servicio tipoServicio;

        /*public PasajeMicro()
        { }*/

        public PasajeMicro(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha, Servicio tipoServicio) :base(origen, destino, pasajero, precio, fecha)
        {
            this.tipoServicio = tipoServicio;
        }

        public override float PrecioFinal
        {
            get
            {
                float precioFinal;
                switch (this.tipoServicio)
                {
                    case Servicio.Comun:
                        precioFinal = this.Precio;
                        break;
                    case Servicio.SemiCama:
                        precioFinal = this.Precio + ((Precio * 10) / 100);
                        break;
                    case Servicio.Ejecutivo:
                        precioFinal = this.Precio + ((Precio * 20) / 100);
                        break;
                    default:
                        precioFinal = this.Precio;
                        break;
                }
                return precioFinal;
            }
        }

        public override string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("{0}{1}", base.Mostrar(), this.tipoServicio);
            return mystringBuilder.ToString();
        }
    }
}
