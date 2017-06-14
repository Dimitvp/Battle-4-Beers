using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class MaceSwing
    {
        internal CurrentSpell GetMaceSwing(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "MACE SWING";
            spell.Damage = warrior.WarriorDamage * 1.5;

            return spell;
        }
    }
}
