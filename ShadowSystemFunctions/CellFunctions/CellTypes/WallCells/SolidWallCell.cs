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
    class SolidWallCell : EmptyCell, ICell
    {
        // Helper function overrides.
        protected override void SetFlags()
        {
            IsCellPassable = false;
            IsCellOccupiable = false;
            IsCellOccupied = true;
            CellBlockProperty = true;
        }

        protected override void SetBreakable()
        {
            IsCellBreakable = false;
        }

        protected override void SetCellHP()
        {
            CellHasHP = false;
            CellCurrentHP = 0;
            CellMaxHP = 0;
        }

        protected override void SetCellInfo()
        {
            CellName = "Unbreakable Wall Cell";
            CellID = CellName[12];
            CellDescriptor = "A solid, unbreakable Wall Cell.";
            CellFormatter = String.Concat("{ ", Char.ToString(Char.ToLower(CellName[12])), " }", "");
        }
    }
}
