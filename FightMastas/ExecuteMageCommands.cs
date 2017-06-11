using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    class ExecuteMageCommands
    {
        public static CurrentSpell ClassChecker(Mage mage)
        {
            var currentSpell = new CurrentSpell();
            if (mage.Type == "frost")
            {
                currentSpell = FrostMageCommands(mage);
            }
            else if (mage.Type == "fire")
            {
                currentSpell = FireMageCommands(mage);
            }
            else
            {
                currentSpell = ArcaneMageCommands(mage);
            }

            return currentSpell;
        }

        private static CurrentSpell ArcaneMageCommands(Mage mage)
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
                string actionSelect = $"SELECT ACTION FOR {mage.PlayerName}";
                string polymorph = $"SHIELD SLAM-- DAMAGE:{mage.MageSpellPower} COOLDOWN:{2}";
                string arcaneBlast = $"BLADE SLASH-- DAMAGE:{mage.MageSpellPower} COOLDOWN:{1}";
                string amplifier = $"ARMOR UP-- ARMOR:{mage.MageSpellPower} COOLDOWN:{2}";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (polymorph.Length / 2)) + "}", "-> " + arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneBlast.Length / 2)) + "}", arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (amplifier.Length / 2)) + "}", amplifier); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (polymorph.Length / 2)) + "}", arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneBlast.Length / 2)) + "}", "-> " + arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (amplifier.Length / 2)) + "}", amplifier); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (polymorph.Length / 2)) + "}", arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneBlast.Length / 2)) + "}", arcaneBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (amplifier.Length / 2)) + "}", "-> " + amplifier); break;
                    default:
                        if (counter == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (polymorph.Length / 2)) + "}", "-> " + arcaneBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneBlast.Length / 2)) + "}", arcaneBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (amplifier.Length / 2)) + "}", amplifier); break;
                        }
                        else if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (polymorph.Length / 2)) + "}", arcaneBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneBlast.Length / 2)) + "}", arcaneBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (amplifier.Length / 2)) + "}", "-> " + amplifier); break;
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
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower, Cooldown = 2, Name = "shield" };
                    break;
                case 2:
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower, Cooldown = 1, Name = "slash" };
                    break;
                default:
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower, Cooldown = 2, Name = "armor" };
                    break;
            }

            return currentSpell;

        }

        private static CurrentSpell FireMageCommands(Mage mage)
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
                string actionSelect = $"SELECT ACTION FOR {mage.PlayerName}";
                string fireBlast = $"DUAL SWORD ATTACK-- DAMAGE:{mage.MageSpellPower * 2} COOLDOWN:{2}";
                string pyroBlast = $"BLADE SLASH-- DAMAGE:{mage.MageSpellPower} COOLDOWN:{1}";
                string obliterate = $"WINDFURY-- DAMAGE:{mage.MageSpellPower * 5} COOLDOWN:{4}";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireBlast.Length / 2)) + "}", "-> " + pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (pyroBlast.Length / 2)) + "}", pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (obliterate.Length / 2)) + "}", obliterate); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireBlast.Length / 2)) + "}", pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (pyroBlast.Length / 2)) + "}", "-> " + pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (obliterate.Length / 2)) + "}", obliterate); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireBlast.Length / 2)) + "}", pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (pyroBlast.Length / 2)) + "}", pyroBlast);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (obliterate.Length / 2)) + "}", "-> " + obliterate); break;
                    default:
                        if (counter == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireBlast.Length / 2)) + "}", "-> " + pyroBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (pyroBlast.Length / 2)) + "}", pyroBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (obliterate.Length / 2)) + "}", obliterate); break;
                        }
                        else if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireBlast.Length / 2)) + "}", pyroBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (pyroBlast.Length / 2)) + "}", pyroBlast);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (obliterate.Length / 2)) + "}", "-> " + obliterate); break;
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
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower * 2, Cooldown = 2, Name = "dual" };
                    break;
                case 2:
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower, Cooldown = 1, Name = "slash" };
                    break;
                default:
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower * 5, Cooldown = 4, Name = "windfury" };
                    break;
            }

            return currentSpell;
        }

        private static CurrentSpell FrostMageCommands(Mage mage)
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
                string actionSelect = $"SELECT ACTION FOR {mage.PlayerName}";
                string frostArmor = $"BERSERK MODE-- AMPLIFIER: DO DOUBLE DAMAGE FOR THREE ROUNDS COST: 200HP COOLDOWN: 5";
                string frostBolt = $"DUAL AXE SWING-- DAMAGE:{mage.MageSpellPower * 2} COOLDOWN:{1}";
                string icyVeins = $"EXECUTE-- KILL ENEMY IF HIS HP IS BELOW 300";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (actionSelect.Length / 2)) + "}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + "}", "-> " + frostArmor);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostBolt.Length / 2)) + "}", frostBolt);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (icyVeins.Length / 2)) + "}", icyVeins); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostArmor.Length / 2)) + "}", frostArmor);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostBolt.Length / 2)) + "}", "-> " + frostBolt);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (icyVeins.Length / 2)) + "}", icyVeins); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostArmor.Length / 2)) + "}", frostArmor);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostBolt.Length / 2)) + "}", frostBolt);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (icyVeins.Length / 2)) + "}", "-> " + icyVeins); break;
                    default:
                        if (counter == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostArmor.Length / 2)) + "}", "-> " + frostArmor);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostBolt.Length / 2)) + "}", frostBolt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (icyVeins.Length / 2)) + "}", icyVeins); break;
                        }
                        else if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostArmor.Length / 2)) + "}", frostArmor);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostBolt.Length / 2)) + "}", frostBolt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (icyVeins.Length / 2)) + "}", "-> " + icyVeins); break;
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
                    currentSpell = new CurrentSpell { Damage = mage.MageSpellPower * 2, Cooldown = 2, Name = "double" };
                    break;
                default:
                    currentSpell = new CurrentSpell { Name = "execute" };
                    break;
            }

            return currentSpell;
        }
    }
}

  
