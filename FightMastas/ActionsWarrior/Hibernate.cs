using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class Hibernate
    {
        internal CurrentSpell GetHibernate(Warrior warrior)
        {
            var spell = new  CurrentSpell();

            spell.Name = "hibernate";
            spell.GetHP = warrior.WarriorHealthRegen * 3;
            spell.DamageReduction = 0.5;
            spell.Cooldown = 3;

            return spell;
        }
    }
}
