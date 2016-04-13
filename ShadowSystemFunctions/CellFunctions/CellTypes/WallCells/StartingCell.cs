using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.CellFunctions.CellTypes.WallCells
{
    // Special "Starting Cells". Position can be changed (not yet implemented, obviously).
    // Will probably become its own class file later.
    public class StartingCell : Cell, ICell
    {
        // Implementation of interface helper methods.
        protected override void InitFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        protected override void InitBreakable()
        {
            IsCellBreakable = false;
        }

        protected override void InitCellHP()
        {
            CellHasHP = false;
            CellCurrentHP = 0;
            CellMaxHP = 0;
        }

        protected override void InitCellInfo()
        {
            CellName = "Starting Cell";
            CellID = CellName[0];
            CellDescriptor = "Used for populating the Starting Zone.";
            CellFormatter = "[color=#ff9933]{ }[/color]";
        }

        // Interface methods implemetation.
        new public void InitialiseFlags()
        {
            InitFlags();
        }

        new public void InitialiseBreakability()
        {
            InitBreakable();
            InitCellHP();
        }

        new public void CreateCell()
        {
            InitCellInfo();
        }
    }
}
