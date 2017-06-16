using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class Berserk
    {
        internal CurrentSpell GoBerserk(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "berserk";
            spell.SacrificialHP = 200;
            spell.Cooldown = 5;
            spell.Duration = 3;
            spell.Amplifier = 2;

            return spell;
        }
    }
}
