﻿using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    public class ManaRegeneration
    {
        public CurrentSpell GetManaReg(Player mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "manaregeneration";
            spell.GetMana = 300;
            spell.Cooldown = 3;

            return spell;
        }
    }
}
