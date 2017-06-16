using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    public class ShieldSlam
    {
        internal CurrentSpell GetShieldSlam(Player warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "SHIELD SLAM";
            spell.Damage = warrior.Armor;

            return spell;
        }
    }
}
