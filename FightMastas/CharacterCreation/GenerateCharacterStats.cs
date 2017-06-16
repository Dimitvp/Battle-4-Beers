using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.CharacterCreation
{
    class GenerateCharacterStats
    {
        public static Player Mage(Player mage)
        {
            mage.Spellpower = 100;
            mage.Mana = 2500;
            mage.Health = 2200;
            mage.ManaRegen = 100;
            mage.HealthRegen = 60;

            return mage;
        }

        public static Player Warrior(Player warrior)
        {
            warrior.Health = 2800;
            warrior.Damage = 80;
            warrior.HealthRegen = 90;

            return warrior;
        }
    }
}
