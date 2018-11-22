using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml: IArchivo<T>
    {
        public void Guardar(string archivo,T datos)
        {

        }
        public void Leer(string archivo, out T datos)
        { }
    }
}
