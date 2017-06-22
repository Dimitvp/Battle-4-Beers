using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.GameProperties
{
    class Instructions
    {
        public static void OpenInstructions()
        {
            var lines = File.ReadAllLines("../../Instructions.txt");
            var entry = new ConsoleKeyInfo();
            while(entry.Key != ConsoleKey.Enter)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                Console.WriteLine();
                Console.WriteLine("PRESS ENTER TO GO BACK TO GAME MENU...");
                entry = Console.ReadKey();
                Console.Clear();
            }
            DrawMenu.Menu();

        }
    }
}
