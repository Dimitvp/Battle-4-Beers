using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    class FrostBolt
    {
        internal CurrentSpell GetFrostBolt(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "FROST BOLT";
            spell.FrostArmor = true;
            spell.Damage = mage.MageSpellPower * 2;
            spell.ManaCost = 150;

            return spell;
        }
    }
}
