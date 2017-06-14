using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B4B;

namespace FightMastas
{
    class PrintCharacterStats
    {
        internal static void PrintWM(Mage mage, Warrior warr)
        {
            Console.WriteLine("ARMOR, HEALTH AND MANA OF BOTH CHARACTERS:");
            Console.WriteLine($"{warr.PlayerName} HEALTH: {warr.WarriorHealth} + {warr.WarriorHealthRegen}       {mage.PlayerName} HEALTH: {mage.MageHealth} + {mage.MageHealthRegen}");
            Console.WriteLine($"{warr.PlayerName} ARMOR: {warr.WarriorArmor}        {mage.PlayerName} ARMOR: {mage.Armor}");
            Console.WriteLine($"{warr.PlayerName} MANA: 0        {mage.PlayerName} MANA: {mage.MageMana} + {mage.MageManaRegen}");
            Console.WriteLine("PRESS ENTER TO CONTINUE TO NEXT TURN........");
        }

        public static void PrintMW(Mage mage, Warrior warr)
        {
            Console.WriteLine("ARMOR, HEALTH AND MANA OF BOTH CHARACTERS:");
            Console.WriteLine($"{mage.PlayerName} HEALTH: {mage.MageHealth} + {mage.MageHealthRegen}        {warr.PlayerName} HEALTH: {warr.WarriorHealth} + {warr.WarriorHealthRegen}");
            Console.WriteLine($"{mage.PlayerName} ARMOR: {mage.Armor}        {warr.PlayerName} ARMOR: {warr.WarriorArmor}");
            Console.WriteLine($"{mage.PlayerName} MANA: {mage.MageMana} + {mage.MageManaRegen}       {warr.PlayerName} MANA: 0");
            Console.WriteLine("PRESS ENTER TO CONTINUE TO NEXT TURN........");
        }

        public static void PrintWW(Warrior first, Warrior second)
        {
            Console.WriteLine("ARMOR, HEALTH AND MANA OF BOTH CHARACTERS:");
            Console.WriteLine($"{first.PlayerName} HEALTH: {first.WarriorHealth} + {first.WarriorHealthRegen}        {second.PlayerName} HEALTH: {second.WarriorHealth} + {second.WarriorHealthRegen}");
            Console.WriteLine($"{first.PlayerName} ARMOR: {first.WarriorArmor}        {second.PlayerName} ARMOR: {second.WarriorArmor}");
            Console.WriteLine($"{first.PlayerName} MANA: 0        {second.PlayerName} MANA: 0");
            Console.WriteLine("PRESS ENTER TO CONTINUE TO NEXT TURN........");
        }

        public static void PrintMM(Mage first, Mage second)
        {
            Console.WriteLine("ARMOR, HEALTH AND MANA OF BOTH CHARACTERS:");
            Console.WriteLine($"{first.PlayerName} HEALTH: {first.MageHealth} + {first.MageHealthRegen}       {second.PlayerName} HEALTH: + {second.MageHealthRegen}");
            Console.WriteLine($"{first.PlayerName} ARMOR: {first.Armor}        {second.PlayerName} ARMOR: {second.Armor}");
            Console.WriteLine($"{first.PlayerName} MANA: {first.MageMana} + {first.MageManaRegen}        {second.PlayerName} MANA: {second.MageMana} + {second.MageManaRegen}  ");
            Console.WriteLine("PRESS ENTER TO CONTINUE TO NEXT TURN........");
        }
    }
}
