using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class Mage
    {
        //Hero stats
        public string PlayerName { get; set; }

        public bool OnTurn { get; set; }

        public string Type { get; set; }

        public double MageDamage = 20;

        public int MageHealth = 1100;

        public int Armor = 0;

        public int MageMana = 2000;

        public int MageHealthRegen = 50;

        public int MageManaRegen = 50;

        public double MageSpellPower = 70;

        //Spell cooldown checkers and counters:

        //Frost Mage
        public int FrozenGroundCoolDown { get; set; }

        public int IcyVeinsCoolDown { get; set; }
        public bool FrostAmplified { get; set; }
        


        public int FrostArmorCoolDown { get; set; }


        public bool FrostReduction { get; set; }
        public int FrostReductionDuration { get; set; }

        //Fire Mage
        public int PyroBlastCoolDown { get; set; }

        public int FireArmorCoolDown { get; set; }

        //Arcane Mage
        public int AmplifierCoolDown { get; set; }
        public bool ArcaneAmplified { get; set; }
        public int ArcaneAmplifierDuration { get; set; }

        public int ManaRegCoolDown { get; set; }

        public int PolymorphCoolDown { get; set; }
    }
}
