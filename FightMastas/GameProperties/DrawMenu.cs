using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.GameProperties
{
    class DrawMenu
    {
        public static void Menu()
        {
            int counter = 1;
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
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
                string newGame = "NEW GAME";
                string beerEarnings = "BEERS EARNED";
                string instructionsText = "INSTRUCTIONS";
                string quit = "QUIT";

                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", "-> " + newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", "-> " + beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", "-> " + instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", "-> " + newGame);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit);
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (newGame.Length / 2)) + "}", newGame);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (beerEarnings.Length / 2)) + "}", beerEarnings);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (instructionsText.Length / 2)) + "}", instructionsText);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", "-> " + quit);
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }

            switch (counter)
            {
                case 1:
                    NewGame.StartUp(); break;
                case 2:
                    BeersEarned.GetBeersEarned(); break;
                case 3:
                    Instructions.OpenInstructions(); break;
                case 4:
                    return;
            }
        }
    }
}
