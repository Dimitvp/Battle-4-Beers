using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class BladeSlash
    {
        internal CurrentSpell GetSlash(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "BLADE SLASH";
            spell.Damage = warrior.WarriorDamage * 2;

            return spell;
        }
    }
}
