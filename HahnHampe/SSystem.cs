using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class SSystem : Objekt
    {
        private List<Objekt> objekte;

        internal List<Objekt> Objekte
        {
            get
            {
                return objekte;
            }

            set
            {
                objekte = value;
            }
        }
        public SSystem(List<Objekt> objekte, int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte) : base(position, durchmesser, masse, alter, umlaufObjekte)
        {
            Objekte = objekte;
            base.Position = position;
            base.Durchmesser = durchmesser;
            base.Masse = masse;
            base.Alter = alter;
            base.UmlaufObjekte = umlaufObjekte;
        }
    }
}
