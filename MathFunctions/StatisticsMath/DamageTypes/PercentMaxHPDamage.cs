/************************************************************/
/*     ZEJ Roleplaying Statistical RP Engine, .NET Port     */
/*  ------------------------------------------------------  */
/*      Original concept by Jake "Eebit" Fryer, in Java     */
/*   C# / .NET / Mono port by Kevin "Nebulon Ranger" Reay   */
/*  ------------------------------------------------------  */
/*          Copyright (c) 2016 Eebit, Nebulon Ranger.       */
/*        Stat systems copyright (c) their creators.        */
/************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions.StatisticsMath
{
    // Percent Max HP Damage class. Used for StatusEffects such as Poison.
    class PercentMaxHPDamage : IDamage
    {
        // Doubles used for calculations.
        private double PercentageAsDecimal;
        private double TargetUnitMaxHP;
        private double ResultantDamage;

        // Calculate damage here. Enjoy dying, faggots.
        public double CalculateDamage ()
        {
            // Do the percentage calculations, then return.
            ResultantDamage = PercentageAsDecimal / TargetUnitMaxHP * 100;

            // Yet another if / else to prevent Damage from going under 1.
            if (ResultantDamage < 1)
            {
                ResultantDamage = 1;
                return ResultantDamage;
            }
            else
            {
                Math.Round(ResultantDamage, 0);
                return ResultantDamage;
            }

        }
    }
}
