using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public static class WarriorActions
    {

        public class AxeSwing
        {
            public static decimal Damage = WarriorStats.WarriorDamage;

            public static int Cooldown = 1;
        }

        public class SwordSwing
        {
            public static decimal Damage = WarriorStats.WarriorDamage;

            public static int Cooldown = 1;
        }

        public class DoubleAxeSwing
        {
            public static decimal Damage = 1.8m * WarriorStats.WarriorDamage;

            public static int Cooldown = 2;
        }

        public class DoubleSwordSwing
        {
            public static decimal Damage = 2*WarriorStats.WarriorDamage;

            public static int Cooldown = 2;
        }

        public class Execution
        {
            public bool ExectuionOpen = MageStats.MageHealth <= 300 || WarriorStats.WarriorHealth <= WarriorStats.WarriorHealth * 0.2m;
        }

        public class BladeStorm
        {
            public static decimal Damage = 3 * WarriorStats.WarriorDamage;

            public static int Cooldown = 3;
        }


        public class ShieldSlam
        {
            public static decimal Damage = WarriorStats.WarriorDamage / 2;

            public static int Cooldown = 1;
        }

        public class ArmorUp
        {
            public static decimal Armor = 10 * WarriorStats.WarriorSpellPower;

            public int Cooldown = 1;
        }

        public class Berserk
        {
            public static decimal Ratio = 2;

            public static int HealthRequired = 100;

            public int Duration = 3;

            public int Cooldown = 3;
        }
    }
}
