using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var xmlFile = XElement.Load("../../Daten.xml");
            var erg = from a in xmlFile.Descendants("Planet")
                      where a.Elements("Mond").Count() > 4
                      select a.Element("Name").Value;
            Assert.AreEqual(erg, "A5160");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var xmlFile = XElement.Load("../../Daten.xml");
            var erg = from a in xmlFile.Descendants("Planet")
                      select a;
            Assert.AreEqual(erg, "320");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var xmlFile = XElement.Load("../../Daten2xml.xml");
            var erg = from a in xmlFile.Descendants("Planet")
                      where a.Element("Bewohnbar").Value.Equals("true")
                      select a;
            Assert.AreEqual(erg, "124");
        }

        
    }
}
