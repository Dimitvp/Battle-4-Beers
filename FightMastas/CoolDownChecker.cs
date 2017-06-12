using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class CoolDownChecker
    {
        //Cooldown checker for warriors
        public static bool CheckCoolDownWarr(Warrior warrior, CurrentSpell spell)
        {
            warrior.BerserkModeCooldown--;
            warrior.DoubleAttackCooldown--;
            warrior.ArmorUpCooldown--;
            warrior.ShieldSlamCooldown--;
            warrior.WindFuryCooldown--;

            if (spell.Name == "berserk")
            {
                if(!warrior.BerserkModeIsCD)
                {
                    warrior.BerserkModeIsCD = true;
                    warrior.BerserkModeCooldown = spell.Cooldown;
                    return false;
                }
                else
                {
                    
                    if(warrior.BerserkModeCooldown <= 0)
                    {
                        warrior.BerserkModeCooldown = spell.Cooldown;
                        warrior.BerserkModeIsCD = true;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (spell.Name == "dual")
            {
                if (!warrior.DoubleAttackIsCD)
                {
                    warrior.DoubleAttackIsCD = true;
                    warrior.DoubleAttackCooldown = 2;
                    return false;
                }
                else
                {
                    warrior.DoubleAttackCooldown--;
                    if (warrior.DoubleAttackCooldown <= spell.Cooldown)
                    {
                        warrior.DoubleAttackIsCD = true;
                        warrior.DoubleAttackCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (spell.Name == "dual")
            {
                if (!warrior.ShieldSlamIsCD)
                {
                    warrior.ShieldSlamIsCD = true;
                    warrior.ShieldSlamCooldown = spell.Cooldown;
                    return false;
                }
                else
                {
                    warrior.ShieldSlamCooldown--;
                    if (warrior.ShieldSlamCooldown <= 0)
                    {
                        warrior.DoubleAttackIsCD = true;
                        warrior.ShieldSlamCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (spell.Name == "armor")
            {
                if (!warrior.ArmorUpIsCD)
                {
                    warrior.ArmorUpIsCD = true;
                    warrior.ArmorUpCooldown = spell.Cooldown;
                    return false;
                }
                else
                {
                    warrior.ArmorUpCooldown--;
                    if (warrior.ArmorUpCooldown <= 0)
                    {
                        warrior.ArmorUpIsCD = true;
                        warrior.ArmorUpCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (spell.Name == "windfury")
            {
                if (!warrior.WindFuryIsCd)
                {
                    warrior.WindFuryIsCd = true;
                    warrior.WindFuryCooldown = spell.Cooldown;
                    return false;
                }
                else
                {
                    warrior.WindFuryCooldown--;
                    if (warrior.WindFuryCooldown <= 0)
                    {
                        warrior.WindFuryIsCd = true;
                        warrior.WindFuryCooldown = spell.Cooldown;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if(spell.Name == "slash")
            {
                return false;
            }
            else
            {
                return false;
            }

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
                else if(spell.Name == "fireblast")
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
