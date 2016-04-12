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

namespace ShadowSystem.MathFunctions.StatisticsMath.DamageTypes
{
    // Basic Damage class, used for direct attacks.
    public class BasicDamage : IDamage
    {
        // Variables for use in damage calculations, supplied by end-user.
        private double SourceOffense;
        private double PercentageAsDecimal;
        private double ResultantOffense;
        private double TargetDefense;
        private double ResultantDamage;

        // Basic implementation of damage calculations.
        public double CalculateDamage()
        {
            // Basic calculations.
            ResultantOffense = Math.Round ((SourceOffense * PercentageAsDecimal), 0);
            ResultantDamage = ResultantOffense - TargetDefense;

            // If / else to handle clamping / rounding.
            if (ResultantDamage < 1)
            {
                //Set ResultantDamage to 1 and be done with it.
                ResultantDamage = 1;
                return ResultantDamage;
            }
            else
            {
                // Round resultant damage to integer-space, then return it.
                Math.Round(ResultantDamage, 0);
                return ResultantDamage;
            }

        }

        // BasicDamage constructor. This is where the work gets done!
        public BasicDamage (double SourceOffense, double PercentageAsDecimal, double TargetDefense)
        {
            CalculateDamage ();
        }

    }

}
