using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    public class FireBlast
    {
        public CurrentSpell GetFireBlast(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "fireblast";
            spell.Damage = mage.MageSpellPower * 2;
            spell.ManaCost = 120;

            return spell;
        }
    }
}
