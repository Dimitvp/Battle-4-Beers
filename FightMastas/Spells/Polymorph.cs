﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.Spells
{
    public class Polymorph
    {
        public int Duration = 2;
        public int Cooldown = 4;

        public CurrentSpell GetPolymorph(Mage mage)
        {
            var spell = new CurrentSpell();

            spell.Name = "polymorph";
            spell.ManaCost = 100;
            spell.Cooldown = 4;
            
            return spell;
        }
    }
}
