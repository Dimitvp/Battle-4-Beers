using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class GameStart
    {
        public static void GameStartWM(Warrior firstPlayer, Mage secondPlayer)
        {
            var counter = 1;
            while(firstPlayer.WarriorHealth > 0 && secondPlayer.MageHealth >0)
            {
                if(counter == 1)
                {
                    var getSpell = ExecuteWarriorCommands.ClassChecker(firstPlayer);
                    if(secondPlayer.MageHealth <= 300 && getSpell.Name == "execute")
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }
                    else if(getSpell.Name == "execute")
                    {
                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO CHOOSE A DIFFERENT ACTION");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while(entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        getSpell = ExecuteWarriorCommands.ClassChecker(firstPlayer);
                    }

                    if(!CoolDownChecker.CheckCoolDownWarr(firstPlayer, getSpell))
                    {
                        if(firstPlayer.BerserkModeIsCD == false)
                        {
                            firstPlayer.WarriorDamage = 50;
                        }
                        if (getSpell.Damage != 0)
                        {
                            if (secondPlayer.Type == "frost")
                            {
                                if (secondPlayer.FrostArmor >= getSpell.Damage)
                                {
                                    secondPlayer.FrostArmor -= getSpell.Damage;
                                }
                                else
                                {
                                    secondPlayer.MageHealth -= (getSpell.Damage - secondPlayer.FrostArmor);
                                }
                            }
                            else
                            {
                                secondPlayer.MageHealth -= getSpell.Damage;
                            }
                        }
                        else if(getSpell.Name == "berserk")
                        {
                            firstPlayer.WarriorDamage *= 2;
                            firstPlayer.WarriorHealth -= 200;
                        }
                        else if(getSpell.Name == "armor")
                        {
                            firstPlayer.WarriorArmor += firstPlayer.ShieldArmor;
                        }
                        counter = 2;
                    }
                    else
                    {
                        Console.WriteLine(@"ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        GameStartWM(firstPlayer, secondPlayer);
                    }
                    
                }
                else
                {
                    var getSpell = ExecuteMageCommands.ClassChecker(secondPlayer);
                    if (secondPlayer.MageHealth <= 300 && getSpell.Name == "execute")
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }
                    else if(getSpell.Name == "execute")
                    {
                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO CHOOSE A DIFFERENT ACTION");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        getSpell = ExecuteMageCommands.ClassChecker(secondPlayer);
                    }

                    if (!CoolDownChecker.CheckCoolDownWarr(firstPlayer, getSpell))
                    {
                        if (firstPlayer.BerserkModeIsCD == false)
                        {
                            firstPlayer.WarriorDamage = 50;
                        }
                        if (getSpell.Damage != 0)
                        {
                            if (secondPlayer.Type == "frost")
                            {
                                if (secondPlayer.FrostArmor >= getSpell.Damage)
                                {
                                    secondPlayer.FrostArmor -= getSpell.Damage;
                                }
                                else
                                {
                                    secondPlayer.MageHealth -= (getSpell.Damage - secondPlayer.FrostArmor);
                                }
                            }
                            else
                            {
                                secondPlayer.MageHealth -= getSpell.Damage;
                            }
                        }
                        else if (getSpell.Name == "berserk")
                        {
                            firstPlayer.WarriorDamage *= 2;
                            firstPlayer.WarriorHealth -= 200;
                        }
                        else if (getSpell.Name == "armor")
                        {
                            firstPlayer.WarriorArmor += firstPlayer.ShieldArmor;
                        }
                        counter = 2;
                    }
                    else
                    {
                        Console.WriteLine(@"ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        getSpell = ExecuteMageCommands.ClassChecker(secondPlayer);
                    }
                }
            }
        }

        public static void GameStartMM(Mage firstPlayer, Mage secondPlayer)
        {
        }

        public static void GameStartMW(Mage firstPlayer, Warrior secondPlayer)
        {
        }

        public static void GameStartWW(Warrior firstPlayer, Warrior secondPlayer)
        {
            
        }
    }
}
