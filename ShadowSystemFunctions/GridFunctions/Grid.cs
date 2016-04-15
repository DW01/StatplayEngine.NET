﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShadowSystem.CellFunctions;
using ShadowSystem.CellFunctions.CellTypes;

namespace ShadowSystem.GridFunctions
{
    public class Grid : IGrid
    {
        // 2D array, to be iterated over in RenderGrid();
        private static int GridXAxis, GridYAxis;
        private int[,] GridArray = new int[GridXAxis, GridYAxis];

        // Grid renderer.
        public void RenderGrid()
        {
            for (int y = 0; y < GridYAxis; y++)
            {
                for (int x = 0; x < GridXAxis; x++)
                {
                    EmptyCell emptyCell = new EmptyCell();
                    Console.Write(emptyCell.GetCellFormatter() + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        // Add x-axis labels along bottom.
        public void AddXLabels()
        {
            Console.Write("-");

            for (int u = 1; u <= GridXAxis; u++)
            {
                if (u < 9)
                {
                    Console.Write(u + "---");
                }
                else if (u == 9)
                {
                    Console.Write(u + "--");
                }
                else if (u >= 10)
                {
                    if ((u % 10) == 0)
                    {
                        Console.Write(u / 10 + " 0" + "-");
                    }
                    else
                    {
                        Console.Write(u / 10 + " " + (u % 10) + "-");
                    }
                }
            }
            Console.Write(Environment.NewLine);
        }

        // Default constructor for a nine by nine grid, because fuck Eebit.
        public Grid()
        {
            GridXAxis = 9;
            GridYAxis = 9;

            RenderGrid();
            AddXLabels();
        }

        // Constructor to create an arbitrary grid.
        public Grid(int GridXAxis, int GridYAxis)
        {
            Grid.GridXAxis = GridXAxis;
            Grid.GridYAxis = GridYAxis;

            RenderGrid();
            AddXLabels();
            // AddYLabels(); not implemented yet

        }
    }
}
