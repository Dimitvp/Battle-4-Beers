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

            string winner;
            string loser;

            if(secondPlayer.Health <= 0)
            {
               winner = firstPlayer.Name;
               loser = secondPlayer.Name;
            }
            else
            {
               winner = secondPlayer.Name;
               loser = firstPlayer.Name;
            }

            try
            {
                var trialReader = File.ReadAllLines($"../../../{winner}.txt");
            }
            catch
            {
                var creator = new StreamWriter($"../../../{winner}.txt");
                creator.Close();
            }
            var reader = File.ReadAllLines($"../../../{winner}.txt");
            if (reader.Any())
            {
                var writer = new StreamWriter($"../../../{winner}.txt");
                var loserIsContained = false;
                for (int i = 1; i < reader.Length; i++)
                {
                    var tokens = reader[i].Split();
                    var currentName = tokens[3];
                    var currentBeers = int.Parse(tokens[0]);
                    beersDict[currentName] = currentBeers;
                    if(currentName == loser)
                    {
                        beersDict[currentName] += 1;
                        loserIsContained = true;
                    }
                    writer.WriteLine($"{beersDict[currentName]} BEERS FROM {loser}");
                }
                if(!loserIsContained)
                {
                    for (int i = 0; i < reader.Length; i++)
                    {
                        writer.WriteLine(reader[i]);
                    }
                    writer.WriteLine($"1 BEERS FROM {loser}");
                    writer.Close();
                }
                else
                {
                    writer.Close();
                }
            }
            else
            {
                var writer = new StreamWriter($"../../../{winner}.txt");
                writer.WriteLine($"{winner} HAS EARNED BEERS FROM:");
                writer.WriteLine($"1 BEERS FROM {loser}");
                writer.Close();
            }

            var entry = new ConsoleKeyInfo();
            while (entry.Key != ConsoleKey.Enter)
            {
                Console.WriteLine($"{winner} DEFEATED {loser} IN A BATTLE 4 BEERS MATCH");
                Console.WriteLine($"{loser} NOW OWNS {winner} A BEER");
                Console.WriteLine("THANK YOU FOR PLAYING!");
                Console.WriteLine("PRESS ENTER TO QUIT.....");
                entry = Console.ReadKey();
                Console.Clear();
            }
            }
    }
}
