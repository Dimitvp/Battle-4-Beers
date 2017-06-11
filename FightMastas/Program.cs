using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class Program
    {
        static void Main(string[] args)
        {
            DrawMenu();
        }

        private static void DrawMenu()
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

                GameTitle();
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
                    StartUp(); break;
                case 2:
                    GetBeersEarned(); break;
                case 4:
                    return;
            }
        }

        private static void GetBeersEarned()
        {
            throw new NotImplementedException();
        }

        public static void GameTitle()
        {
            string titleOfTheGame = @"          _________       ___     ___  _________
          |   ___  |     |   |   |   | |   ___  |
          |  |___| |     |   |   |   | |  |___| |
          |________|__   |   |___|   | |________|__
          |  ______    | |_______    | |  ______    |
          |  |     |   |         |   | |  |     |   |
          |  |_____|   |         |   | |  |_____|   |
          |____________|         |___| |____________|";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (titleOfTheGame.Length / 2)) + "}", titleOfTheGame);
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void StartUp()
        {
            Console.WriteLine("Enter name of first character:");
            var firstPlayerName = Console.ReadLine();
            while (firstPlayerName.Length < 4 || firstPlayerName.Length > 16)
            {
                Console.WriteLine("Player name must be between 4 and 16 characters");
                firstPlayerName = Console.ReadLine();
            }
            Console.WriteLine("Enter name of second character:");
            var secondPlayerName = Console.ReadLine();
            while (secondPlayerName.Length < 4 || secondPlayerName.Length > 16 || secondPlayerName == firstPlayerName)
            {
                Console.WriteLine("Second player name must be between 4 and 16 characters and different than First player name");
                secondPlayerName = Console.ReadLine();
            }

            var dictOfPlayers = new Dictionary<string, string>();

            dictOfPlayers[firstPlayerName] = SelectType(firstPlayerName);
            dictOfPlayers[secondPlayerName] = SelectType(secondPlayerName);
            var playerList = new List<string> { firstPlayerName, secondPlayerName };
            var orderedList = new List<string>(FlipTheCoin(playerList));

            GameInitialization(orderedList, dictOfPlayers);
        }

        private static string SelectType(string playerName)
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

                GameTitle();
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
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (mageOption.Length / 2)) + "}", "-> " + mageOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (warrOption.Length / 2)) + "}", warrOption);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (quit.Length / 2)) + "}", quit); break;
                        }
                        else if (counter == 0)
                        {
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
                        return playerName = ClassSelection(currentType, playerName);
                    };
                default:
                    {
                        var currentType = "warrior";
                       return playerName = ClassSelection(currentType, playerName);
                    };
            }
        }

        private static string ClassSelection(string player, string playerName)
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
                 
                      GameTitle();
                if(player == "mage")
                {
                    string classSelect = $"CHARACTER CLASS SELECT FOR {playerName}";
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
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", swordMOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", "-> " + protectorOpt); break;
                        default:
                            if (counter == 4)
                            {
                                counter = 1;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (swordMOpt.Length / 2)) + "}", "-> " + swordMOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (berserkerOpt.Length / 2)) + "}", berserkerOpt);
                                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (protectorOpt.Length / 2)) + "}", protectorOpt); break;
                            }
                            else if (counter == 0)
                            {
                                counter = 3;
                                Console.ForegroundColor = ConsoleColor.Blue;
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
            if (player == "mage")
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
                        return "berserker";
                    case 2:
                        return "swordmaster";
                    default:
                        return "protector";
                }
            }
        }

        private static string GetMageType(string playerName, int counter, Dictionary<string,string> roles)
        {
            switch (counter)
            {
                case 1:
                    {
                        var currentMage = new Mage
                        {
                            Type = "Arcange Mage",
                            PlayerName = playerName
                        };
                        roles[playerName] = "arcane";
                        break;
                    }
                case 2:
                    {
                        var currentMage = new Mage
                        {
                            Type = "Fire Mage",
                            PlayerName = playerName
                        };
                        roles[playerName] = "fire";
                        break;
                    }
                default:
                    {
                        var currentMage = new Mage
                        {
                            Type = "Frost Mage",
                            PlayerName = playerName
                        };
                        roles[playerName] = "frost";
                        break;
                    }
                    
            }

            return roles[playerName];
        }

        private static string GetWarriorType(string playerName, int counter)
        {
            switch(counter)
            {
                case 2:
                    {
                        var currentWarrior = new Warrior
                        {
                            Type = "Berserker",
                            PlayerName = playerName
                        };
                       return playerName = "berserker";
                    }
                case 1:
                    {
                        var currentWarrior = new Warrior
                        {
                            Type = "Protector",
                            PlayerName = playerName
                        };
                        return playerName = "protector";
                    }
                default:
                    {
                        var currentWarrior = new Warrior
                        {
                            Type = "Swordmaster",
                            PlayerName = playerName
                        };
                        return playerName = "swordmaster";
                    }
            }
        }

        private static List<string> FlipTheCoin(List<string> playerNames)
        {
            Console.WriteLine("Flipping the coin for our players");

            var coin = new Random();

            int player = coin.Next(1, 3);

            if (player == 1)
            {
                Console.WriteLine($"Player {playerNames[0]} will start");
            }
            else
            {
                Console.WriteLine($"Player {playerNames[1]} will start");
                playerNames.Add(playerNames[0]);
                playerNames.RemoveAt(0);
            }

            return playerNames;
        }

        private static void GameInitialization(List<string> orderedList, Dictionary<string, string> roles)
        {
            var firstPlayer = orderedList[0];
            var secondPlayer = orderedList[1];

            var mageClasses = new string[] { "arcane", "frost", "fire"};
            var warrClasses = new string[] { "berserker", "protector", "swordmaster" };
            if (warrClasses.Contains(roles[firstPlayer]) && warrClasses.Contains(roles[secondPlayer]))
            {
                var firstPlayerChar = new Warrior { PlayerName = firstPlayer, Type = roles[firstPlayer]};
                var secondPlayerChar = new Warrior { PlayerName = secondPlayer, Type = roles[secondPlayer] };
                GameStart.GameStartWW(firstPlayerChar, secondPlayerChar);
            }
            else if (mageClasses.Contains(roles[firstPlayer]) && warrClasses.Contains(roles[secondPlayer]))
            {
                var firstPlayerChar = new Mage { PlayerName = firstPlayer, Type = roles[firstPlayer]};
                var secondPlayerChar = new Warrior { PlayerName = secondPlayer, Type = roles[secondPlayer] };
                GameStart.GameStartMW(firstPlayerChar, secondPlayerChar);
            }
            else if (mageClasses.Contains(roles[firstPlayer]) && mageClasses.Contains(roles[secondPlayer]))
            {
                var firstPlayerChar = new Mage{ PlayerName = firstPlayer, Type = roles[firstPlayer]};
                var secondPlayerChar = new Mage { PlayerName = secondPlayer, Type = roles[secondPlayer] };
                GameStart.GameStartMM(firstPlayerChar, secondPlayerChar);
            }
            else if (warrClasses.Contains(roles[firstPlayer]) && mageClasses.Contains(roles[secondPlayer]))
            {
                var firstPlayerChar = new Warrior { PlayerName = firstPlayer, Type = roles[firstPlayer] };
                var secondPlayerChar = new Mage { PlayerName = secondPlayer, Type = roles[secondPlayer] };
                GameStart.GameStartWM(firstPlayerChar, secondPlayerChar);
            }
        }

        
    }
}
