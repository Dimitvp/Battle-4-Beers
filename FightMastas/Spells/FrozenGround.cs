using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    class FrozenGround
    {
        internal CurrentSpell GetFrozenGround(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "frozenground";
            spell.Duration = 2;
            spell.Damage = mage.MageSpellPower;

            return spell;
        }
    }
}
