using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightMastas;
using FightMastas.CharacterCreation;

namespace FightMastas.GameProperties
{
    class NewGame
    {
        public static void StartUp()
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

            List<Player> players = new List<Player>();

            players.Add(new Player { Name = firstPlayerName, Hero = HeroType.SelectType(firstPlayerName) });
            players.Add(new Player { Name = secondPlayerName, Hero = HeroType.SelectType(secondPlayerName) });
            players[0].Type = HeroClass.ClassSelection(players[0]);
            players[1].Type = HeroClass.ClassSelection(players[1]);
            if (players[0].Hero == "mage")
            {
               players[0] = GenerateCharacterStats.Mage(players[0]);
            }
            else
            {
                players[0] = GenerateCharacterStats.Warrior(players[0]);
            }

            if (players[1].Hero == "mage")
            {
               players[1] = GenerateCharacterStats.Mage(players[1]);
            }
            else
            {
              players[1] =  GenerateCharacterStats.Warrior(players[1]);
            }
            Battle.ExecuteCommand(CoinFlipper.FlipTheCoin(players));

        }


    }
}
