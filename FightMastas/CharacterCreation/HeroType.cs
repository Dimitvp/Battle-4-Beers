using FightMastas.GameProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.CharacterCreation
{
    class HeroType
    {
        public static string SelectType(string playerName)
        {
            int counter = 1;
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();
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
                string classSelect = $"SELECT HERO TYPE FOR PLAYER {playerName}";
                string warrOption = "WARRIOR";
                string mageOption = "MAGE";
                string quit = "QUIT";
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (classSelect.Length / 2)) + "}", classSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", "-> " + mageOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", warrOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", mageOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", "-> " + warrOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", mageOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", warrOption);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit); break;
                    default:
                        if (counter == 4)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", "-> " + mageOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", warrOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 3;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", mageOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", warrOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            switch (counter)
            {
                case 1:
                    {
                        var currentType = "mage";
                        return currentType;
                    };
                default:
                    {
                        var currentType = "warrior";
                        return currentType;
                    };
            }
        }
    }
}
