using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightMastas.ActionsWarrior;


namespace FightMastas
{
    class GetWarriorCommands
    {
        public static CurrentSpell ClassChecker(Warrior warrior)
        {
            var currentSpell = new CurrentSpell();
            if(warrior.Type == "berserker")
            {
                currentSpell = BerserkerCommands(warrior);
            }
            else if(warrior.Type == "swordmaster")
            {
                currentSpell = SwordMCommands(warrior);
            }
            else
            {
                currentSpell = ProtectorCommands(warrior);
            }

            return currentSpell;
        }

        private static CurrentSpell ProtectorCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string shieldSlam = $"SHIELD SLAM-- DAMAGE:{warrior.WarriorArmor} COOLDOWN: 2";
                string maceSwing = $"MACE SWING-- DAMAGE:{warrior.WarriorDamage}";
                string armorUp = $"ARMOR UP-- ARMOR:{warrior.ShieldArmor * 2}";
                string hibernate = $"HIBERNATE-- HEAL FOR {warrior.WarriorHealthRegen*3} TAKE 50% DAMAGE REDUCTION FOR NEXT ROUND, COOLDOWN: 3";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}", "-> " + shieldSlam);
                        Console.WriteLine("{0,2}", maceSwing);
                        Console.WriteLine("{0,2}", armorUp);
                        Console.WriteLine("{0,2}", hibernate);break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", shieldSlam);
                        Console.WriteLine("{0,2}", "-> " + maceSwing);
                        Console.WriteLine("{0,2}", armorUp);
                        Console.WriteLine("{0,2}", hibernate); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", shieldSlam);
                        Console.WriteLine("{0,2}", maceSwing);
                        Console.WriteLine("{0,2}", "-> " + armorUp);
                        Console.WriteLine("{0,2}", hibernate); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0,2}", "-> " + shieldSlam);
                            Console.WriteLine("{0,2}", maceSwing);
                            Console.WriteLine("{0,2}", armorUp);
                            Console.WriteLine("{0,2}", hibernate); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0,2}", shieldSlam);
                            Console.WriteLine("{0,2}", maceSwing);
                            Console.WriteLine("{0,2}", armorUp);
                            Console.WriteLine("{0,2}", "-> " + hibernate); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch(counter)
            {
                case 1:
                    var shieldSlam = new ShieldSlam();
                    currentSpell = shieldSlam.GetShieldSlam(warrior);
                    break;
                case 2:
                    var maceSwing = new MaceSwing();
                    currentSpell = maceSwing.GetMaceSwing();
                    break;
                case 3:
                    var armorUpSpell = new ArmorUp();
                    currentSpell = armorUpSpell.GetArmorUp(warrior);
                    break;
                default:
                    var hibernate = new Hibernate();
                    currentSpell = hibernate.GetHibernate(warrior);
                    break;
            }

            return currentSpell;
            
        }

        private static CurrentSpell SwordMCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string levelUpCrit = $"CRITICAL STRIKE-- LOSE THIS TURN AND HAVE 30% CHANCE FOR 2X CRITICAL STRIKE FOR EACH ACTION YOUR SWORDMASTER DOES UNTIL END OF GAME";
                string mirrorImage = $"MIRROR IMAGE-- YOUR OPONENT LOSES 1 TURN, YOU DEAL {warrior.WarriorDamage} TO HIM, COOLDOWN: 3";
                string bladeSlash = $"BLADESLASH-- DAMAGE:{warrior.WarriorDamage * 2}";
                string windFury = $"WINDFURY-- DAMAGE:{warrior.WarriorDamage * 5} COOLDOWN: 4";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}", "-> " + levelUpCrit);
                        Console.WriteLine("{0,2}", mirrorImage);
                        Console.WriteLine("{0,2}",  bladeSlash);
                        Console.WriteLine("{0,2}", windFury); break;
                    case 2:
                        Console.WriteLine("{0,2}",  levelUpCrit);
                        Console.WriteLine("{0,2}", "-> " + mirrorImage);
                        Console.WriteLine("{0,2}", bladeSlash);
                        Console.WriteLine("{0,2}", windFury); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}", levelUpCrit);
                        Console.WriteLine("{0,2}", mirrorImage);
                        Console.WriteLine("{0,2}", "-> " + bladeSlash);
                        Console.WriteLine("{0,2}", windFury); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}", levelUpCrit);
                        Console.WriteLine("{0,2}", mirrorImage);
                        Console.WriteLine("{0,2}", bladeSlash);
                        Console.WriteLine("{0,2}", "-> " + windFury); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0,2}", "-> " + levelUpCrit);
                            Console.WriteLine("{0,2}", mirrorImage);
                            Console.WriteLine("{0,2}", bladeSlash);
                            Console.WriteLine("{0,2}", windFury); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0,2}", levelUpCrit);
                            Console.WriteLine("{0,2}", mirrorImage);
                            Console.WriteLine("{0,2}", bladeSlash);
                            Console.WriteLine("{0,2}", "-> " + windFury); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch (counter)
            {
                case 1:
                    var criticalStrike = new CriticalStrike();
                    currentSpell = criticalStrike.TurnOnCrit(warrior);
                    break;
                case 2:
                    var mirrorImage = new MirrorImage();
                    currentSpell = mirrorImage.GetMirrorImage();
                    break;
                case 3:
                    var slash = new BladeSlash();
                    currentSpell = slash.GetSlash(warrior);
                    break;
                default:
                    var windfury = new Windfury();
                    currentSpell = windfury.GetWindFury(warrior);
                    break;
            }

            return currentSpell;
        }

        private static CurrentSpell BerserkerCommands(Warrior warrior)
        {
            ConsoleKeyInfo enter = new ConsoleKeyInfo();
            Console.Clear();

            var counter = 1;
            while (enter.Key != ConsoleKey.Enter)
            {
                if (enter.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (enter.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }

                Program.GameTitle();
                string actionSelect = $"SELECT ACTION FOR {warrior.PlayerName}";
                string goBerserk = $"BERSERK MODE-- DO DOUBLE DAMAGE FOR THREE ROUNDS, COST: 200HP, COOLDOWN: 5";
                string axeChop = $"AXE CHOP-- DAMAGE:{warrior.WarriorDamage * 2}";
                string wildAxes = $"WILD AXES-- DAMAGE:{warrior.WarriorDamage * 4}, COOLDOWN: 3";
                string execute = $"EXECUTE-- KILL ENEMY IF HIS HP IS BELOW 300";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}", "-> " + goBerserk);
                        Console.WriteLine("{0,2}", axeChop);
                        Console.WriteLine("{0,2}", wildAxes);
                        Console.WriteLine("{0,2}", execute); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", goBerserk);
                        Console.WriteLine("{0,2}", "-> " + axeChop);
                        Console.WriteLine("{0,2}", wildAxes);
                        Console.WriteLine("{0,2}", execute); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0,2}",  goBerserk);
                        Console.WriteLine("{0,2}", axeChop);
                        Console.WriteLine("{0,2}", "-> " + wildAxes);
                        Console.WriteLine("{0,2}", execute); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", goBerserk);
                        Console.WriteLine("{0,2}", axeChop);
                        Console.WriteLine("{0,2}", wildAxes);
                        Console.WriteLine("{0,2}", "-> " + execute); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0,2}", "-> " + goBerserk);
                            Console.WriteLine("{0,2}", axeChop);
                            Console.WriteLine("{0,2}", wildAxes);
                            Console.WriteLine("{0,2}", execute); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0,2}", goBerserk);
                            Console.WriteLine("{0,2}", axeChop);
                            Console.WriteLine("{0,2}", wildAxes);
                            Console.WriteLine("{0,2}", "-> " + execute); break;
                        }
                        break;
                }
                enter = Console.ReadKey();
                Console.Clear();
            }
            var currentSpell = new CurrentSpell();
            switch (counter)
            {
                case 1:
                    var berserk = new Berserk();
                    currentSpell = berserk.GoBerserk(warrior);
                    break;
                case 2:
                    var axeHit = new AxeChop();
                    currentSpell = axeHit.GetHit(warrior);
                    break;
                case 3:
                    var wildAxe = new WildAxes();
                    currentSpell = wildAxe.GetWildAxes(warrior);
                    break;
                default:
                    var execution = new Execute();
                    currentSpell = execution.GetExecution(warrior);
                    break;
            }

            return currentSpell;
        }
    }
}
