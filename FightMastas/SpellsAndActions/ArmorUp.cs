using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    class ArmorUp
    {
        public CurrentSpell GetArmorUp(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "armorup";
            spell.GetArmor = 200;

            return spell;
        }
    }
}
