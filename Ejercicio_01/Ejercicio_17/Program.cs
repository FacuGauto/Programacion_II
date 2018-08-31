using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo();
            Boligrafo boligrafoRojo = new Boligrafo();
            boligrafoAzul.SetTinta(100);
            boligrafoRojo.SetTinta(50);
            boligrafoAzul.color = ConsoleColor.Blue;
            boligrafoRojo.color = ConsoleColor.Red;

        }
    }
}
