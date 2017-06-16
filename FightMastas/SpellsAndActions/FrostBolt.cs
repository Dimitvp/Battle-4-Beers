using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class FrostBolt
    {
        internal CurrentSpell GetFrostBolt(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "FROST BOLT";
            spell.FrostArmor = true;
            spell.Damage = mage.Spellpower * 2;
            spell.ManaCost = 150;

            return spell;
        }
    }
}
