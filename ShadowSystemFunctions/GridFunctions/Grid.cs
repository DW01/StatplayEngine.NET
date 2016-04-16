using System;
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
            for (int y = 0; y < GridArray.GetLength(0); y++)
            {
                for (int x = 0; x < GridArray.GetLength(1); x++)
                {
                    EmptyCell emptyCell = new EmptyCell();
                    Console.Write(emptyCell.GetCellFormatter() + " ");                   
                }

                for (char v = 'A'; v > GridArray.GetUpperBound(1); v++)
                {
                    if (v < 'Z')
                    {
                        Console.Write(Char.ToString(v));
                    }
                    else if (v == 'Z')
                    {
                        Console.Write(Char.ToString(v));
                    }
                }
                Console.Write(Environment.NewLine);
            }         
        }

        // Add x-axis labels along bottom.
        public void AddXLabels()
        {
            Console.Write("-");

            for (int u = 1; u <= GridArray.GetLength(1); u++)
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
            Grid.GridXAxis = 9;
            Grid.GridYAxis = 9;

            RenderGrid();
            AddXLabels();
            GridArray.Initialize();
        }

        // Constructor to create an arbitrary grid.
        public Grid(int GridXAxis, int GridYAxis)
        {
            Grid.GridXAxis = GridXAxis;
            Grid.GridYAxis = GridYAxis;

            RenderGrid();
            AddXLabels();
            GridArray.Initialize();

        }
    }
}
