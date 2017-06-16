using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class Player
    {
        public string Hero { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public bool OnTurn { get; set; }

        public int Damage { get; set; }

        public double Spellpower { get; set; }

        public int Health { get; set; }

        public int HealthRegen { get; set; }

        public int Mana { get; set; }

        public int ManaRegen { get; set; }

        public int Armor { get; set; }

        //Warrior Actions
        //Berserker spells
        public int WildAxesCooldown { get; set; }

        public int BerserkModeCooldown { get; set; }

        //Swordmaster spells
        public int MirrorImageCooldown { get; set; }

        public int WindFuryCooldown { get; set; }

        public bool CriticalStrike = false;

        //Protector spells
        public int ArmorUpCooldown { get; set; }

        public int HibernateCooldown { get; set; }
        public bool HibernateReduction { get; set; }

        public bool ArmorEquipped { get; set; }

        //Mage Spells
        //Frost Mage
        public int FrozenGroundCoolDown { get; set; }

        public int IcyVeinsCoolDown { get; set; }
        public bool FrostAmplified { get; set; }

        public int FrostArmorCoolDown { get; set; }

        public bool FrostReduction = false;
        public int FrostReductionDuration { get; set; }
        public int FrostAmplifierDuration { get; set; }
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
