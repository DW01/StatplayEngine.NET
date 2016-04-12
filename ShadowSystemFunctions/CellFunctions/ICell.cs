using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.CellFunctions
{
    public interface ICell
    {
        void InitialiseFlags();
        void SetBreakability();
        void CreateCell();
    }
}
