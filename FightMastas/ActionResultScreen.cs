using FightMastas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class ActionResultScreen
    {
        public static void GoToActionResultScreenWM(Warrior warr, Mage mage, CurrentSpell spell)
        {
            if(warr.OnTurn)
            {
                var enter = new ConsoleKeyInfo();
                Console.Clear();
                while (enter.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine($"PLAYER {warr.PlayerName} USED {spell.Name} ON {mage.PlayerName} FOR {spell.Damage} DAMAGE {spell.CritHit}");
                    PrintCharacterStats.PrintWM(mage, warr);
                    enter = Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                var enter = new ConsoleKeyInfo();
                Console.Clear();
                while (enter.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine($"PLAYER {mage.PlayerName} USED {spell.Name} ON {warr.PlayerName} FOR {spell.Damage} DAMAGE");
                    PrintCharacterStats.PrintWM(mage, warr);
                    enter = Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        internal static void GoToActionResultScreenWMExceptions(Warrior warr, Mage mage, CurrentSpell spell)
        {
            if(warr.OnTurn)
            {
                if(spell.Name == "hibernate" || spell.Name == "armorup" || spell.Name == "SHIELD SLAM")
                {
                    if(spell.Name == "armorup")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} USED ARMOR UP AND GAINED 200 ARMOR");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if(spell.Name == "hibernate")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} USED HIBERNATE AND HEALED FOR {warr.WarriorHealthRegen *4}");
                            Console.WriteLine($"{warr.PlayerName} GAINED 50% DAMAGE REDUCTION FOR OPPONENT'S TURN");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} USED {spell.Name} ON {mage.PlayerName} FOR {spell.Damage}");
                            Console.WriteLine($"{mage.PlayerName} LOSES HIS TURN");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if(spell.Name == "mirrorimage" || spell.Name == "berserk" || spell.Name == "critical")
                {
                    if(spell.Name == "critical")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} LEVELED UP HIS CRITICAL STRIKE");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if(spell.Name == "mirrorimage")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} USED MIRROR IMAGE ON {mage.PlayerName} FOR {spell.Damage} DAMAGE {spell.CritHit}");
                            Console.WriteLine($"{mage.PlayerName} LOSES 1 TURN"); 
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.PlayerName} HAS GONE BERSERK LOSING 200 HP WHILE GAINING DOUBLE DAMAGE FOR 3 ROUNDS");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }
            else
            {
                if(spell.Name == "frostarmor" || spell.Name == "firearmor")
                {
                    if (spell.Name == "frostarmor")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{mage.PlayerName} USED FROST ARMOR AND GAINED 150 ARMOR");
                            Console.WriteLine($"{mage.PlayerName} GAINED 20% PHYSICAL DAMAGE REDUCTION FOR 2 ROUNDS");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"PLAYER {mage.PlayerName} USED FIRE ARMOR AND GAINED 100 ARMOR");
                            Console.WriteLine($"PLAYER {mage.PlayerName} DAMAGES PHYSICAL ATTACKERS FOR THE NEXT 2 TURNS");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if(spell.Name == "polymorph" || spell.Name == "frozenground")
                {
                    if(spell.Name == "polymorph")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{mage.PlayerName} USED POLYMORPH ON {warr.PlayerName}");
                            Console.WriteLine($"{warr.PlayerName} LOSES 2 TURNS...");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"PLAYER {mage.PlayerName} USED FROZEN GROUND ON {warr.PlayerName} FOR A TOTAL OF {spell.Damage * 2} DAMAGE");
                            Console.WriteLine($"PLAYER {warr.PlayerName} LOSES 1 TURN");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if(spell.Name == "amplifier" || spell.Name == "icyveins" || spell.Name == "manaregeneration")
                {
                    if(spell.Name == "amplifier")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{mage.PlayerName} USED AMPLIFY MAGIC AND NOW HAS 2X SPELL POWER FOR 3 TURNS");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if(spell.Name== "manaregeneration")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{mage.PlayerName} USED MANA REGENERATION AND GAINED 300 MANA");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{mage.PlayerName} USED ICY VEINS AND NOW HAS 50% MORE SPELL POWER");
                            Console.WriteLine($"{mage.PlayerName} LOSES 1 COOLDOWN POINT ON ALL OTHER SPELLS");
                            PrintCharacterStats.PrintWM(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
