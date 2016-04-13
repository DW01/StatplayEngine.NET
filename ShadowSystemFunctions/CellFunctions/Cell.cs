using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSystem.CellFunctions
{
    // Nonexistent Cell class and constructor for Cells to derive from.
    // Also includes virtual methods for cells to override.
    public class Cell : ICell
    {
        // Descriptor strings.
        public string CellName;
        public char CellID;
        public string CellDescriptor;
        public string CellFormatter;

        // Passability flags.
        public bool IsCellPassable;
        public bool IsCellOccupiable;
        public bool IsCellOccupied;
        public char CellOccupier;

        // Breakablility and block property.
        public bool IsCellBreakable;
        public bool CellHasHP;
        public double CellCurrentHP;
        public double CellMaxHP;
        public bool CellBlockProperty;

        // Helper methods.

        // Set cell flags here.
        // Will likely replace this later when I properly implement the grid.
        protected virtual void InitFlags()
        {
            IsCellPassable = false;
            IsCellOccupiable = false;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        protected virtual void InitBreakable()
        {
            IsCellBreakable = false;
        }

        protected virtual void InitCellHP()
        {
            CellHasHP = false;
            CellCurrentHP = 0;
            CellMaxHP = 0;
        }

        protected virtual void InitCellInfo()
        {
            CellName = "Cell";
            CellID = CellName[0];
            CellDescriptor = "A nonexistent Cell -- mostly a placeholder..";
            CellFormatter = "{ }";
        }

        // Interface method declarations so we can run the helpers.
        public void InitialiseFlags()
        {
            InitFlags();
        }

        public void InitialiseBreakability()
        {
            InitBreakable();
            InitCellHP();
        }

        public void CreateCell()
        {
            InitCellInfo();
        }

        // Constructor for all other Cells to use.
        public Cell()
        {
            InitialiseFlags();
            InitialiseBreakability();
            CreateCell();
        }
    }
}
