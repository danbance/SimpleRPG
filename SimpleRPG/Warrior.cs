using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Warrior : CharacterClass
    {
        public override string ClassType
        {
            get
            {
                return "Warrior";
            }           
        }

        public Warrior()
        {
            this.Strength += 15;
            this.Intelligence -= 10;
            this.Charisma -= 5;
        }
    }
}
