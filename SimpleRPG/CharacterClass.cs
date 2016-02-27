using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    abstract class CharacterClass
    {
        public string Name
        {
            get; set;
        }

        public abstract string ClassType
        {
            get;
        }

        private int strength = 50;
        public int Strength
        {
            get { return strength; }
            set { if (value >= 10 && value <= 100) strength = value;}
        }
        private int intelligence = 50;

        public int Intelligence
        {
            get { return intelligence; }
            set { if (value >= 10 && value <= 100) intelligence = value;}
        }

        private int charisma = 50;
        public int Charisma
        {
            get { return charisma; }
            set { if (value >= 10 && value <= 100) charisma = value;}
        }


        public override string ToString()
        {
            return Name + Environment.NewLine +
                    ClassType + Environment.NewLine +
                    "Strength : " + Strength + Environment.NewLine +
                    "Intelligence : " + Intelligence + Environment.NewLine +
                    "Charisma : " + Charisma + Environment.NewLine;        
        }


    }
}
