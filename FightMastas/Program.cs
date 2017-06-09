using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of first character:");
            var firstPlayerName = Console.ReadLine();
            Console.WriteLine("Enter name of second character:");
            var secondPlayerName = Console.ReadLine();

            SelectClass(firstPlayerName);
            SelectClass(secondPlayerName);
        }

        private static void SelectClass(string playerName)
        {
            Console.WriteLine("Select a character class:");
            var inputClass = Console.ReadLine().ToLower();

            if (inputClass == "mage")
            {
              var playerClass = new Mage();
            }
            else if(inputClass == "warrior")
            {

            }
            else
            {
                Console.WriteLine("Invalid Entry, try again:");
                inputClass = Console.ReadLine();
            }

            
        }
    }
}
