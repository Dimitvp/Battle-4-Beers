using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    class FrostArmor
    {
        internal CurrentSpell GetFrostArmor(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "frostarmor";
            spell.GetArmor = 150;
            spell.FrostArmor = true;
            spell.Duration = 2;
            spell.Cooldown = 3;
            spell.ManaCost = 100;

            return spell;
        }
    }
}
