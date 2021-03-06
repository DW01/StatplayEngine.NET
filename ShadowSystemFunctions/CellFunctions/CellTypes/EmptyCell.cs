﻿/************************************************************/
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
    public class EmptyCell : Cell, ICell
    {
        // Helper methods.
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
            CellName = "Empty Cell";
            CellID = CellName[0];
            CellDescriptor = "A blank Empty Cell.";
            CellFormatter = "{ }";
        }
        // Implementation of interface contract methods.
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

        // Constructor.
        public EmptyCell()
        {
            InitialiseFlags();
            InitialiseBreakability();
            CreateCell();
        }
 

    }
     
}

