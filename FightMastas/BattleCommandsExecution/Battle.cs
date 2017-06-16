using B4B;
using FightMastas.CharacterCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightMastas;

namespace FightMastas
{
    class Battle
    {
        public static void ExecuteCommand(List<Player> players)
        {
            var firstPlayer = players[0];
            var secondPlayer = players[1];

            while (firstPlayer.Health > 0 && secondPlayer.Health > 0)
            {
                while (firstPlayer.OnTurn)
                {  
                   
                    if(firstPlayer.IcyVeinsCoolDown <=1 && firstPlayer.Type == "frost")
                    {
                        firstPlayer.Spellpower = 100;
                    }
                    else if(firstPlayer.AmplifierCoolDown <= 2 && firstPlayer.Type == "arcane")
                    {
                        firstPlayer.Spellpower = 100;
                    }

                    if (firstPlayer.FrostReductionDuration <= 0)
                    {
                        firstPlayer.FrostReduction = false;
                    }

                    var currentSpell = new CurrentSpell();
                    if (firstPlayer.Hero == "mage")
                    {
                        currentSpell = GetMageCommands.ClassChecker(firstPlayer);
                    }
                    else
                    {
                        currentSpell = GetWarriorCommands.ClassChecker(firstPlayer);
                    }

                    if(currentSpell.Name == "critical" && firstPlayer.CriticalStrike == true)
                    {
                        var entry = new ConsoleKeyInfo();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine("YOU HAVE ALREADY LEVELED UP CRITICAL STRIKE, PRESS ENTER TO CHOOSE DIFFERENT ACTION....");
                            entry = Console.ReadKey();
                            Console.Clear();
                        }
                        currentSpell = GetWarriorCommands.ClassChecker(firstPlayer);
                    }
                    else if(currentSpell.Name == "critical")
                    {
                        firstPlayer.CriticalStrike = true;
                    }

                    if (currentSpell.Execution == true)
                    {
                        if (firstPlayer.Hero == "warrior")
                        {
                            if (secondPlayer.Health <= 700)
                            {
                                secondPlayer.Health = 0;
                                GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                                return;
                            }
                            else
                            {
                                while (currentSpell.Execution == true)
                                {
                                    var entry = new ConsoleKeyInfo();
                                    while (entry.Key != ConsoleKey.Enter)
                                    {
                                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                        entry = Console.ReadKey();
                                        Console.Clear();
                                    }
                                    currentSpell = GetWarriorCommands.ClassChecker(firstPlayer);
                                }
                            }
                        }
                        else if (firstPlayer.Hero == "mage")
                        {
                            if (secondPlayer.Health <= 900)
                            {
                                secondPlayer.Health = 0;
                                GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                                return;

                            }
                            else 
                            {
                                while (currentSpell.Execution == true)
                                {
                                    var entry = new ConsoleKeyInfo();
                                    while (entry.Key != ConsoleKey.Enter)
                                    {
                                        Console.WriteLine("TARGET HP NOT LOW ENOUGH, PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                        entry = Console.ReadKey();
                                        Console.Clear();
                                    }
                                    currentSpell = GetMageCommands.ClassChecker(firstPlayer);
                                }
                            }
                        }
                    }

                    while (CoolDownChecker.GetClass(firstPlayer, currentSpell))
                    {
                        var entry = new ConsoleKeyInfo();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine("ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE...");
                            entry = Console.ReadKey();
                            Console.Clear();
                        }
                        if(firstPlayer.Hero == "mage")
                        {
                            currentSpell = GetMageCommands.ClassChecker(firstPlayer);
                        }
                        else
                        {
                            currentSpell = GetWarriorCommands.ClassChecker(firstPlayer);
                        }
                    }

                    if (currentSpell.FrostArmor || currentSpell.Name == "hibernate")
                    {
                        if (currentSpell.FrostArmor)
                        {
                            firstPlayer.FrostReduction = true;
                            firstPlayer.FrostReductionDuration = 2;
                        }
                        else if (currentSpell.Name == "hibernate")
                        {
                            firstPlayer.HibernateReduction = true;
                            firstPlayer.Health += firstPlayer.HealthRegen * 4;
                        }
                    }

                    if (currentSpell.GetArmor > 0 || currentSpell.GetHP >0 || currentSpell.GetMana > 0)
                    {
                        firstPlayer.Armor += currentSpell.GetArmor;
                        firstPlayer.Health += currentSpell.GetHP;
                        firstPlayer.Mana += currentSpell.GetMana;
                    }

                    if ((secondPlayer.FrostReduction && firstPlayer.Hero == "warrior")|| secondPlayer.HibernateReduction == true)
                    {
                        if(secondPlayer.FrostReduction == true)
                        {
                            currentSpell.Damage *= 0.8;
                        }
                        
                        if(secondPlayer.HibernateReduction == true)
                        {
                            currentSpell.Damage *= 0.5;
                            secondPlayer.HibernateReduction = false;
                        }
                    }

                    if(currentSpell.Name == "amplifier" || currentSpell.Name == "icyveins" || currentSpell.Name == "berserk")
                    {
                        firstPlayer.Spellpower *= currentSpell.Amplifier;
                        firstPlayer.Damage *= (int)currentSpell.Amplifier;
                    }

                    if(firstPlayer.CriticalStrike == true || firstPlayer.Type == "berserk")
                    {
                        if(firstPlayer.CriticalStrike == true)
                        {
                            var chance = new Random().Next(1, 101);
                            if (chance <= 35)
                            {
                                currentSpell.Damage *= 2;
                                currentSpell.CritHit = "CRITICAL STRIKE!!!";

                            }
                        }
                        else if(firstPlayer.Type == "berserk")
                        {
                            var chance = new Random().Next(1, 101);
                            if (chance <= 15)
                            {
                                currentSpell.Damage *= 2;
                                currentSpell.CritHit = "CRITICAL STRIKE!!!";
                            }
                        }
                    }

                    if(currentSpell.Damage > 0)
                    {
                        if(secondPlayer.Armor >= currentSpell.Damage)
                        {
                            secondPlayer.Armor -= (int) currentSpell.Damage;
                        }
                        else
                        {
                            secondPlayer.Health -= (int)(currentSpell.Damage - secondPlayer.Armor);
                            secondPlayer.Armor = 0;

                        }
                    }

                    if (currentSpell.ManaCost > 0 || currentSpell.SacrificialHP > 0)
                    {
                        firstPlayer.Mana -= currentSpell.ManaCost;
                        firstPlayer.Health -= currentSpell.SacrificialHP;
                    }

                    if (CurrentSpell.SpellsExceptional(currentSpell))
                    {
                        ActionResultScreen.GoToActionResultScreenExceptions(firstPlayer, secondPlayer, currentSpell);
                     }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreen(firstPlayer, secondPlayer, currentSpell);
                    }

                    if (firstPlayer.BerserkModeCooldown <= 2 && firstPlayer.Hero == "warrior")
                    {
                        firstPlayer.Damage = 80;
                    }

                    if (currentSpell.Name == "mirrorimage" || currentSpell.Name == "polymorph" || currentSpell.Name == "frozenground"
                        || currentSpell.Name == "SHIELD SLAM" || firstPlayer.PolymorphCoolDown > 2)
                    {
                        firstPlayer.OnTurn = true;
                        secondPlayer.OnTurn = false;
                    }
                    else
                    {
                        firstPlayer.OnTurn = false;
                        secondPlayer.OnTurn = true;
                    }

                    secondPlayer.FrostReductionDuration--;

                    if (secondPlayer.Health <= 0)
                    {
                        GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                        return;

                    }
                }

                while (secondPlayer.OnTurn)
                {
                    
                    if (secondPlayer.IcyVeinsCoolDown <= 1 && secondPlayer.Type == "frost")
                    {
                        secondPlayer.Spellpower = 100;
                    }
                    else if (secondPlayer.AmplifierCoolDown <= 2 && secondPlayer.Type == "arcane")
                    {
                        secondPlayer.Spellpower = 100;
                    }

                    if (secondPlayer.FrostReductionDuration <= 0)
                    {
                        secondPlayer.FrostReduction = false;
                    }

                    var currentSpell = new CurrentSpell();
                    if (secondPlayer.Hero == "mage")
                    {
                        currentSpell = GetMageCommands.ClassChecker(secondPlayer);
                    }
                    else
                    {
                        currentSpell = GetWarriorCommands.ClassChecker(secondPlayer);
                    }

                    if (currentSpell.Name == "critical" && secondPlayer.CriticalStrike == true)
                    {
                        var entry = new ConsoleKeyInfo();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine("YOU HAVE ALREADY LEVELED UP CRITICAL STRIKE, PRESS ENTER TO CHOOSE DIFFERENT ACTION....");
                            entry = Console.ReadKey();
                            Console.Clear();
                        }
                        currentSpell = GetWarriorCommands.ClassChecker(secondPlayer);
                    }
                    else if(currentSpell.Name == "critical")
                    {
                        secondPlayer.CriticalStrike = true;
                    }

                    if (currentSpell.Execution == true)
                    {
                        if (secondPlayer.Hero == "warrior")
                        {
                            if (firstPlayer.Health <= 700)
                            {
                                firstPlayer.Health = 0;
                                GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                                return;
                            }
                            else
                            {
                                while (currentSpell.Execution == true)
                                {
                                    var entry = new ConsoleKeyInfo();
                                    while (entry.Key != ConsoleKey.Enter)
                                    {
                                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                        entry = Console.ReadKey();
                                        Console.Clear();
                                    }
                                    currentSpell = GetWarriorCommands.ClassChecker(secondPlayer);
                                }
                            }
                        }
                        else if(secondPlayer.Hero == "mage")
                        {
                            if (firstPlayer.Health <= 900)
                            {
                                firstPlayer.Health = 0;
                                GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                            }
                            else
                            {
                                while (currentSpell.Execution == true)
                                {
                                    var entry = new ConsoleKeyInfo();
                                    while (entry.Key != ConsoleKey.Enter)
                                    {
                                        Console.WriteLine("TARGET HP NOT LOW ENOUGH, PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                        entry = Console.ReadKey();
                                        Console.Clear();
                                    }
                                    currentSpell = GetMageCommands.ClassChecker(secondPlayer);
                                }
                            }
                        }
                    }

                    while (CoolDownChecker.GetClass(secondPlayer, currentSpell))
                    {
                        var entry = new ConsoleKeyInfo();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            Console.WriteLine("ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE...");
                            entry = Console.ReadKey();
                            Console.Clear();
                        }
                        if (secondPlayer.Hero == "mage")
                        {
                            currentSpell = GetMageCommands.ClassChecker(secondPlayer);
                        }
                        else
                        {
                            currentSpell = GetWarriorCommands.ClassChecker(secondPlayer);
                        }
                    }

                    if (currentSpell.FrostArmor || currentSpell.Name == "hibernate" )
                    {
                        if (currentSpell.FrostArmor)
                        {
                            secondPlayer.FrostReduction = true;
                            secondPlayer.FrostReductionDuration = 2;
                        }
                        else if (currentSpell.Name == "hibernate")
                        {
                            secondPlayer.HibernateReduction = true;
                            secondPlayer.Health += firstPlayer.HealthRegen * 4;
                        }
                    }

                    if (currentSpell.GetArmor > 0 || currentSpell.GetHP > 0 || currentSpell.GetMana > 0)
                    {
                        secondPlayer.Armor += currentSpell.GetArmor;
                        secondPlayer.Health += currentSpell.GetHP;
                        secondPlayer.Mana += currentSpell.GetMana;
                    }

                    if ((firstPlayer.FrostReduction && secondPlayer.Hero == "warrior") || firstPlayer.HibernateReduction == true)
                    {
                        if (firstPlayer.FrostReduction == true)
                        {
                            currentSpell.Damage *= 0.8;
                        }

                        if (firstPlayer.HibernateReduction == true)
                        {
                            currentSpell.Damage *= 0.5;
                            firstPlayer.HibernateReduction = false;
                        }
                    }

                    if (currentSpell.Name == "amplifier" || currentSpell.Name == "icyveins" || currentSpell.Name == "berserk")
                    {
                        secondPlayer.Spellpower *= currentSpell.Amplifier;
                        secondPlayer.Damage *= (int)currentSpell.Amplifier;
                    }

                    if (secondPlayer.CriticalStrike == true || secondPlayer.Type == "berserk")
                    {
                        if (secondPlayer.CriticalStrike == true)
                        {
                            var chance = new Random().Next(1, 101);
                            if (chance <= 35)
                            {
                                currentSpell.Damage *= 2;
                                currentSpell.CritHit = "CRITICAL STRIKE!!!";

                            }
                        }
                        else if (secondPlayer.Type == "berserk")
                        {
                            var chance = new Random().Next(1, 101);
                            if (chance <= 15)
                            {
                                currentSpell.Damage *= 2;
                                currentSpell.CritHit = "CRITICAL STRIKE!!!";
                            }
                        }
                    }

                    if (currentSpell.Damage > 0)
                    {
                        if (firstPlayer.Armor >= currentSpell.Damage)
                        {
                            firstPlayer.Armor -= (int)currentSpell.Damage;
                        }
                        else
                        {
                            firstPlayer.Health -= (int)(currentSpell.Damage - firstPlayer.Armor);
                            firstPlayer.Armor = 0;
                        }
                    }

                    if (currentSpell.ManaCost > 0 || currentSpell.SacrificialHP > 0)
                    {
                        secondPlayer.Mana -= currentSpell.ManaCost;
                        secondPlayer.Health -= currentSpell.SacrificialHP;
                    }

                    if (CurrentSpell.SpellsExceptional(currentSpell))
                    {
                        ActionResultScreen.GoToActionResultScreenExceptions(secondPlayer, firstPlayer, currentSpell);
                    }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreen(secondPlayer, firstPlayer, currentSpell);
                    }

                    if (secondPlayer.BerserkModeCooldown <= 2 && secondPlayer.Hero == "warrior")
                    {
                        secondPlayer.Damage = 80;
                    }

                    if (currentSpell.Name == "mirrorimage" || currentSpell.Name == "polymorph" || currentSpell.Name == "frozenground"
                        || currentSpell.Name == "SHIELD SLAM" || secondPlayer.PolymorphCoolDown > 2)
                    {
                        secondPlayer.OnTurn = true;
                        firstPlayer.OnTurn = false;
                    }
                    else
                    {
                        secondPlayer.OnTurn = false;
                        firstPlayer.OnTurn = true;
                    }

                    firstPlayer.FrostReductionDuration--;

                    if (firstPlayer.Health <= 0)
                    {
                        GameEnd.GameEndPrint(firstPlayer, secondPlayer);
                        return;
                    }
                }

                firstPlayer.Health += firstPlayer.HealthRegen;
                firstPlayer.Mana += firstPlayer.ManaRegen;
                secondPlayer.Health += secondPlayer.HealthRegen;
                secondPlayer.Mana += secondPlayer.ManaRegen;
            }
        }
    }
}
