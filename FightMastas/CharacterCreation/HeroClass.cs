using FightMastas.GameProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.CharacterCreation
{
    class HeroClass
    {
        public static string ClassSelection(Player player)
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

                GameTitle.GetTitle();
                if (player.Hero == "mage")
                {
                    string classSelect = $"CHARACTER CLASS SELECT FOR {player.Name}";
                    string fireMOpt = "FIRE MAGE";
                    string arcaneMOpt = "ARCANE MAGE";
                    string frostMOpt = "FROST MAGE";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (classSelect.Length / 2)) + "}", classSelect);
                    switch (counter)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireMOpt.Length / 2)) + "}", "-> " + fireMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneMOpt.Length / 2)) + "}", arcaneMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostMOpt.Length / 2)) + "}", frostMOpt); break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireMOpt.Length / 2)) + "}", fireMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneMOpt.Length / 2)) + "}", "-> " + arcaneMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostMOpt.Length / 2)) + "}", frostMOpt); break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireMOpt.Length / 2)) + "}", fireMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneMOpt.Length / 2)) + "}", arcaneMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostMOpt.Length / 2)) + "}", "-> " + frostMOpt); break;
                        default:
                            if (counter == 4)
                            {
                                counter = 1;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireMOpt.Length / 2)) + "}", "-> " + fireMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneMOpt.Length / 2)) + "}", arcaneMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostMOpt.Length / 2)) + "}", frostMOpt); break;
                            }
                            else if (counter == 0)
                            {
                                counter = 3;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (fireMOpt.Length / 2)) + "}", fireMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (arcaneMOpt.Length / 2)) + "}", arcaneMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (frostMOpt.Length / 2)) + "}", "-> " + frostMOpt); break;
                            }
                            break;
                    }
                    enter = Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    string classSelect = $"CHARACTER CLASS SELECT FOR {player}";
                    string berserkerOpt = "BERSERKER";
                    string swordMOpt = "SWORDMASTER";
                    string protectorOpt = "PROTECTOR";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (classSelect.Length / 2)) + "}", classSelect);
                    switch (counter)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", "-> " + swordMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", protectorOpt); break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", swordMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", "-> " + berserkerOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", protectorOpt); break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", swordMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", "-> " + protectorOpt); break;
                        default:
                            if (counter == 4)
                            {
                                counter = 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", "-> " + swordMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", protectorOpt); break;
                            }
                            else if (counter == 0)
                            {
                                counter = 3;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", swordMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", "-> " + protectorOpt); break;
                            }
                            break;
                    }
                    enter = Console.ReadKey();
                    Console.Clear();
                }
            }
            if (player.Hero == "mage")
            {
                switch (counter)
                {
                    case 1:
                        return "fire";
                    case 2:
                        return "arcane";
                    default:
                        return "frost";
                }
            }
            else
            {
                switch (counter)
                {
                    case 1:
                        return "swordmaster";
                    case 2:
                        return "berserker";
                    default:
                        return "protector";
                }
            }
        }
    }
}
