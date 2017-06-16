using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class WildAxes
    {
        internal CurrentSpell GetWildAxes(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "WILD AXES";
            spell.Damage = warrior.Damage * 4;
            spell.Cooldown = 3;

            return spell;
        }
    }
}
