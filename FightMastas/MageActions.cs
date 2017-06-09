using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    class MageActions
    {
        public class FireBlast
        {
            public static decimal Damage = (decimal)1.2 * MageStats.MageSpellPower;

            public static int ManaRequired = 60;

            public static int Cooldown = 2;
        }

        public class PyroBlast
        {
            public static decimal Damage = (decimal)2.1 * MageStats.MageSpellPower;

            public static int ManaRequired = 150;

            public int Cooldown = 4;
        }

        public class Rejuvenate
        {
            public static decimal Healing = 3 * MageStats.MageSpellPower;

            public static int ManaRequired = 120;

            public int Cooldown = 5;
        }

        public class FrostArmor
        {
            public static decimal Armor = MageStats.MageSpellPower;

            public static int ManaRequired = 40;

            public int Cooldown = 1;
        }

        public class SpellpowerAmplifier
        {
            public static decimal Amplifier = 1.5m;

            public static int ManaRequired = 100;

            public int Duration = 3;

            public int Cooldown = 3;
        }

        public class Polymorph
        {
            public static int Duration = 2;

            public static int ManaRequired = 100;

            public int Cooldown = 4;
        }



        
    }
}
