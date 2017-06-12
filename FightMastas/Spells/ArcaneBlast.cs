using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    public class ArcaneBlast
    {
        public CurrentSpell GetArcaneBlast(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "arcaneblast";
            spell.Damage = mage.MageSpellPower * 3;
            spell.ManaCost = 90;
            return spell;
        }
    }
}
