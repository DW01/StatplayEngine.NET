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

        // Getter / setter methods, used by the grid.

        // Return cell name.
        public string GetCellName()
        {
            return CellName;
        }

        // Set cell name.
        //
        // @param CellName
        public void SetCellName(string CellName)
        {
            this.CellName = CellName;
        }

        // Get Cell ID.
        public char GetCellID()
        {
            return CellID;
        }

        // Set cell ID.
        //
        // @param CellName
        public void SetCellID(char CellID)
        {
            this.CellID = CellID;
        }

        // Get cell description from string Cell.CellDescriptor.
        public string GetCellDescriptor()
        {
            return CellDescriptor;
        }

        // Set cell description.
        //
        // @param CellDescriptor - Description of CellType.
        public void SetCellDescriptor(string CellDescriptor)
        {
            this.CellDescriptor = CellDescriptor;
        }

        // Get CellFormatter
        public string GetCellFormatter()
        {
            return CellFormatter;
        }

        // Set CellFormatter.
        //
        // @param CellFormatter - How the CellType is formatted on the grid.
        public void SetCellFormatter(string CellFormatter)
        {
            this.CellFormatter = CellFormatter;
        }

        // Return whether Cell of type x is passable by Units or not.
        public bool GetCellPassability()
        {
            return IsCellPassable;
        }

        // Set passability of any given CellType.
        //
        // @param IsCellPassable
        public void SetCellPassability(bool IsCellPassable)
        {
            this.IsCellPassable = IsCellPassable;
        }

        // Return whether Cell is occupiable by any Unit.
        // TODO: also run check to see if Cell is occupied.
        public bool GetCellOccupiability()
        {
            return IsCellOccupiable;
        }

        // Set occupiability of CellType.
        // TODO: also run check to see if Cell is occupied.
        //
        // @param IsCellOccupiable
        public void SetCellOccupiability(bool IsCellOccupiable)
        {
            this.IsCellOccupiable = IsCellOccupiable;
        }

        // Get cell occupier ID.
        public char GetCellOccupier()
        {
            return CellOccupier;
        }

        // Set Cell's Occupier.
        //
        // @param CellOccupier
        public void SetCellOccupier(char CellOccupier)
        {
            this.CellOccupier = CellOccupier;
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
