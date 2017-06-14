using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B.ActionsWarrior
{
    public class ShieldSlam
    {
        internal CurrentSpell GetShieldSlam(Warrior warrior)
        {
            var spell = new CurrentSpell();

            spell.Name = "SHIELD SLAM";
            spell.Damage = warrior.WarriorArmor;

            return spell;
        }
    }
}
