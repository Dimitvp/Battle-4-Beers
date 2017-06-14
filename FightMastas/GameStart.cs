using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class GameStart
    {
        public static void GameStartWM(Warrior firstPlayer, Mage secondPlayer)
        {
            firstPlayer.OnTurn = true;
            if (firstPlayer.ArmorEquipped == false && firstPlayer.Type == "protector")
            {
                firstPlayer.ArmorEquipped = true;
                firstPlayer.WarriorArmor += 300;
            }
            while (firstPlayer.WarriorHealth > 0 && secondPlayer.MageHealth > 0)
            {
                if(firstPlayer.OnTurn)
                {
                    var spell = GetWarriorCommands.ClassChecker(firstPlayer);
                    if (secondPlayer.MageHealth <= 300 && spell.Execution == true)
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }
                    
                    while(spell.Execution == true)
                    {
                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO CHOOSE A DIFFERENT ACTION");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while(entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetWarriorCommands.ClassChecker(firstPlayer);
                    }

                    while (CoolDownChecker.CheckCoolDownWarr(firstPlayer, spell))
                    {
                        Console.WriteLine(@"ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                           entry = Console.ReadKey();
                        }
                        spell = GetWarriorCommands.ClassChecker(firstPlayer);
                    }

                    if(spell.Name == "critical" || spell.Name == "hibernate" || spell.Name == "berserk" || spell.Name == "armorup")
                    {
                        if(spell.Name == "critical")
                        {
                            if(firstPlayer.CriticalStrike == true)
                            {
                                while(spell.Name == "critical")
                                {
                                    Console.WriteLine("YOU HAVE ALREADY LEVELED UP CRITICAL STRIKE");
                                    Console.WriteLine("PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                    var enter = new ConsoleKeyInfo();
                                    enter = Console.ReadKey();
                                    while(enter.Key != ConsoleKey.Enter)
                                    {
                                        enter = Console.ReadKey();
                                    }
                                    firstPlayer.WindFuryCooldown++;
                                    firstPlayer.MirrorImageCooldown++;
                                    spell = GetWarriorCommands.ClassChecker(firstPlayer);
                                }
                            }
                            else
                            {
                                firstPlayer.CriticalStrike = true;
                            }
                        }
                        else if (spell.Name == "hibernate")
                        {
                            firstPlayer.DamageReduction = true;
                        }
                        else if (spell.Name == "berserk")
                        {
                            firstPlayer.WarriorHealth -= 200;
                        }
                        else
                        {
                            firstPlayer.WarriorArmor += spell.GetArmor;
                        }
                    }

                    if (firstPlayer.CriticalStrike == true || firstPlayer.Type == "berserker")
                    {
                        var critChance = new Random().Next(1, 101);
                        if (critChance <= 30 && firstPlayer.Type == "swordmaster")
                        {
                            spell.Damage *= 2;
                            spell.CritHit = "CRITICAL STRIKE!!!";
                        }
                        else if(critChance <= 15 && firstPlayer.Type == "berserker")
                        {
                            spell.Damage *= 2;
                            spell.CritHit = "BERSERK CRITICAL STRIKE!!!";
                        }
                    }

                    if(firstPlayer.BerserkModeCooldown >= 2)
                    {
                        spell.Damage *= 2;
                    }

                    if(firstPlayer.HibernateCooldown >= 1)
                    {
                        firstPlayer.WarriorHealth += (int)1.5 * firstPlayer.WarriorHealthRegen;
                    }

                    if (secondPlayer.FrostReduction == true)
                    {
                        spell.Damage *= 0.8;
                        secondPlayer.FrostReductionDuration--;
                        if (secondPlayer.FrostReductionDuration == 0)
                        {
                            secondPlayer.FrostReduction = false;
                        }
                    }

                    if (spell.Damage != 0)
                    {
                        if (secondPlayer.Type == "frost" || secondPlayer.Type == "fire")
                        {

                            if(secondPlayer.Type == "fire" && secondPlayer.FireArmorCoolDown >= 2)
                            {
                                firstPlayer.WarriorHealth -= (int) secondPlayer.MageSpellPower / 2;
                            }

                            if (secondPlayer.Armor >= (int)spell.Damage)
                            {
                                secondPlayer.Armor -= (int)spell.Damage;
                            }
                            else
                            {
                                secondPlayer.MageHealth -= (int)(spell.Damage - secondPlayer.Armor);
                                secondPlayer.Armor = 0;
                            }
                        }
                        else
                        {
                            secondPlayer.MageHealth -= (int)spell.Damage;
                        }
                    }

                    if (spell.Name != "critical" && spell.Name != "hibernate" && spell.Name != "armorup" && spell.Name != "berserk"
                       && spell.Name != "mirrorimage")
                    {
                        ActionResultScreen.GoToActionResultScreenWM(firstPlayer, secondPlayer, spell);
                    }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreenWMExceptions(firstPlayer, secondPlayer, spell);
                    }

                    if (spell.Name == "mirrorimage")
                    {
                        firstPlayer.OnTurn = true;
                        secondPlayer.OnTurn = false;
                    }
                    else
                    {
                        secondPlayer.OnTurn = true;
                        firstPlayer.OnTurn = false;
                    }

                    if (firstPlayer.WarriorHealth <= 0 || secondPlayer.MageHealth <= 0)
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }

                }
                else if(secondPlayer.OnTurn)
                {
                    var spell = GetMageCommands.ClassChecker(secondPlayer);
                    if (firstPlayer.WarriorHealth <= 350 && spell.Execution == true)
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }

                    while (spell.Execution == true)
                    {
                        Console.WriteLine("TARGET'S HP IS NOT LOW ENOUGH FOR THIS SPELL, PRESS ENTER TO CHOOSE A DIFFERENT SPELL");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetMageCommands.ClassChecker(secondPlayer);
                    }

                    while(CoolDownChecker.CheckCooldownMage(secondPlayer, spell))
                    {
                        Console.WriteLine(@"SPELL IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetMageCommands.ClassChecker(secondPlayer);
                    }

                    if(spell.Name == "manaregeneration")
                    {
                        secondPlayer.MageMana += spell.GetMana;
                    }

                    if(spell.Name == "frostarmor" || spell.Name == "firearmor")
                    {
                        secondPlayer.Armor += spell.GetArmor;
                    }

                    if (firstPlayer.DamageReduction == true)
                    {
                        spell.Damage *= 0.5;
                        firstPlayer.DamageReduction = false;
                    }

                    if(spell.Name == "frostbolt" || spell.Name == "frostarmor")
                    {
                        secondPlayer.FrostReduction = true;
                        secondPlayer.FrostReductionDuration = 2;
                    }

                    if(secondPlayer.FrostAmplified == true || secondPlayer.ArcaneAmplified == true)
                    {
                        secondPlayer.FrostAmplifierDuration--;
                        secondPlayer.ArcaneAmplifierDuration--;
                        if(secondPlayer.ArcaneAmplified == true)
                        {
                            spell.Damage *= 2;
                        }
                        else if(secondPlayer.FrostAmplified)
                        {
                            spell.Damage *= 1.5;
                        }

                        if(secondPlayer.FrostAmplifierDuration == 0 || secondPlayer.ArcaneAmplifierDuration ==0)
                        {
                            secondPlayer.FrostAmplified = false;
                            secondPlayer.ArcaneAmplified = false;
                        }
                    }

                    if(spell.Name == "icyveins" || spell.Name == "amplifier")
                    {
                        if(spell.Name == "icyveins")
                        {
                            secondPlayer.FrostAmplified = true;
                            secondPlayer.FrostAmplifierDuration = spell.Duration;
                        }
                        else if(spell.Name == "amplifier")
                        {
                            secondPlayer.ArcaneAmplified = true;
                            secondPlayer.ArcaneAmplifierDuration = spell.Duration;
                        }
                    }

                    if(secondPlayer.FrozenGroundCoolDown == 3)
                    {
                        if (firstPlayer.Type == "protector")
                        {
                            if(firstPlayer.WarriorArmor >= secondPlayer.MageSpellPower)
                            {
                                firstPlayer.WarriorArmor -= (int) secondPlayer.MageSpellPower;
                            }
                            else
                            {
                                firstPlayer.WarriorHealth -= (int)(secondPlayer.MageSpellPower - firstPlayer.WarriorArmor);
                                firstPlayer.WarriorArmor = 0;
                            }
                        }
                    }

                    if(spell.Damage > 0)
                    {
                        if (firstPlayer.Type == "protector")
                        {
                            if (firstPlayer.WarriorArmor >= spell.Damage)
                            {
                                firstPlayer.WarriorArmor -= (int)spell.Damage;
                            }
                            else
                            {
                                firstPlayer.WarriorHealth -= (int)(spell.Damage - firstPlayer.WarriorArmor);
                                firstPlayer.WarriorArmor = 0;
                            }
                        }
                        else
                        {
                            firstPlayer.WarriorHealth -= (int)spell.Damage;
                        }
                    }
                    secondPlayer.MageMana -= spell.ManaCost;

                    if (spell.Name != "polymorph" && spell.Name != "firearmor" && spell.Name != "frostarmor" && spell.Name != "amplifier"
                        && spell.Name != "manaregeneration" && spell.Name != "frozenground" && spell.Name != "icyveins")
                    {
                        ActionResultScreen.GoToActionResultScreenWM(firstPlayer, secondPlayer, spell);
                    }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreenWMExceptions(firstPlayer, secondPlayer, spell);
                    }

                    if (spell.Name == "frozenground" || spell.Name == "polymorph" || secondPlayer.PolymorphCoolDown >= 3)
                    {
                        firstPlayer.OnTurn = false;
                        secondPlayer.OnTurn = true;
                    }
                    else
                    {
                        firstPlayer.OnTurn = true;
                        secondPlayer.OnTurn = false;
                    }

                    if (firstPlayer.WarriorHealth <= 0 || secondPlayer.MageHealth <= 0)
                    {
                        GameEnd.GameEndWM(firstPlayer, secondPlayer);
                    }

                    firstPlayer.WarriorHealth += firstPlayer.WarriorHealthRegen;
                    secondPlayer.MageHealth += secondPlayer.MageHealthRegen;
                    secondPlayer.MageMana += secondPlayer.MageManaRegen;
                }
            }
        }

        public static void GameStartMM(Mage firstPlayer, Mage secondPlayer)
        {

        }

        public static void GameStartMW(Warrior secondPlayer, Mage firstPlayer)
        {
            firstPlayer.OnTurn = true;
            if (secondPlayer.ArmorEquipped == false && secondPlayer.Type == "protector")
            {
                secondPlayer.ArmorEquipped = true;
                secondPlayer.WarriorArmor += 300;
            }
            while (secondPlayer.WarriorHealth > 0 && firstPlayer.MageHealth > 0)
            {
                if (secondPlayer.OnTurn)
                {
                    var spell = GetWarriorCommands.ClassChecker(secondPlayer);
                    
                    if (firstPlayer.MageHealth <= 300 && spell.Execution == true)
                    {
                        GameEnd.GameEndWM(secondPlayer, firstPlayer);
                    }

                    while (spell.Execution == true)
                    {
                        Console.WriteLine("TARGET NOT EXECUTABLE, PRESS ENTER TO CHOOSE A DIFFERENT ACTION");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetWarriorCommands.ClassChecker(secondPlayer);
                    }

                    while (CoolDownChecker.CheckCoolDownWarr(secondPlayer, spell))
                    {
                        Console.WriteLine(@"ACTION IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetWarriorCommands.ClassChecker(secondPlayer);
                    }
                    if(spell.Name == "critical" || spell.Name == "berserk" || spell.Name == "hibernate" || spell.Name == "armorup")
                    {
                        if (spell.Name == "critical")
                        {
                            if (secondPlayer.CriticalStrike == true)
                            {
                                while (spell.Name == "critical")
                                {
                                    Console.WriteLine("YOU HAVE ALREADY LEVELED UP CRITICAL STRIKE");
                                    Console.WriteLine("PRESS ENTER TO SELECT A DIFFERENT ACTION");
                                    var enter = new ConsoleKeyInfo();
                                    enter = Console.ReadKey();
                                    while (enter.Key != ConsoleKey.Enter)
                                    {
                                        enter = Console.ReadKey();
                                    }
                                    spell = GetWarriorCommands.ClassChecker(secondPlayer);
                                }
                            }
                            else
                            {
                                secondPlayer.CriticalStrike = true;
                            }
                        }
                        else if (spell.Name == "hibernate")
                        {
                            secondPlayer.DamageReduction = true;
                        }
                        else if (spell.Name == "berserk")
                        {
                            secondPlayer.WarriorHealth -= 200;
                        }
                        else
                        {
                            secondPlayer.WarriorArmor += spell.GetArmor;
                        }
                    }

                    if (secondPlayer.CriticalStrike == true)
                    {
                        var critChance = new Random().Next(1, 11);
                        if (critChance <= 3)
                        {
                            Console.WriteLine("CRITICAL STRIKE!!!");
                            spell.Damage *= 2;
                        }
                    }

                    if (secondPlayer.BerserkModeCooldown >= 2)
                    {
                        spell.Damage *= 2;
                    }

                    if (secondPlayer.HibernateCooldown >= 1)
                    {
                        secondPlayer.WarriorHealth += (int)1.5 * secondPlayer.WarriorHealthRegen;
                    }

                    if (firstPlayer.FrostReduction == true)
                    {
                        spell.Damage *= 0.8;
                        firstPlayer.FrostReductionDuration--;
                        if(firstPlayer.FrostReductionDuration == 0)
                        {
                            firstPlayer.FrostReduction = false;

                        }
                    }

                    if (spell.Damage != 0)
                    {
                        if (firstPlayer.Type == "frost" || firstPlayer.Type == "fire")
                        {
                            if (firstPlayer.Type == "fire" && firstPlayer.FireArmorCoolDown >= 2)
                            {
                                secondPlayer.WarriorHealth -= (int)firstPlayer.MageSpellPower / 2;
                            }

                            if (firstPlayer.Armor >= (int)spell.Damage)
                            {
                                firstPlayer.Armor -= (int)spell.Damage;
                            }
                            else
                            {
                                firstPlayer.MageHealth -= (int)(spell.Damage - firstPlayer.Armor);
                                firstPlayer.Armor = 0;
                            }
                        }
                        else
                        {
                            firstPlayer.MageHealth -= (int)spell.Damage;
                        }
                    }

                    if (spell.Name != "critical" && spell.Name != "hibernate" && spell.Name != "armorup" && spell.Name != "berserk"
                        && spell.Name != "mirrorimage" && spell.Name != "SHIELD SLAM")
                    {
                        ActionResultScreen.GoToActionResultScreenWM(secondPlayer, firstPlayer, spell);
                    }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreenWMExceptions(secondPlayer, firstPlayer, spell);
                    }

                    if (spell.Name == "mirrorimage" || spell.Name == "SHIELD SLAM")
                    {
                        secondPlayer.OnTurn = true;
                        firstPlayer.OnTurn = false;
                    }
                    else
                    {
                        firstPlayer.OnTurn = true;
                        secondPlayer.OnTurn = false;
                    }

                    if (secondPlayer.WarriorHealth <= 0 || firstPlayer.MageHealth <= 0)
                    {
                        GameEnd.GameEndWM(secondPlayer, firstPlayer);
                    }

                    secondPlayer.WarriorHealth += secondPlayer.WarriorHealthRegen;
                    firstPlayer.MageHealth += firstPlayer.MageHealthRegen;
                    firstPlayer.MageMana += firstPlayer.MageManaRegen;

                }
                else if (firstPlayer.OnTurn)
                {
                    var spell = GetMageCommands.ClassChecker(firstPlayer);
                    if (secondPlayer.WarriorHealth <= 350 && spell.Execution == true)
                    {
                        GameEnd.GameEndWM(secondPlayer, firstPlayer);
                    }

                    while (spell.Execution == true)
                    {
                        Console.WriteLine("TARGET'S HP IS NOT LOW ENOUGH FOR THIS SPELL, PRESS ENTER TO CHOOSE A DIFFERENT SPELL");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetMageCommands.ClassChecker(firstPlayer);
                    }

                    while (CoolDownChecker.CheckCooldownMage(firstPlayer, spell))
                    {
                        Console.WriteLine(@"SPELL IS ON COOLDOWN, PRESS ENTER TO CHOOSE A DIFFERENT ONE");
                        var entry = new ConsoleKeyInfo();
                        entry = Console.ReadKey();
                        while (entry.Key != ConsoleKey.Enter)
                        {
                            entry = Console.ReadKey();
                        }
                        spell = GetMageCommands.ClassChecker(firstPlayer);
                    }

                    if (spell.Name == "manaregeneration")
                    {
                        firstPlayer.MageMana += spell.GetMana;
                    }

                    if (spell.Name == "frostarmor" || spell.Name == "firearmor")
                    {
                        firstPlayer.Armor += spell.GetArmor;
                    }

                    if (secondPlayer.DamageReduction == true)
                    {
                        spell.Damage *= 0.5;
                        secondPlayer.DamageReduction = false;
                    }

                    if (firstPlayer.FrozenGroundCoolDown == 3)
                    {
                        if (secondPlayer.Type == "protector")
                        {
                            if (secondPlayer.WarriorArmor >= firstPlayer.MageSpellPower)
                            {
                                secondPlayer.WarriorArmor -= (int)firstPlayer.MageSpellPower;
                            }
                            else
                            {
                                secondPlayer.WarriorHealth -= (int)(firstPlayer.MageSpellPower - secondPlayer.WarriorArmor);
                            }
                        }
                    }

                    if (firstPlayer.FrostAmplified == true || firstPlayer.ArcaneAmplified == true)
                    {
                        firstPlayer.FrostAmplifierDuration--;
                        firstPlayer.ArcaneAmplifierDuration--;
                        if (firstPlayer.ArcaneAmplified == true)
                        {
                            spell.Damage *= 2;
                        }
                        else if (firstPlayer.FrostAmplified)
                        {
                            spell.Damage *= 1.5;
                        }

                        if (firstPlayer.FrostAmplifierDuration == 0 || firstPlayer.ArcaneAmplifierDuration == 0)
                        {
                            firstPlayer.FrostAmplified = false;
                            firstPlayer.ArcaneAmplified = false;
                        }
                    }

                    if (spell.Name == "icyveins" || spell.Name == "amplifier")
                    {
                        if (spell.Name == "icyveins")
                        {
                            firstPlayer.FrostAmplified = true;
                            firstPlayer.FrostAmplifierDuration = spell.Duration;
                        }
                        else if(spell.Name == "amplifier")
                        {
                            firstPlayer.ArcaneAmplified = true;
                            firstPlayer.ArcaneAmplifierDuration = spell.Duration;
                        }
                    }

                    if (spell.Name == "frostbolt" || spell.Name == "frostarmor")
                    {
                        firstPlayer.FrostReduction = true;
                        firstPlayer.FrostReductionDuration = 2;
                    }

                    if (spell.Damage > 0)
                    {
                        if (secondPlayer.Type == "protector")
                        {
                            if (secondPlayer.WarriorArmor >= spell.Damage)
                            {
                                secondPlayer.WarriorArmor -= (int)spell.Damage;
                            }
                            else
                            {
                                secondPlayer.WarriorHealth -= (int)(spell.Damage - secondPlayer.WarriorArmor);
                            }
                        }
                        else
                        {
                            secondPlayer.WarriorHealth -= (int)spell.Damage;
                            secondPlayer.WarriorArmor = 0;
                        }
                    }
                    firstPlayer.MageMana -= spell.ManaCost;

                    if (spell.Name != "polymorph" && spell.Name != "firearmor" && spell.Name != "frostarmor" && spell.Name != "amplifier"
                        && spell.Name != "manaregeneration" && spell.Name != "frozenground" && spell.Name != "icyveins")
                    {
                        ActionResultScreen.GoToActionResultScreenWM(secondPlayer, firstPlayer, spell);
                    }
                    else
                    {
                        ActionResultScreen.GoToActionResultScreenWMExceptions(secondPlayer, firstPlayer, spell);
                    }

                    if (spell.Name == "frozenground" || spell.Name == "polymorph" || firstPlayer.PolymorphCoolDown >= 3)
                    {
                        firstPlayer.OnTurn = true;
                        secondPlayer.OnTurn = false;
                    }
                    else
                    {
                        firstPlayer.OnTurn = false;
                        secondPlayer.OnTurn = true;
                    }

                    if (secondPlayer.WarriorHealth <= 0 || firstPlayer.MageHealth <= 0)
                    {
                        GameEnd.GameEndWM(secondPlayer, firstPlayer);
                    }
                }
            }

            GameEnd.GameEndWM(secondPlayer, firstPlayer);
        }

        public static void GameStartWW(Warrior firstPlayer, Warrior secondPlayer)
        {
            
        }
    }
}
