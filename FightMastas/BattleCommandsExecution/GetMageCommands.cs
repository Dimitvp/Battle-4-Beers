using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B4B.SpellsAndActions;
using FightMastas.GameProperties;
using FightMastas;

namespace B4B 
{
    class GetMageCommands
    {
        public static CurrentSpell ClassChecker(Player mage)
        {
            var currentSpell = new CurrentSpell();
            if (mage.Type == "frost")
            {
                currentSpell = FrostMageCommands(mage);
            }
            else if (mage.Type == "fire")
            {
                currentSpell = FireMageCommands(mage);
            }
            else
            {
                currentSpell = ArcaneMageCommands(mage);
            }

            return currentSpell;
        }

        private static CurrentSpell ArcaneMageCommands(Player mage)
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

                GameTitle.GetTitle();
                string actionSelect = $"SELECT ACTION FOR {mage.Name}";
                string polymorph = $"POLYMORPH-- DISABLE TARGET FOR 2 TURNS, COST: 200 MANA, COOLDOWN: 4";
                string arcaneBlast = $"ARCANE BLAST-- DAMAGE:{mage.Spellpower * 3}, COST: 90 MANA, , NO COOLDOWN";
                string amplifier = $"AMPLIFY MAGIC-- DOUBLE SPELL DAMAGE FOR NEXT 2 TURNS, COST: 250 MANA, COOLDOWN: 4";
                string manaRegen = $"MANA REGENERATION-- GET 300 MANA, COOLDOWN: 3";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("{0,2}", "-> " + polymorph);
                        Console.WriteLine("{0,2}", arcaneBlast);
                        Console.WriteLine("{0,2}", amplifier);
                        Console.WriteLine("{0,2}", manaRegen); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("{0,2}", polymorph);
                        Console.WriteLine("{0,2}", "-> " + arcaneBlast);
                        Console.WriteLine("{0,2}", amplifier);
                        Console.WriteLine("{0,2}", manaRegen); break;
                    case 3:                                                                            
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("{0,2}", polymorph);
                        Console.WriteLine("{0,2}", arcaneBlast);
                        Console.WriteLine("{0,2}", "-> " + amplifier);
                        Console.WriteLine("{0,2}", manaRegen); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("{0,2}", polymorph);
                        Console.WriteLine("{0,2}", arcaneBlast);
                        Console.WriteLine("{0,2}",  amplifier);
                        Console.WriteLine("{0,2}", "-> " + manaRegen); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("{0,2}", "-> " + polymorph);
                            Console.WriteLine("{0,2}", arcaneBlast);
                            Console.WriteLine("{0,2}", amplifier);
                            Console.WriteLine("{0,2}", manaRegen); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("{0,2}", polymorph);
                            Console.WriteLine("{0,2}", arcaneBlast);
                            Console.WriteLine("{0,2}", amplifier);
                            Console.WriteLine("{0,2}", "-> " + manaRegen); break;
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
                    var polymorph = new Polymorph();
                    currentSpell = polymorph.GetPolymorph(mage);
                    break;
                case 2:
                    var arcaneBlast = new ArcaneBlast();
                    currentSpell = arcaneBlast.GetArcaneBlast(mage);
                    break;
                case 3:
                    var amplifier = new Amplifier();
                    currentSpell = amplifier.GetAmplifier(mage);
                    break;
                default:
                    var manaReg = new ManaRegeneration();
                    currentSpell = manaReg.GetManaReg(mage);
                    break;
            }

            return currentSpell;

        }

        private static CurrentSpell FireMageCommands(Player mage)
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

                GameTitle.GetTitle();
                string actionSelect = $"SELECT ACTION FOR {mage.Name}";
                string fireBlast = $"FIRE BLAST-- DAMAGE:{mage.Spellpower * 2} COST: 120 MANA, NO COOLDOWN";
                string fireArmor = $"FIRE ARMOR-- GET 150 ARMOR AND 150 HEALTH, COST: 80 MANA, COOLDOWN: 3";
                string pyroBlast = $"PYRO BLAST-- DAMAGE:{mage.Spellpower * 5} COST: 250 MANA, COOLDOWN: 4";
                string incinerate = $"INCINERATE-- KILL ENEMY IF ENEMY HP IS BELOW 900";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", "-> " + fireBlast);
                        Console.WriteLine("{0,2}", fireArmor);
                        Console.WriteLine("{0,2}", pyroBlast);
                        Console.WriteLine("{0,2}", incinerate); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", fireBlast);
                        Console.WriteLine("{0,2}", "-> " + fireArmor);
                        Console.WriteLine("{0,2}",  pyroBlast);
                        Console.WriteLine("{0,2}", incinerate); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", fireBlast);
                        Console.WriteLine("{0,2}", fireArmor);
                        Console.WriteLine("{0,2}", "-> " + pyroBlast);
                        Console.WriteLine("{0,2}", incinerate); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0,2}", fireBlast);
                        Console.WriteLine("{0,2}",  fireArmor);
                        Console.WriteLine("{0,2}", pyroBlast);
                        Console.WriteLine("{0,2}", "-> " + incinerate); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0,2}", "-> " + fireBlast);
                            Console.WriteLine("{0,2}", fireArmor);
                            Console.WriteLine("{0,2}", pyroBlast);
                            Console.WriteLine("{0,2}", incinerate); break;
                        }
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("{0,2}", fireBlast);
                            Console.WriteLine("{0,2}", fireArmor);
                            Console.WriteLine("{0,2}", pyroBlast);
                            Console.WriteLine("{0,2}", "-> " + incinerate); break;
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
                    var fireBlast = new FireBlast();
                    currentSpell = fireBlast.GetFireBlast(mage);
                    break;
                case 2:
                    var fireArmor = new FireArmor();
                    currentSpell = fireArmor.GetFireArmor(mage);
                    break;
                case 3:
                    var pyroBlast = new PyroBlast();
                    currentSpell = pyroBlast.GetPyroBlast(mage);
                    break;
                default:
                    var incinerate = new Incinerate();
                    currentSpell = incinerate.Incineration(mage);
                    break;
            }

            return currentSpell;
        }

        private static CurrentSpell FrostMageCommands(Player mage)
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

                GameTitle.GetTitle();
                string actionSelect = $"SELECT ACTION FOR {mage.Name}"; 
                string frostArmor = $"FROST ARMOR-- GET 150 ARMOR, LOWER PHYSICAL DAMAGE BY 20% FOR 2 TURNS, COST: 100 MANA, COOLDOWN: 3";
                string frostBolt = $"FROST BOLT-- DAMAGE ENEMY FOR {mage.Spellpower * 2}, LOWER ENEMY PHYSICAL DAMAGE DONE BY 20% FOR 2 TURNS, COST: 90 MANA, NO COOLDOWN";
                string icyVeins = $"ICY VEINS-- LOWER COOLDOWN ON ALL SPELLS BY 1 TURN, GET 50% MORE SPELLPOWER FOR NEXT 3 TURNS, COST: 250 MANA, COOLDOWN: 4";
                string frozenGround = $"FROZEN GROUND-- STUN ENEMY FOR 1 TURN AND DAMAGE HIM FOR 2 TURNS BY {mage.Spellpower}, COST: 150 MANA, COOLDOWN: 4";
                Console.WriteLine("{0}", actionSelect);
                switch (counter)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", "-> " + frostArmor);
                        Console.WriteLine("{0,2}", frostBolt);
                        Console.WriteLine("{0,2}", icyVeins);
                        Console.WriteLine("{0,2}", frozenGround); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", frostArmor);
                        Console.WriteLine("{0,2}", "-> " + frostBolt);
                        Console.WriteLine("{0,2}", icyVeins);
                        Console.WriteLine("{0,2}", frozenGround); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", frostArmor);
                        Console.WriteLine("{0,2}", frostBolt);
                        Console.WriteLine("{0,2}", "-> " + icyVeins);
                        Console.WriteLine("{0,2}", frozenGround); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0,2}", frostArmor);
                        Console.WriteLine("{0,2}", frostBolt);
                        Console.WriteLine("{0,2}", icyVeins);
                        Console.WriteLine("{0,2}", "-> " + frozenGround); break;
                    default:
                        if (counter == 5)
                        {
                            counter = 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0,2}", "-> " + frostArmor);
                            Console.WriteLine("{0,2}", frostBolt);
                            Console.WriteLine("{0,2}", icyVeins);
                            Console.WriteLine("{0,2}", frozenGround); break;
                        }                        
                        else if (counter == 0)
                        {
                            counter = 4;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("{0,2}", frostArmor);
                            Console.WriteLine("{0,2}", frostBolt);
                            Console.WriteLine("{0,2}", icyVeins);
                            Console.WriteLine("{0,2}", "-> " + frozenGround); break;
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
                    var frostArmor = new FrostArmor();
                    currentSpell = frostArmor.GetFrostArmor(mage);
                    break;
                case 2:
                    var frostBolt = new FrostBolt();
                    currentSpell = frostBolt.GetFrostBolt(mage);
                    break;
                case 3:
                    var icyVeins = new IcyVeins();
                    currentSpell = icyVeins.GetIcyVeins(mage);
                    break;
                default:
                    var frozenGround = new FrozenGround();
                    currentSpell = frozenGround.GetFrozenGround(mage);
                    break;
            }

            return currentSpell;
        }
    }
}

  
