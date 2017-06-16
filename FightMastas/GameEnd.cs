using FightMastas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class GameEnd
    {
        public static void GameEndPrint(Player firstPlayer, Player secondPlayer)
        {

            var beersDict = new Dictionary<string, int>();

            if (firstPlayer.Health <= 0)
            {
                var loser = firstPlayer.Name;
                var winner = secondPlayer.Name;

                var entry = new ConsoleKeyInfo();
                while (entry.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("");
                    entry = Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (secondPlayer.Health <= 0)
            {
                var winner = firstPlayer.Name;
                var loser = secondPlayer.Name;

                var writer = new StreamWriter($"../../{winner}.txt");
                


                var entry = new ConsoleKeyInfo();
                while (entry.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("");
                    entry = Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }
    }
}
