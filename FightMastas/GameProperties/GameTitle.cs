  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas.GameProperties
{
    public class GameTitle
    {
        public static void GetTitle()
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
    }
}
