using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class AxeChop
    {
        internal CurrentSpell GetHit(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "chop";
            spell.Damage = warrior.WarriorDamage;

            return spell;
        }
    }
}
