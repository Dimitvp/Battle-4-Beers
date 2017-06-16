using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.CharacterCreation
{
    class CoinFlipper
    {
        public static List<Player> FlipTheCoin(List<Player> players)
        {
            Console.WriteLine("Flipping the coin for our players");

            var coin = new Random();

            int player = coin.Next(1, 11);

            if (player % 2 == 1)
            {
                Console.WriteLine($"Player {players[0].Name} will start");

            }
            else
            {
                Console.WriteLine($"Player {players[1].Name} will start");
                players.Add(players[0]);
                players.RemoveAt(0);
            }

            players[0].OnTurn = true;
            return players;
        }
    }
}
