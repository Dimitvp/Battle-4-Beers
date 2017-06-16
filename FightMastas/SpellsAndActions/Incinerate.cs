using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class Incinerate
    {
        internal CurrentSpell Incineration(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Execution = true;

            return spell;
        }
    }
}
