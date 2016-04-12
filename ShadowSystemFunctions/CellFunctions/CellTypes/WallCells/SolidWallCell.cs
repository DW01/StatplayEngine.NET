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

namespace ShadowSystem.CellFunctions.CellTypes.WallCells
{
    class SolidWallCell : Cell
    {
        // Construct Cell here. This is a solid, non-breakable Wall Cell.
        Cell solidWallCell = new Cell("W", "Wall Cell", "This is a [non-breakable] Wall Cell.", "{w}")
        {
            // TODO: Cell variables.
        };
    }
}
