using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class AxeChop
    {
        internal CurrentSpell GetHit(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "AXE CHOP";
            spell.Damage = 2* warrior.Damage;

            return spell;
        }
    }
}
