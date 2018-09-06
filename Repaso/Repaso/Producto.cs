using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigo,float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} {2}", p.codigoDeBarra, p.marca, p.precio);
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p,string marca)
        {
            if(p.marca == marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {   
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.codigoDeBarra == p2.codigoDeBarra)
            {
                if(p1.marca == p2.marca)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Producto p1,Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
