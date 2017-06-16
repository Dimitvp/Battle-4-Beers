using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    public class ArcaneBlast
    {
        public CurrentSpell GetArcaneBlast(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "ARCANE BLAST";
            spell.Damage = mage.Spellpower * 3;
            spell.ManaCost = 90;
            return spell;
        }
    }
}
