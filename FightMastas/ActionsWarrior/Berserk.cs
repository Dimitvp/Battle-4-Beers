using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class Berserk
    {
        internal CurrentSpell GoBerserk(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "berserk";
            spell.SacrificialHP = 200;
            spell.AmplifyRatio = 2;
            spell.Cooldown = 5;
            spell.Duration = 3;

            return spell;
        }
    }
}
