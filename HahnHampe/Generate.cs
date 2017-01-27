using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class Generate
    {
        static Random rnd = new Random();
        static void Main2(string[] args)
        {
            string s = "";

            int rSysCount = rnd.Next(1, 10);
            int rPlaCount = rnd.Next(1, 5);
            int rPlaCount2 = rnd.Next(1, 5);
            int rMonCount = rnd.Next(1, 5);
            int rMonCount2 = rnd.Next(1, 5);
            s += "<Universe>";
            for (int i = 0; i < 5; i++)
            {
                s += "<Galaxie>";
                for (int j = 0; j < rSysCount; j++)
                {
                    s += "<System>";
                    s += genStern();
                    s += genPlanet(rPlaCount, rMonCount);
                    s += genPlanet(rPlaCount2, rMonCount2);
                    s += "</System>\n";
                }

                s += "</Galaxie>";
            }
            s += "</Universe>";
            Console.WriteLine(s);


        }

        public static string genPlanet(int count, int mondcount)
        {

            string s = "";
            for (int i = 0; i < count; i++)
            {
                int rMasse = rnd.Next(0, 1000000); // Erdmassen
                int rAlter = rnd.Next(1, 10); // Milliarden
                int rRadius = rnd.Next(1000, 1000000); // Kilometer
                int rArt = rnd.Next(1, 3);
                int rBew = rnd.Next(1, 3);

                s += "<Planet>\n \t";
                s += "<Name>";
                string n = genName();
                s += n;
                s += "</Name>\n \t";
                s += "<Alter>" + rAlter + "</Alter>\n \t";
                s += "<Masse>" + rMasse + "</Masse>\n \t";
                s += "<Radius>" + rRadius + "</Radius>\n \t";
                s += "<Art>";
                switch (rArt)
                {
                    case 1: s += "Gasplanet"; break;
                    case 2: s += "Gesteinsplanet"; break;
                    default: s += "Gesteinsplanet"; break;
                }
                s += "</Art>\n \t";
                s += "<Bewohnbar>";
                switch (rBew)
                {
                    case 1: s += "true"; break;
                    case 2: s += "false"; break;
                    default: s += "true"; break;
                }
                s += "</Bewohnbar>\n";
                for (int j = 0; j < mondcount; j++)
                {
                    s += genMond();
                }
                s += "</Planet>\n";
            }
            return s;
        }

        public static string genStern()
        {

            string s = "";
            int rMasse = rnd.Next(100000, 1000000); // Erdmassen
            int rAlter = rnd.Next(1, 20); // Milliarden
            int rRadius = rnd.Next(10000, 1000000); // Kilometer
            int rArt = rnd.Next(1, 3);

            s += "<Stern>\n \t";
            s += "\t<Name>";
            string n = genName();
            s += n;
            s += "</Name>\n \t";
            s += "<Alter>" + rAlter + "</Alter>\n \t";
            s += "<Masse>" + rMasse + "</Masse>\n \t";
            s += "<Radius>" + rRadius + "</Radius>\n \t";
            s += "<Art>";
            switch (rArt)
            {
                case 1: s += "Riese"; break;
                case 2: s += "Zwerg"; break;
                case 3: s += "Normal"; break;
                default: s += "Normal"; break;
            }
            s += "</Art>\n";
            s += "</Stern>\n";
            return s;
        }

        public static string genMond()
        {
            string s = "";
            int rMasse = rnd.Next(1, 10); // Erdmassen
            int rAlter = rnd.Next(1, 5); // Milliarden
            int rRadius = rnd.Next(1000, 10000); // Kilometer

            s += "\t<Mond>\n \t";
            s += "\t<Name>";
            string n = genName();
            s += n;
            s += "</Name>\n \t";
            s += "\t<Alter>" + rAlter + "</Alter>\n \t";
            s += "\t<Masse>" + rMasse + "</Masse>\n \t";
            s += "\t<Radius>" + rRadius + "</Radius>\n";
            s += "\t</Mond>\n";
            return s;
        }
        public static string genName()
        {
            char b = (char)rnd.Next(65, 91);
            //random buchstabe+int zb Z159,B28
            return b + "" + rnd.Next(0, 10001);

        }
    }
}
