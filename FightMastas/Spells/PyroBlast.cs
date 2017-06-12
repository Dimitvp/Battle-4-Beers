using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.Spells
{
    public class PyroBlast
    {
        public CurrentSpell GetPyroBlast(Mage mage)
        {
            var currentSpell = new CurrentSpell();

            currentSpell.Name = "pyroblast";
            currentSpell.Damage = mage.MageSpellPower * 5;
            currentSpell.Cooldown = 4;
            currentSpell.ManaCost = 250;

            return currentSpell;
        }
    }
}
