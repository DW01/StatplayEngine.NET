using ShadowSystem.GridFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbitraryGridTester
{
    public partial class GUIGridTester : Form
    {
        TextBoxWriter consoleWriter = null;
        public GUIGridTester()
        {
            InitializeComponent();
            this.Text = "Arbitrary Grid Size Tester";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Integer conversion of numericUpDowns.
            int XCells = (int)CellsOnX.Value;
            int YCells = (int)CellsOnY.Value;

            // Construct grid.
            outputBox.Clear();
            consoleWriter = new TextBoxWriter(outputBox);
            Console.SetOut(consoleWriter);
            Grid grid = new Grid(XCells, YCells);
            Console.Write(grid);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.CellsOnX.Value = 9;
            this.CellsOnY.Value = 9;
        }

        private void printToFile_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            Console.Write("Not yet implemented.");
        }
    }
}
