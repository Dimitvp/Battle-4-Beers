using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.SpellsAndActions
{
    public class PyroBlast
    {
        public CurrentSpell GetPyroBlast(Player mage)
        {
            var currentSpell = new CurrentSpell();

            currentSpell.Name = "PYRO BLAST";
            currentSpell.Damage = mage.Spellpower * 5;
            currentSpell.Cooldown = 4;
            currentSpell.ManaCost = 250;

            return currentSpell;
        }
    }
}
