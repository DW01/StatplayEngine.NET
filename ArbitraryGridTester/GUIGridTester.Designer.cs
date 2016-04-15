namespace ArbitraryGridTester
{
    partial class GUIGridTester
    {
        private int NumCellsX, NumCellsY;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GridYAxis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CellsOnY = new System.Windows.Forms.NumericUpDown();
            this.CellsOnX = new System.Windows.Forms.NumericUpDown();
            this.printToFile = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellsOnY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellsOnX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Cells on X axis";
            // 
            // GridYAxis
            // 
            this.GridYAxis.AutoSize = true;
            this.GridYAxis.Location = new System.Drawing.Point(192, 27);
            this.GridYAxis.Name = "GridYAxis";
            this.GridYAxis.Size = new System.Drawing.Size(127, 13);
            this.GridYAxis.TabIndex = 2;
            this.GridYAxis.Text = "Number of Cells on Y axis";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CellsOnY);
            this.panel1.Controls.Add(this.CellsOnX);
            this.panel1.Controls.Add(this.printToFile);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GridYAxis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(126, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 136);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CellsOnY
            // 
            this.CellsOnY.Location = new System.Drawing.Point(195, 4);
            this.CellsOnY.Name = "CellsOnY";
            this.CellsOnY.Size = new System.Drawing.Size(120, 20);
            this.CellsOnY.TabIndex = 9;
            this.CellsOnY.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // CellsOnX
            // 
            this.CellsOnX.Location = new System.Drawing.Point(4, 4);
            this.CellsOnX.Name = "CellsOnX";
            this.CellsOnX.Size = new System.Drawing.Size(120, 20);
            this.CellsOnX.TabIndex = 8;
            this.CellsOnX.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // printToFile
            // 
            this.printToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToFile.Location = new System.Drawing.Point(3, 96);
            this.printToFile.Name = "printToFile";
            this.printToFile.Size = new System.Drawing.Size(316, 37);
            this.printToFile.TabIndex = 7;
            this.printToFile.Text = "PRINT CELLS TO TEXT FILE";
            this.printToFile.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(4, 51);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(156, 39);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 154);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(570, 409);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "";
            // 
            // GUIGridTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 575);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.panel1);
            this.Name = "GUIGridTester";
            this.Text = "Arbitrary Grid Size Tester GUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellsOnY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellsOnX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GridYAxis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button printToFile;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown CellsOnY;
        private System.Windows.Forms.NumericUpDown CellsOnX;
    }
}

