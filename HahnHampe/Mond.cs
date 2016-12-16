using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class Mond : Objekt
    {
        public Mond(int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte) : base(position, durchmesser, masse, alter, umlaufObjekte)
        {
            base.Position = position;
            base.Durchmesser = durchmesser;
            base.Masse = masse;
            base.Alter = alter;
            base.UmlaufObjekte = umlaufObjekte;
        }
    }
}
