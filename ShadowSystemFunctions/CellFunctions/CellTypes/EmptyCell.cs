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
        private string CellName;
        private char CellID;
        private string CellDescriptor;
        private string CellFormatter;

        // Passability flags.
        private bool IsCellPassable;
        private bool IsCellOccupiable;
        private bool IsCellOccupied;

        // Breakablility and block property.
        private bool IsCellBreakable;
        private bool CellHasHP;
        private double CellCurrentHP;
        private double CellMaxHP;
        private bool CellBlockProperty;

        // Implementation of interface contract methods.
        public void InitialiseFlags()
        {
            IsCellPassable = true;
            IsCellOccupiable = true;
            IsCellOccupied = false;
            CellBlockProperty = false;
        }

        public void SetBreakability()
        {
            IsCellBreakable = false;
            CellHasHP = false;
        }

        public void CreateCell()
        {
            CellName = "Empty Cell";
            CellID = CellName[0];
            CellDescriptor = "An empty Cell.";
            CellFormatter = "[color=#ff9933]{ }[/color]";
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
