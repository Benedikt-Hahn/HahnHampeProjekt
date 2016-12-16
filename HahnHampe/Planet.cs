using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    class Planet :Objekt
    {
        private Art art;
        private bool bewohnbar;

        public Planet(Art art, bool bewohnbar, int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte) :base(position, durchmesser, masse, alter, umlaufObjekte)
        {
            Art = art;
            Bewohnbar = bewohnbar;
            base.Position = position;
            base.Durchmesser = durchmesser;
            base.Masse = masse;
            base.Alter = alter;
            base.UmlaufObjekte = umlaufObjekte;
        }

        public Planet()
        {
            throw new System.NotImplementedException();
        }

        public bool Bewohnbar
        {
            get
            {
                return bewohnbar;
            }

            set
            {
                bewohnbar = value;
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
