using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Wizard : CharacterClass
    {
        public override string ClassType
        {
            get
            {
                return "Wizard";
            }          
        }
        public Wizard()
        {
            this.Strength -= 15;
            this.Charisma += 5;
            this.Intelligence += 10;
        }
    }
}
