using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    public class Windfury
    {
        internal CurrentSpell GetWindFury(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "windfury";
            spell.Damage = warrior.WarriorDamage * 5;
            spell.Cooldown = 4;

            return spell;
        }
    }
}
