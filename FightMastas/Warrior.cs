using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class Warrior
    {
        public  string PlayerName;

        public string Type;

        public int WarriorDamage = 50;

        public int WarriorHealth = 620;

        public int WarriorArmor = 100;

        public int WarriorHealthRegen = 30;

        public int WarriorManaRegen = 5;
        public int ShieldArmor = 80;
        public int ShieldSlamCooldown = 2;
        public bool ShieldSlamIsCD = false;
        public int WindFuryCooldown = 4;
        public bool WindFuryIsCd = false;
        public int DoubleAttackCooldown = 2;
        public bool DoubleAttackIsCD = false;
        public int BerserkModeCooldown = 5;
        public bool BerserkModeIsCD = false;
        public int ArmorUpCooldown = 2;
        public bool ArmorUpIsCD = false;




    }
}
