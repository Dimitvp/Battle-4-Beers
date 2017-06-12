using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    class FireArmor
    {
        internal CurrentSpell GetFireArmor(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "firearmor";
            spell.GetArmor = 100;
            spell.Damage = mage.MageSpellPower / 2;
            spell.Cooldown = 3;
            spell.Duration = 4;

            return spell;
        }
    }
}
