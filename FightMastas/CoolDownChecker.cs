using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4B
{
    public class CoolDownChecker
    {
        //Cooldown checker for warriors
        public static bool CheckCoolDownWarr(Warrior warrior, CurrentSpell spell)
        {
            if (warrior.Type == "swordmaster")
            {
                if(spell.Name == "WINDFURY")
                {
                    if(warrior.WindFuryCooldown <= 0)
                    {
                        warrior.MirrorImageCooldown--;
                        warrior.WindFuryCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "mirrorimage")
                {
                    if(warrior.MirrorImageCooldown <= 0)
                    {
                        warrior.WindFuryCooldown--;
                        warrior.MirrorImageCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "BLADE SLASH")
                {
                    warrior.WindFuryCooldown--;
                    warrior.MirrorImageCooldown--;
                    return false;
                }
                else if(spell.Name == "critical")
                {
                    warrior.WindFuryCooldown--;
                    warrior.MirrorImageCooldown--;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if(warrior.Type == "berserker")
            {
                if (spell.Name == "AXE CHOP")
                {
                        warrior.BerserkModeCooldown--;
                        warrior.WildAxesCooldown--;
                        return false;
                }
                else if (spell.Name == "berserk")
                {
                    if (warrior.BerserkModeCooldown <= 0)
                    {
                        warrior.WildAxesCooldown--;
                        warrior.BerserkModeCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (spell.Name == "WILD AXES")
                {
                    if(warrior.WildAxesCooldown <= 0)
                    {
                        warrior.BerserkModeCooldown--;
                        warrior.WildAxesCooldown = spell.Cooldown;
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (spell.Name == "armorup")
                {
                    warrior.HibernateCooldown--;
                    return false;
                }
                else if (spell.Name == "MACE SWING")
                {
                    warrior.HibernateCooldown--;
                    return false;
                }
                else if(spell.Name == "hibernate")
                {
                    if(warrior.HibernateCooldown <= 0)
                    {
                        warrior.HibernateCooldown = 3;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    warrior.HibernateCooldown--;
                    return false;
                }
            }

            return true;
        }

        //Cooldown checker for mages
        public static bool CheckCooldownMage(Mage mage, CurrentSpell spell)
        {
            if(mage.Type == "fire")
            {
                
                if(spell.Name == "firearmor")
                {
                    if(mage.FireArmorCoolDown <= 0)
                    {
                        mage.PyroBlastCoolDown--;
                        mage.FireArmorCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "FIRE BLAST")
                {
                    mage.FireArmorCoolDown--;
                    mage.PyroBlastCoolDown--;
                    return false;
                }
                else
                {
                    if(mage.PyroBlastCoolDown <= 0)
                    {
                        mage.FireArmorCoolDown--;
                        mage.PyroBlastCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if(mage.Type == "frost")
            {
                if(spell.Name == "icyveins")
                {
                    if(mage.IcyVeinsCoolDown <= 0)
                    {
                        mage.FrostArmorCoolDown--;
                        mage.FrostArmorCoolDown--;
                        mage.FrozenGroundCoolDown--;
                        mage.FrozenGroundCoolDown--;
                        mage.IcyVeinsCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "frozenground")
                {
                    if(mage.FrozenGroundCoolDown <= 0)
                    {
                        mage.IcyVeinsCoolDown--;
                        mage.FrostArmorCoolDown--;
                        mage.FrozenGroundCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "frostarmor")
                {
                    if(mage.FrostArmorCoolDown <= 0)
                    {
                        mage.IcyVeinsCoolDown--;
                        mage.FrozenGroundCoolDown--;
                        mage.FrostArmorCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    mage.IcyVeinsCoolDown--;
                    mage.FrozenGroundCoolDown--;
                    mage.FrostArmorCoolDown--;
                    return false;
                }
            }
            else
            {
                if(spell.Name == "polymorph")
                {
                    if(mage.PolymorphCoolDown <= 0)
                    {
                        mage.ManaRegCoolDown--;
                        mage.AmplifierCoolDown--;
                        mage.PolymorphCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "amplifier")
                {
                    if(mage.AmplifierCoolDown <= 0)
                    {
                        mage.ManaRegCoolDown--;
                        mage.PolymorphCoolDown--;
                        mage.AmplifierCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if(spell.Name == "manaregeneration")
                {
                    if(mage.ManaRegCoolDown <= 0)
                    {
                        mage.PolymorphCoolDown--;
                        mage.AmplifierCoolDown--;
                        mage.ManaRegCoolDown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    mage.PolymorphCoolDown--;
                    mage.AmplifierCoolDown--;
                    mage.ManaRegCoolDown--;
                    return false;
                }
            }
        }
    }
}
