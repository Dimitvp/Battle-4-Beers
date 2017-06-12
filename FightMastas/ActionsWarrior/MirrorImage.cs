using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class MirrorImage
    {
        internal CurrentSpell GetMirrorImage(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "mirrorimage";
            spell.Damage = warrior.WarriorDamage;
            spell.Cooldown = 3;

            return spell;
        }
    }
}
