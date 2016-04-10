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

namespace CellFunctions
{
    // Cell base class. Provides methods, variables and structures to systems inheriting it.
    public class Cell
    {
        // Cell variable initialisation.
        // Variables like BlockProperty, CellIdentifier, CellName, CellOccupier, IsCellOccupied, IsCellOccupiable, etc.. get initialised and given default values here.

        // Cell type variables, including BlockProperty. 
        private string CellIdentifier;
        private string CellName;
        private string CellDescriptor;
        private string CellFormatter;
        private bool BlockProperty;


        // Cell occupation status variables.
        private bool IsCellOccupiable;
        private bool IsCellOccupied;
        private string CellOccupier; // Generally, this will be the same as CellIdentifier. TODO: Multiple cell occupiers; mainly to support status effects like Airborne.
        private bool IsCellVoid;
        private bool IsCellPassable;

        // Special HP / toughness variables, mainly to support breakable objects.
        private int CellCurrentHP;
        private int CellMaxHP;

        // Empty cell constructor. Takes no arguments, and is used in the EmptyCell class.
        public Cell ()
        {
            // Identifier, name and representation on grid.
            CellIdentifier = "B";
            CellName = "Blank Cell";
            CellDescriptor = "Used for empty Cells.";
            CellFormatter = "{ }";

            // Basic properties; the cell is solid empty ground, so set accordingly.
            IsCellVoid = false;
            IsCellOccupied = false;
            IsCellOccupiable = true;
            IsCellPassable = true;
            BlockProperty = false;

            // Cell is occupied by nobody, so we use NULL here.
            CellOccupier = null;
        }

    }

}
