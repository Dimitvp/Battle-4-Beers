using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    class ExecuteWarriorCommands
    {
        public static CurrentSpell ClassChecker(Warrior warrior)
        {
            var currentSpell = new CurrentSpell();
            if(warrior.Type == "berserker")
            {
                currentSpell = BerserkerCommands(warrior);
            }
            else if(warrior.Type == "swordmaster")
            {
                currentSpell = SwordMCommands(warrior);
            }
            else
            {
                currentSpell = ProtectorCommands(warrior);
            }

            return currentSpell;
        }

        private static CurrentSpell ProtectorCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string shieldSlam = $"SHIELD SLAM-- DAMAGE:{warrior.WarriorArmor} COOLDOWN:{2}";
                string bladeSlash = $"BLADE SLASH-- DAMAGE:{warrior.WarriorDamage} COOLDOWN:{1}";
                string armorUp = $"ARMOR UP-- ARMOR:{warrior.ShieldArmor} COOLDOWN:{2}";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (shieldSlam.Length / 2)) + "}", "-> " + bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (armorUp.Length / 2)) + "}", armorUp); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (shieldSlam.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", "-> " + bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (armorUp.Length / 2)) + "}", armorUp); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (shieldSlam.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (armorUp.Length / 2)) + "}", "-> " + armorUp); break;
                    default:
                        if (counter == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (shieldSlam.Length / 2)) + "}", "-> " + bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (armorUp.Length / 2)) + "}", armorUp); break;
                        }
                        else if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (shieldSlam.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (armorUp.Length / 2)) + "}", "-> " + armorUp); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch(counter)
            {
                case 1:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorArmor, Cooldown = 2, Name = "shield" };
                    break;
                case 2:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorDamage, Cooldown = 1, Name = "slash" };
                    break;
                default:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorArmor, Cooldown = 2 , Name = "armor"};
                    break;
            }

            return currentSpell;
            
        }

        private static CurrentSpell SwordMCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string dualAttack = $"DUAL SWORD ATTACK-- DAMAGE:{warrior.WarriorDamage * 2} COOLDOWN:{2}";
                string bladeSlash = $"BLADE SLASH-- DAMAGE:{warrior.WarriorDamage} COOLDOWN:{1}";
                string windFury = $"WINDFURY-- DAMAGE:{warrior.WarriorDamage * 5} COOLDOWN:{4}";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAttack.Length / 2)) + "}", "-> " + bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (windFury.Length / 2)) + "}", windFury); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAttack.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", "-> " + bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (windFury.Length / 2)) + "}", windFury); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAttack.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (windFury.Length / 2)) + "}", "-> " + windFury); break;
                    default:
                        if (counter == 4)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAttack.Length / 2)) + "}", "-> " + bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (windFury.Length / 2)) + "}", windFury); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 3;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAttack.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (bladeSlash.Length / 2)) + "}", bladeSlash);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (windFury.Length / 2)) + "}", "-> " + windFury); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch (counter)
            {
                case 1:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorDamage * 2, Cooldown = 2, Name = "dual" };
                    break;
                case 2:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorDamage, Cooldown = 1, Name = "slash" };
                    break;
                default:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorDamage * 5, Cooldown = 4, Name = "windfury" };
                    break;
            }

            return currentSpell;
        }

        private static CurrentSpell BerserkerCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string goBerserk = $"BERSERK MODE-- AMPLIFIER: DO DOUBLE DAMAGE FOR THREE ROUNDS COST: 200HP COOLDOWN: 5";
                string dualAxeSwing = $"DUAL AXE SWING-- DAMAGE:{warrior.WarriorDamage * 2} COOLDOWN:{1}";
                string execute = $"EXECUTE-- KILL ENEMY IF HIS HP IS BELOW 300";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,"  + "}", "-> " + goBerserk);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAxeSwing.Length / 2)) + "}", dualAxeSwing);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (execute.Length / 2)) + "}", execute); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (goBerserk.Length / 2)) + "}", goBerserk);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAxeSwing.Length / 2)) + "}", "-> " + dualAxeSwing);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (execute.Length / 2)) + "}", execute); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (goBerserk.Length / 2)) + "}", goBerserk);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAxeSwing.Length / 2)) + "}", dualAxeSwing);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (execute.Length / 2)) + "}", "-> " + execute); break;
                    default:
                        if (counter == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (goBerserk.Length / 2)) + "}", "-> " + goBerserk);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAxeSwing.Length / 2)) + "}", dualAxeSwing);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (execute.Length / 2)) + "}", execute); break;
                        }
                        else if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (goBerserk.Length / 2)) + "}", goBerserk);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (dualAxeSwing.Length / 2)) + "}", dualAxeSwing);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (execute.Length / 2)) + "}", "-> " + execute); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch (counter)
            {
                case 1:
                    currentSpell = new CurrentSpell { SacrificialHP = 200, Cooldown = 5, Name = "berserk" };
                    break;
                case 2:
                    currentSpell = new CurrentSpell { Damage = warrior.WarriorDamage * 2, Cooldown = 2, Name = "double" };
                    break;
                default:
                    currentSpell = new CurrentSpell {  Name = "execute" };
                    break;
            }

            return currentSpell;
        }
    }
}
