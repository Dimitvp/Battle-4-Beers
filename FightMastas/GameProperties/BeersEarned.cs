using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.GameProperties
{
    class BeersEarned
    {
        public static void GetBeersEarned()
        {
            Console.WriteLine("WRITE NAME OF PLAYER WHOSE BEER EARNINGS YOU WANT TO SEE:");
            var playerName = Console.ReadLine();

            try
            {
                var reader = File.ReadAllLines($"../../../{playerName}.txt");
                for (int i = 0; i < reader.Length; i++)
                {
                    Console.WriteLine(reader[i]);
                }
                var entry = new ConsoleKeyInfo();
                while (entry.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("PRESS ENTER TO GO BACK TO GAME MENU...");
                    entry = Console.ReadKey();
                    Console.Clear();
                }
                DrawMenu.Menu();
            }
            catch
            {
                
                var entry = new ConsoleKeyInfo();
                while (entry.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine($"{playerName} HAS NOT EARNED ANY BEERS YET!");
                    Console.WriteLine("PRESS ENTER TO GO BACK TO GAME MENU...");
                    entry = Console.ReadKey();
                    Console.Clear();
                }
                DrawMenu.Menu();
            }
        }
    }
}
