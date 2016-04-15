using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.GridFunctions
{
    // Grid rendering method interface.
    public interface IGrid
    {
        void RenderGrid();
        void AddXLabels();
    }
}
