using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    public class Windfury
    {
        internal CurrentSpell GetWindFury(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "WINDFURY";
            spell.Damage = warrior.Damage * 5;
            spell.Cooldown = 4;

            return spell;
        }
    }
}
