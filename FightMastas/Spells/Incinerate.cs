using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    class Incinerate
    {
        internal CurrentSpell Incineration(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Execution = true;

            return spell;
        }
    }
}
