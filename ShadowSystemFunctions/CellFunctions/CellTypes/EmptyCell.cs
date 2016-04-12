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

namespace ShadowSystem.CellFunctions.CellTypes
{
    // Empty cell class, as referenced in CellBase.cs
    public class EmptyCell : ICell
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

        // Breakablility and block property.
        public bool IsCellBreakable;
        public bool CellHasHP;
        public double CellCurrentHP;
        public double CellMaxHP;
        public bool CellBlockProperty;

        // Helper methods.
        protected virtual void SetFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        protected virtual void SetBreakable()
        {
            IsCellBreakable = false;
        }

        protected virtual void SetCellHP()
        {
            CellHasHP = false;
            CellCurrentHP = 0;
            CellMaxHP = 0;
        }

        protected virtual void SetCellInfo()
        {
            CellName = "Empty Cell";
            CellID = CellName[0];
            CellDescriptor = "A blank Empty Cell.";
            CellFormatter = "{ }";
        }
        // Implementation of interface contract methods.
        public void InitialiseFlags()
        {
            SetFlags();
        }

        public void InitialiseBreakability()
        {
            SetBreakable();
            SetCellHP();
        }

        public void CreateCell()
        {
            SetCellInfo();
        }
        // Constructor.
        public EmptyCell()
        {
            InitialiseFlags();
            InitialiseBreakability();
            CreateCell();
        }

        // Run constructor, return.
        EmptyCell emptyCell = new EmptyCell();

    }
     
}

