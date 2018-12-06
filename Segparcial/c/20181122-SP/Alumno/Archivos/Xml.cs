using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {
        public void Guardar(string archivo,T datos)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                writer = new XmlTextWriter(string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo), Encoding.UTF8);
                serializer.Serialize(writer, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(writer is null))
                    writer.Close();
            }
        }
        public void Leer(string archivo, out T datos)
        {
            XmlTextReader stream = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                stream = new XmlTextReader(string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo));
                datos = (T)serializer.Deserialize(stream);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(stream is null))
                    stream.Close();
            }
        }
    }
}
