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
        // Implementation of interface helper methods.
        protected override void SetFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
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
            CellName = "Starting Cell";
            CellID = CellName[0];
            CellDescriptor = "Used for populating the Starting Zone.";
            CellFormatter = "[color=#ff9933]{ }[/color]";
        }

        // Interface methods implemetation.
        new public void InitialiseFlags()
        {
            SetFlags();
        }

        new public void InitialiseBreakability()
        {
            SetBreakable();
            SetCellHP();
        }

        new public void CreateCell()
        {
            SetCellInfo();
        }

        // Constructor pass.
        public StartingCell()
        {
            InitialiseFlags();
            InitialiseBreakability();
            CreateCell();
        }

        StartingCell startingCell = new StartingCell();
    }
}
