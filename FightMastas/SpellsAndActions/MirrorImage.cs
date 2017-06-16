using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class MirrorImage
    {
        internal CurrentSpell GetMirrorImage(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "mirrorimage";
            spell.Damage = warrior.Damage;
            spell.Cooldown = 3;

            return spell;
        }
    }
}
