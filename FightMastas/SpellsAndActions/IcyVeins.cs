using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class IcyVeins
    {
        internal CurrentSpell GetIcyVeins(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "icyveins";
            spell.Cooldown = 4;
            spell.Duration = 3;
            spell.ManaCost = 250;
            spell.Amplifier = 1.5;

            return spell;
        }
    }
}
