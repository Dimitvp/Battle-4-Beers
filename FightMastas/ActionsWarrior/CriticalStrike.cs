using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class CriticalStrike
    {
        internal CurrentSpell TurnOnCrit(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "critical";

            return spell;   
        }
    }
}
