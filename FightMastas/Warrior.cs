using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class Warrior
    {
        public string PlayerName;

        public string Type;

        public double WarriorDamage = 50;

        public int WarriorHealth = 1300;

        public int WarriorArmor { get; set; }

        public int WarriorHealthRegen = 70;

        public int ShieldArmor = 100;

        public int ShieldSlamCooldown { get; set; }
        public bool ShieldSlamIsCD  { get; set; }

        public int WindFuryCooldown { get; set; }
        public bool WindFuryIsCd { get; set; }

        public int DoubleAttackCooldown { get; set; }
        public bool DoubleAttackIsCD { get; set; }

        public int BerserkModeCooldown { get; set; }
        public bool BerserkModeIsCD { get; set; }

        public int ArmorUpCooldown { get; set; }
        public bool ArmorUpIsCD = false;




    }
}
