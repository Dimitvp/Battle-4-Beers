using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class Execute
    {
        internal CurrentSpell GetExecution(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Execution = true;

            return spell;
        }
    }
}
