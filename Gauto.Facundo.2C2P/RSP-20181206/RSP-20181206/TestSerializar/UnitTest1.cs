using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestSerializar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Serializar()
        {
            Agencia agencia = new Agencia("Agencia");
            Agencia agencia2 = new Agencia("Agencia2");
            Xml<Agencia> xml = new Xml<Agencia>();
            xml.Guardar("Agencia.xml", agencia);

            agencia2 = xml.Leer("Agencia.xml");

            Assert.AreEqual(agencia.Nombre,agencia2.Nombre);
        }
    }
}
