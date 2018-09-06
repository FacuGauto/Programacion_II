using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private int capacidad;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: " + e.capacidad);
            foreach (Producto p in e.productos)
            {
                if ((((Object)p) != null))
                {
                    sb.AppendLine(p.MostrarProducto(p));
                }
            }

            return sb.ToString();
        }
        public static bool operator ==(Estante e,Producto p)
        {
            Producto aux = new Producto();
            for (int i = 0; i < e.capacidad; i++)
            {
                aux = e.productos[i];
                if (aux==p)
                {
                    return true;
                }
            }
            if()
        }
    }
}
