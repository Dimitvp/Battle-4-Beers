using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class FrostArmor
    {
        internal CurrentSpell GetFrostArmor(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "frostarmor";
            spell.GetArmor = 150;
            spell.FrostArmor = true;
            spell.Cooldown = 3;
            spell.ManaCost = 100;

            return spell;
        }
    }
}
