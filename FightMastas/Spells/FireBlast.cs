using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    public class FireBlast
    {
        public CurrentSpell GetFireBlast(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "FIRE BLAST";
            spell.Damage = mage.MageSpellPower * 2;
            spell.ManaCost = 120;

            return spell;
        }
    }
}
