using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    class FireArmor
    {
        internal CurrentSpell GetFireArmor(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "firearmor";
            spell.GetArmor = 150;
            spell.GetHP = 150;
            spell.Damage = mage.Spellpower / 2;
            spell.Cooldown = 3;
            spell.ManaCost = 80;

            return spell;
        }
    }
}
