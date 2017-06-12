using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    public class Polymorph
    {
        public CurrentSpell GetPolymorph(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "polymorph";
            spell.DisableDuration = 1;
            spell.ManaCost = 100;
            spell.Cooldown = 3;
            return spell;
        }
    }
}
