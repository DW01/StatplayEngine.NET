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

        // Implementation of interface contract methods.
        public virtual void InitialiseFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        public virtual void SetBreakability()
        {
            IsCellBreakable = false;
            CellHasHP = false;
        }

        public virtual void CreateCell()
        {
            CellName = "Empty Cell";
            CellID = CellName[0];
            CellDescriptor = "An empty Cell.";
            CellFormatter = "{ }";
        }

        // Constructor.
        public EmptyCell ()
        {
            InitialiseFlags();
            SetBreakability();
            CreateCell();
        }

        // Run constructor, return.
        EmptyCell emptyCell = new EmptyCell();
     
    }
}
