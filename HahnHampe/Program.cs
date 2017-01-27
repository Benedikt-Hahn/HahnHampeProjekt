using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HahnHampe
{
    class Program
    {
        static void Main(string[] args)
        {
            Abfrage1();
            Abfrage2();
            Abfrage3();
            Abfrage4();
            Abfrage5();
        }


        public static void Abfrage1()
        {
            // 1) Welcher Planet hat die meisten Monde?
            var xmlFile = XElement.Load("../../Daten.xml");
            Console.WriteLine("------------ 1 ----------");
            var erg = from a in xmlFile.Descendants("Planet")
                      where a.Elements("Mond").Count() > 4
                      select a.Element("Name");

            Console.WriteLine("Welcher Planet hat die meisten Monde?");
            foreach (var item in erg)
            {
                Console.WriteLine(item);
            }
        }
        public static void Abfrage2()
        {
            // 2) Welcher Stern hat einen Radius größer als 800000?
            var xmlFile = XElement.Load("../../Daten.xml");
            Console.WriteLine("------------ 2 ----------");
            var erg = from a in xmlFile.Descendants("Stern")
                      where Convert.ToInt32(a.Element("Radius").Value) > 800000
                      select a.Element("Name");

            Console.WriteLine("Welcher Stern hat einen Radius größer als 800.000?");
            foreach (var item in erg)
            {
                Console.WriteLine(item);
            }
        }
        public static void Abfrage3()
        {
            // 3)	Wieviel Objekte sind in den Galaxien?
            var xmlFile = XElement.Load("../../Daten.xml");
            Console.WriteLine("------------ 3 ----------");
            var erg = from a in xmlFile.Descendants("Galaxie")
                      select new
                      {
                          b = a.Elements("System").Elements("Planet").Count()
                      };
            Console.WriteLine("Wieviel Objekte sind in den Galaxien?");
            foreach (var item in erg)
            {
                Console.WriteLine(item.b);
            }
        }
        public static void Abfrage4()
        {
            // 4) Gruppiere Sterne nach Alter
            var xmlFile = XElement.Load("../../Daten.xml");
            Console.WriteLine("------------ 4 ----------");
            var erg = from a in xmlFile.Descendants("Stern")
                      group a by a.Element("Alter").Value into res
                      orderby res.Key
                      select new
                      {
                          name = from b in res
                                 select b.Element("Name"),
                          alter = res.Key

                      };


            Console.WriteLine("Gruppiere Sterne nach Alter");
            foreach (var item in erg)
            {
                Console.WriteLine("Alter :" + item.alter);
                foreach (var item2 in item.name)
                {
                    Console.WriteLine("\t" + item2);
                }
            }
        }

        public static void Abfrage5()
        {
            // 5) Welche Planeten sind bewohnbar?
            var xmlFile = XElement.Load("../../Daten2xml.xml");
            Console.WriteLine("------------ 5 ----------");
            var erg = from a in xmlFile.Descendants("System")
                      where a.Element("Planet").Element("Bewohnbar").Value.Equals("true")
                      select new
                      {
                          name = a.Element("Planet").Element("Name").Value,
                          bewohnbar = a.Element("Planet").Element("Bewohnbar").Value,
                          stern = a.Element("Stern").Element("Name").Value
                      };


            Console.WriteLine("Welche Planeten sind bewohnbar?");

            foreach (var item in erg)
            {
                Console.WriteLine("Name: " + item.name + "\t Bewohnbar: " + item.bewohnbar + "\t Stern: " + item.name);
            }

        }
    }
}


