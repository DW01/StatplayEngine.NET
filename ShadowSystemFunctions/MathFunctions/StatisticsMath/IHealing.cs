using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.MathFunctions.StatisticsMath
{
    //Healing interface. All types of Healing implement these methods.
    public interface IHealing
    {
        double CalculateHealing();
    }
}
