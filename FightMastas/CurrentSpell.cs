using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class CurrentSpell
    {
        public string Name { get; set; }

        public string CritHit { get; set; }

        public double Damage { get; set; }

        public int ManaCost { get; set; }

        public int Cooldown { get; set; }

        public int Duration { get; set; }

        public int SacrificialHP { get; set; }

        public bool Execution { get; set; }

        public int GetMana { get; set; }

        public int GetHP { get; set; }

        public int GetArmor { get; set; }
        public bool FrostArmor = false;
        public double Amplifier { get; set; }

        public static bool SpellsExceptional(CurrentSpell spell)
        {
            List<string> spells = new List<string>() { "mirrorimage", "SHIELD SLAM", "polymorph", "frozenground"
            , "manaregeneration", "icyveins", "amplifier", "hibernate", "frostarmor", "firearmor", "critical", "berserk",
        "armorup"};

            if(spells.Contains(spell.Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         
    }
}
