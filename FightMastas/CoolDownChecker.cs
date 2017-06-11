using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightMastas
{
    public class CoolDownChecker
    {
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

        public static bool CheckCoolDownMage(Mage mage, CurrentSpell spell)
        {
            return false;
        }
    }
}
