using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        public ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public void SetTinta(short tinta)
        {
            if (tinta > 0 && (this.tinta + tinta)<cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
            if (tinta<0 && (this.tinta - tinta) >= 0)
            {
                this.tinta += tinta;
            }
        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
        public Pintar(int tintaAPintar, out String gasto)
        {
            if (this.tinta>0 &&tintaAPintar>0)
            {
                while(this.tinta>0 && tintaAPintar>0)
                {
                    tintaAPintar--;
                    this.tinta--;
                    gasto += "*";
                }
            }
        }
    }
}
