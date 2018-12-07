using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeAvion : Pasaje
    {
        int cantidadEscalas;

        /*public PasajeAvion()
        { }*/

        public PasajeAvion(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha,int cantidadEscalas) : base(origen,destino,pasajero,precio,fecha)
        {
            this.cantidadEscalas = cantidadEscalas;
        }

        public override float PrecioFinal
        {
            get
            {
                if (this.cantidadEscalas == 1)
                {
                    return this.Precio - ((Precio * 10) / 100);
                }
                else if (this.cantidadEscalas == 2)
                {
                    return this.Precio - ((Precio * 20) / 100);
                }
                else if (this.cantidadEscalas > 2)
                {
                    return this.Precio - ((Precio * 30) / 100);
                }
                else { return this.Precio; }
            }
        }

        public override string Mostrar()
        {
            StringBuilder mystringBuilder = new StringBuilder();
            mystringBuilder.AppendFormat("{0}{1}", base.Mostrar(), this.cantidadEscalas);
            return mystringBuilder.ToString();
        }
    }
}
