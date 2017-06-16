using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    public class FireBlast
    {
        public CurrentSpell GetFireBlast(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "FIRE BLAST";
            spell.Damage = mage.Spellpower * 2;
            spell.ManaCost = 120;

            return spell;
        }
    }
}
