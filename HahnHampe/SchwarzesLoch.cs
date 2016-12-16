using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class SchwarzesLoch : Objekt
    {
        private float sonnenmassen;
        public SchwarzesLoch(float sonnenmassen, int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte) : base(position, durchmesser, masse, alter, umlaufObjekte)
        {
            Sonnenmassen = sonnenmassen;
            base.Position = position;
            base.Durchmesser = durchmesser;
            base.Masse = masse;
            base.Alter = alter;
            base.UmlaufObjekte = umlaufObjekte;
        }

        public float Sonnenmassen
        {
            get
            {
                return sonnenmassen;
            }

            set
            {
                sonnenmassen = value;
            }
        }
    }
}
