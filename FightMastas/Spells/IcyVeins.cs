using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    class IcyVeins
    {
        internal CurrentSpell GetIcyVeins(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "icyveins";
            spell.Cooldown = 4;
            spell.AmplifyRatio = 1.5;
            spell.Duration = 3;
            spell.ManaCost = 250;

            return spell;
        }
    }
}
