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
        public static void GoToActionResultScreen(Player warr, Player mage, CurrentSpell spell)
        {
                var enter = new ConsoleKeyInfo();
                Console.Clear();
            while (enter.Key != ConsoleKey.Enter)
            {
                Console.WriteLine($"PLAYER {warr.Name} USED {spell.Name} ON {mage.Name} FOR {spell.Damage} DAMAGE {spell.CritHit}");
                Console.WriteLine();
                PrintCharacterStats.Print(mage, warr);
                enter = Console.ReadKey();
                Console.Clear();
            }
        }

        internal static void GoToActionResultScreenExceptions(Player warr, Player mage, CurrentSpell spell)
        {
            if(warr.Hero == "warrior")
            {
                if(spell.Name == "hibernate" || spell.Name == "armorup" || spell.Name == "SHIELD SLAM")
                {
                    if(spell.Name == "armorup")
                    {
                        var enter = new ConsoleKeyInfo();
                        Console.Clear();
                        while (enter.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine($"{warr.Name} USED ARMOR UP AND GAINED 200 ARMOR");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{warr.Name} USED HIBERNATE AND HEALED FOR {warr.HealthRegen *4}");
                            Console.WriteLine($"{warr.Name} GAINED 50% DAMAGE REDUCTION FOR OPPONENT'S TURN");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{warr.Name} USED {spell.Name} ON {mage.Name} FOR {spell.Damage} DAMAGE");
                            Console.WriteLine($"{mage.Name} LOSES HIS TURN");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{warr.Name} LEVELED UP HIS CRITICAL STRIKE");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{warr.Name} USED MIRROR IMAGE ON {mage.Name} FOR {spell.Damage} DAMAGE {spell.CritHit}");
                            Console.WriteLine($"{mage.Name} LOSES 1 TURN");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{warr.Name} HAS GONE BERSERK LOSING 200 HP WHILE GAINING DOUBLE DAMAGE FOR 3 ROUNDS");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{mage.Name} USED FROST ARMOR AND GAINED 150 ARMOR");
                            Console.WriteLine($"{mage.Name} GAINED 20% PHYSICAL DAMAGE REDUCTION FOR 2 ROUNDS");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"PLAYER {mage.Name} USED FIRE ARMOR AND GAINED 150 ARMOR AND 150 HEALTH");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{mage.Name} USED POLYMORPH ON {warr.Name}");
                            Console.WriteLine($"{warr.Name} LOSES 2 TURNS...");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"PLAYER {mage.Name} USED FROZEN GROUND ON {warr.Name} FOR A TOTAL OF {spell.Damage * 2} DAMAGE");
                            Console.WriteLine($"PLAYER {warr.Name} LOSES 1 TURN");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{mage.Name} USED AMPLIFY MAGIC AND NOW HAS 2X SPELL POWER FOR 3 TURNS");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{mage.Name} USED MANA REGENERATION AND GAINED 300 MANA");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
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
                            Console.WriteLine($"{mage.Name} USED ICY VEINS AND NOW HAS 50% MORE SPELL POWER");
                            Console.WriteLine($"{mage.Name} LOSES 1 COOLDOWN POINT ON ALL OTHER SPELLS");
                            Console.WriteLine();
                            PrintCharacterStats.Print(mage, warr);
                            enter = Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
