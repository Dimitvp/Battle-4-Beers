using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class Warrior
    {
        //Warrior stats
        public string PlayerName;

        public string Type;

        public bool OnTurn { get; set; }

        public double WarriorDamage = 50;

        public int WarriorHealth = 1500;

        public int WarriorArmor { get; set; }

        public int WarriorHealthRegen = 70;

        public int ShieldArmor = 100;

        public bool DamageReduction = false;
        


        //Spells Cooldowns
        //Berserker spells
        public int WildAxesCooldown { get; set; }

        public int BerserkModeCooldown { get; set; }

        //Swordmaster spells
        public int MirrorImageCooldown { get; set; }

        public int WindFuryCooldown { get; set; }

        public bool CriticalStrike { get; set; }

        //Protector spells
        public int ArmorUpCooldown { get; set; }

        public int HibernateCooldown { get; set; }

        public bool ArmorEquipped { get; set; }
    }
}
