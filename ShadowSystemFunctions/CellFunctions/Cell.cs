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

        // Get the Cell's Block Property.
        public bool GetCellBlockProperty()
        {
            return CellBlockProperty;
        }

        // Set the cell's block property.
        //
        // @param CellBlockProperty - does the Cell block magic or ranged projectiles?
        public void SetCellBlockProperty(bool CellBlockProperty)
        {
            this.CellBlockProperty = CellBlockProperty;
        }

        // Get cell breakability status (usually false).
        public bool GetCellBreakability()
        {
            return IsCellBreakable;
        }

        // Set whether cell is breakable or not.
        //
        // @param IsCellBreakable - Is the cell we're operating on going to be breakable?
        public void SetCellBreakability(bool IsCellBreakable)
        {
            this.IsCellBreakable = IsCellBreakable;
        }

        // Get whether Cell has HP.
        // Used for Unit Cells, other Cells use CON.
        public bool GetIfCellHasHP()
        {
            return CellHasHP;
        }

        // Set whether Cell has HP.
        // Used for Unit Cells, all other Cells use CON.
        //
        // @param CellHasHP - Does the Cell we're operating on have HP?
        public void SetIfCellHasHP(bool CellHasHP)
        {
            this.CellHasHP = CellHasHP;
        }

        // Unique method to get BOTH CellCurrentHP and CellMaxHP at the same time.
        public Tuple<double, double> GetCellHPValues()
        {
            return Tuple.Create(CellCurrentHP, CellMaxHP);
        }

        // Unique method to set BOTH CellCurrentHP and CellMaxHP at the same time.
        // Usually only need to call this when initially setting up the grid's UnitCells.
        //
        // @params CellCurrentHP, CellMaxHP - Cell HP values.
        public void SetCellHPValues(double CellHPValues)
        {
            this.CellCurrentHP = CellHPValues;
            this.CellMaxHP = CellHPValues;
        }

        // Get cell's current HP.
        public double GetCellCurrentHP()
        {
            return CellCurrentHP;
        }

        // Set cell's current HP.
        //
        // @param CellCurrentHP - The cell's current HP.
        public void SetCellCurrentHP(double CellCurrentHP)
        {
            this.CellCurrentHP = CellCurrentHP;
        }

        // Get Cell's Max HP, useful for Percent Max HP Damage or Healing.
        public double GetCellMaxHP()
        {
            return CellMaxHP;
        }

        // Set cell max HP.
        //
        // @param CellMaxHP - the Cell's maximum HP value.
        public void SetCellMaxHP(double CellMaxHP)
        {
            this.CellMaxHP = CellMaxHP;
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
