using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    public class Amplifier
    {
        public CurrentSpell GetAmplifier(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "amplifier";
            spell.AmplifyRatio = 2;
            spell.Cooldown = 4;
            spell.ManaCost = 250;

            return spell;
        }
    }
}
