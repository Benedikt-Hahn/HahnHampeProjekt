using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class Stern : Objekt
    {
        private Art art;
        private float helligkeit;

        public Stern(Art art, float helligkeit, int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte) :base(position, durchmesser, masse, alter, umlaufObjekte)
        {
            Art = art;
            Helligkeit = helligkeit;
            base.Position = position;
            base.Durchmesser = durchmesser;
            base.Masse = masse;
            base.Alter = alter;
            base.UmlaufObjekte = umlaufObjekte;
            
        }

     

        public float Helligkeit
        {
            get
            {
                return helligkeit;
            }

            set
            {
                helligkeit = value;
            }
        }

        internal Art Art
        {
            get
            {
                return art;
            }

            set
            {
                art = value;
            }
        }
    }
}
