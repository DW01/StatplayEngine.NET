using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.CellFunctions.CellTypes.WallCells
{
    // Special "Starting Cells". Position can be changed (not yet implemented, obviously).
    // Will probably become its own class file later.
    public class StartingCell : EmptyCell, ICell
    {
        // Implementation of interface contract methods.
        public override void InitialiseFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        public override void SetBreakability()
        {
            IsCellBreakable = false;
            CellHasHP = false;
        }

        public override void CreateCell()
        {
            CellName = "Starting Cell";
            CellID = CellName[0];
            CellDescriptor = "Used for populating the Starting Zone.";
            CellFormatter = "[color=#ff9933]{ }[/color]";
        }
    }
}
