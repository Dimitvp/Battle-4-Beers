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
        internal static void Print(Player mage, Player warr)
        {
            Console.WriteLine("ARMOR, HEALTH AND MANA OF BOTH CHARACTERS:");
            Console.WriteLine($"{warr.Name} HEALTH: {warr.Health} + {warr.HealthRegen}       {mage.Name} HEALTH: {mage.Health} + {mage.HealthRegen}");
            Console.WriteLine($"{warr.Name} ARMOR: {warr.Armor}        {mage.Name} ARMOR: {mage.Armor}");
            Console.WriteLine($"{warr.Name} MANA: {warr.Mana} + {warr.ManaRegen}       {mage.Name} MANA: {mage.Mana} + {mage.ManaRegen}");
            Console.WriteLine("PRESS ENTER TO CONTINUE TO NEXT TURN........");
        }
    }
}
