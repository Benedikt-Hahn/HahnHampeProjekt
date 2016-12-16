using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahnHampe
{
    abstract class Objekt
    {
        private int[] position;
        private float durchmesser;
        private float masse;
        private int alter;
        private Objekt[] umlaufObjekte;

        protected int[] Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        protected float Durchmesser
        {
            get
            {
                return durchmesser;
            }

            set
            {
                durchmesser = value;
            }
        }

        protected float Masse
        {
            get
            {
                return masse;
            }

            set
            {
                masse = value;
            }
        }

        protected int Alter
        {
            get
            {
                return alter;
            }

            set
            {
                alter = value;
            }
        }

        protected Objekt[] UmlaufObjekte
        {
            get
            {
                return umlaufObjekte;
            }

            set
            {
                umlaufObjekte = value;
            }
        }

        public Objekt()
        {

        }

        public Objekt(int[] position, float durchmesser, float masse, int alter, Objekt[] umlaufObjekte)
        {
            Position = position;
            Durchmesser = durchmesser;
            Masse = masse;
            Alter = alter;
            UmlaufObjekte = umlaufObjekte;
        }
    }
}
