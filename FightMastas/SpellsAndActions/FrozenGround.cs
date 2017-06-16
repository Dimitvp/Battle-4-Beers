using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class FrozenGround
    {
        internal CurrentSpell GetFrozenGround(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "frozenground";
            spell.Damage = mage.Spellpower;
            spell.ManaCost = 150;
            spell.Cooldown = 4;

            return spell;
        }
    }
}
