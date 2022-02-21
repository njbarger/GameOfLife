using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOfLife2
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe;
        bool[,] scratchPad;
        bool isFinite = false;
        bool showNeighbors = false;
        bool showGrid = true;

        // Drawing colors
        Color gridColor = Color.Gray;
        Color cellColor = Color.DarkGray;

        // The Timer class
        Timer timer = new Timer();

        // Universe Size
        float universeWidth = 20.0f;
        float universeHeight = 20.0f;
        // Generation count
        int generations = 0;
        int liveCellCount = 0;

        // File properties
        string fileName = "";

        public Form1()
        {
            InitializeComponent();

            // Read in Settings
            graphicsPanel1.BackColor = Properties.Settings.Default.BackColor;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            universeWidth = Properties.Settings.Default.UniverseWidth;
            universeHeight = Properties.Settings.Default.UniverseHeight;


            // Initialize Universe Size
            universe = new bool[(int)universeWidth, (int)universeHeight];
            // Setup the timer
            timer.Interval = Properties.Settings.Default.TimerSpeed; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running ****set to false, so timer can be stopped/started*****
            //timer.Start();
            //timer.Stop();
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            scratchPad = universe.Clone() as bool[,];

            if (isFinite)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // Apply Life's Rules
                        int neighborhood = CountNeighborsFinite(x, y);
                        // living with less than 2 neighbors dies
                        if (universe[x, y] && neighborhood < 2)
                        {
                            scratchPad[x, y] = false;
                        }
                        // living with more than 3 neighbors dies
                        if (universe[x, y] && neighborhood > 3)
                        {
                            scratchPad[x, y] = false;
                        }
                        // living with 2 or 3 neighbors lives on
                        if (universe[x, y] && (neighborhood == 2 || neighborhood == 3))
                        {
                            continue;
                        }
                        // dead with exactly 3 neighbors spawns life
                        if (!universe[x, y] && neighborhood == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // Apply Life's Rules
                        int neighborhood = CountNeighborsToroidal(x, y);
                        // living with less than 2 neighbors dies
                        if (universe[x, y] && neighborhood < 2)
                        {
                            scratchPad[x, y] = false;
                        }
                        // living with more than 3 neighbors dies
                        if (universe[x, y] && neighborhood > 3)
                        {
                            scratchPad[x, y] = false;
                        }
                        // living with 2 or 3 neighbors lives on
                        if (universe[x, y] && (neighborhood == 2 || neighborhood == 3))
                        {
                            continue;
                        }
                        // dead with exactly 3 neighbors spawns life
                        if (!universe[x, y] && neighborhood == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                    }
                }
            }

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            if (isFinite)
            {
                toolStripStatusLabelFiniteOrToroidal.Text = "Edges = " + "Finite";
            }
            else
            {
                toolStripStatusLabelFiniteOrToroidal.Text = "Edges = " + "Toroidal";
            }

            ShowLivingCells();

            //copy from scratchPad to universe
            universe = scratchPad.Clone() as bool[,];

            graphicsPanel1.Invalidate();
        }

        #region Count Neighbors

        private int CountNeighborsFinite(int x, int y)
        {
            int neighborCount = 0;
            int xLen = universe.GetLength(0) - 1;
            int yLen = universe.GetLength(1) - 1;

            for (int yOffSet = -1; yOffSet <= 1; yOffSet++)
            {
                for (int xOffSet = -1; xOffSet <= 1; xOffSet++)
                {
                    int xCheck = x + xOffSet;
                    int yCheck = y + yOffSet;

                    if (xOffSet == 0 && yOffSet == 0)
                    {
                        continue;
                    }

                    if (xCheck < 0)
                    {
                        continue;

                    }
                    else if (xCheck > xLen)
                    {
                        continue;
                    }
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    else if (yCheck > yLen)
                    {
                        continue;
                    }

                    if (universe[xCheck, yCheck])
                    {
                        neighborCount++;
                    }
                }
            }

            return neighborCount;
        }

        private int CountNeighborsToroidal(int x, int y)
        {
            int neighborCount = 0;
            int xLen = universe.GetLength(0) - 1;
            int yLen = universe.GetLength(1) - 1;

            for (int yOffSet = -1; yOffSet <= 1; yOffSet++)
            {
                for (int xOffSet = -1; xOffSet <= 1; xOffSet++)
                {
                    int xCheck = x + xOffSet;
                    int yCheck = y + yOffSet;

                    if (xOffSet == 0 && yOffSet == 0)
                    {
                        continue;
                    }

                    if (xCheck < 0)
                    {
                        xCheck = xLen;

                    }
                    else if (xCheck > xLen)
                    {
                        xCheck = 0;
                    }
                    if (yCheck < 0)
                    {
                        yCheck = yLen;
                    }
                    else if (yCheck > yLen)
                    {
                        yCheck = 0;
                    }

                    if (universe[xCheck, yCheck])
                    {
                        neighborCount++;
                    }
                }
            }
            return neighborCount;
        }

        #endregion


        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void ShowLivingCells()
        {
            liveCellCount = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y])
                    {
                        liveCellCount++;
                    }
                }
            }

            toolStripStatusLabelLivingCellCount.Text = "Living Cells = " + liveCellCount.ToString();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // calculate upper left hand corner for each "cell"
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = (float)x * cellWidth;     // upper left hand corner 
                    cellRect.Y = (float)y * cellHeight;    // lower left hand corner
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    float pointX = cellRect.X + (cellWidth / 4);
                    float pointY = cellRect.Y;
                    PointF currentPoint = new PointF(pointX, pointY);

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    if (showGrid)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }

                    // Fill with Neighbor Count
                    if (showNeighbors)
                    {
                        Font font = new Font("Arial", 8.0f);

                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        Brush neighborBrush = new SolidBrush(Color.Red);

                        RectangleF rect = new RectangleF(cellRect.X, cellRect.Y, cellWidth, cellHeight);
                        if (isFinite)
                        {
                            int neighbors = CountNeighborsFinite(x, y);
                            if (universe[x, y] || neighbors > 0)
                            {
                                if (neighbors == 2 || neighbors == 3)
                                {

                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Green, rect, stringFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Red, rect, stringFormat);
                                }
                            }
                        }
                        else if (!isFinite)
                        {
                            int neighbors = CountNeighborsToroidal(x, y);
                            if (universe[x, y] || neighbors > 0)
                            {
                                if (neighbors == 2 || neighbors == 3)
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Green, rect, stringFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Red, rect, stringFormat);
                                }
                            }
                        }
                    }

                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();              //not the same as delete, but marks as "done" for garbage collector, thusly saving on memory
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                float x = (float)e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                float y = (float)e.Y / cellHeight;

                // Toggle the cell's state
                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                ShowLivingCells();
                graphicsPanel1.Invalidate();
            }
        }

        #region Start/Stop/Next

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void toolStripButtonNextGeneration_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        #endregion


        #region New Template Buttons

        private void newToolStripFileNew_Click(object sender, EventArgs e)
        {
            fileName = "";
            liveCellCount = 0;
            for (int y = 0; y < universe.GetLength(0); y++)
            {
                for (int x = 0; x < universe.GetLength(1); x++)
                {
                    universe[x, y] = false;
                }
            }
            // Update status strip generations
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private void newToolStripButtonNew_Click(object sender, EventArgs e)
        {
            fileName = "";
            liveCellCount = 0;
            for (int y = 0; y < universe.GetLength(0); y++)
            {
                for (int x = 0; x < universe.GetLength(1); x++)
                {
                    universe[x, y] = false;
                }
            }

            // Update status strip generations
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            graphicsPanel1.Invalidate();
        }

        #endregion


        #region ExitButtons

        private void exitToolStripFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.BackColor = graphicsPanel1.BackColor;
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.UniverseWidth = universeWidth;
            Properties.Settings.Default.UniverseHeight = universeHeight;

            Properties.Settings.Default.Save();
        }

        #endregion


        #region Finite/Toroidal Settings

        private void FiniteBorderMenuChoice_Click(object sender, EventArgs e)
        {
            FiniteBorderMenuChoice.Checked = true;
            isFinite = true;
            ToroidalBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Finite";
            graphicsPanel1.Invalidate();
        }

        private void ToroidalBorderMenuChoice_Click(object sender, EventArgs e)
        {
            ToroidalBorderMenuChoice.Checked = true;

            isFinite = false;

            FiniteBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
            graphicsPanel1.Invalidate();
        }

        private void EdgesSettingsButton_ButtonClick(object sender, EventArgs e)
        {
            if (isFinite)
            {
                ToroidalBorderMenuChoice.Checked = true;

                isFinite = false;

                FiniteBorderMenuChoice.Checked = false;
                toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
                graphicsPanel1.Invalidate();
            }
            else if (!isFinite)
            {
                FiniteBorderMenuChoice.Checked = true;
                isFinite = true;
                ToroidalBorderMenuChoice.Checked = false;
                toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Finite";
                graphicsPanel1.Invalidate();
            }
        }
        #endregion


        #region Grid Size Settings

        private void SetUniverseSize(float widthSize, float heightSize)
        {
            bool[,] newUniverse = new bool[(int)widthSize, (int)heightSize];
            for (int y = 0; y < newUniverse.GetLength(1); y++)
            {
                for (int x = 0; x < newUniverse.GetLength(0); x++)
                {
                    if (x >= universe.GetLength(0) || y >= universe.GetLength(1))
                    {
                        newUniverse[x, y] = false;
                    }
                    else if (universe[x, y])
                    {
                        newUniverse[x, y] = true;
                    }
                    else if (!universe[x, y])
                    {
                        newUniverse[x, y] = false;
                    }
                }
            }
            universeWidth = widthSize;
            universeHeight = heightSize;
            universe = newUniverse.Clone() as bool[,];
            ShowLivingCells();
            graphicsPanel1.Invalidate();
        }
        private void GridSettingsButton_Click(object sender, EventArgs e)
        {
            GridSizeDialog gridDlg = new GridSizeDialog();
            gridDlg.GridWidth = universe.GetLength(0);
            gridDlg.GridHeight = universe.GetLength(1);

            if (DialogResult.OK == gridDlg.ShowDialog())
            {
                SetUniverseSize(gridDlg.GridWidth, gridDlg.GridHeight);
                graphicsPanel1.Invalidate();
            }
            gridDlg.Dispose();
        }

        #endregion


        #region Timer Settings

        private void toolStripButtonTimerDialog_Click(object sender, EventArgs e)
        {
            TimerDialog tDlg = new TimerDialog();
            tDlg.TimerSpeed = timer.Interval;

            if (DialogResult.OK == tDlg.ShowDialog())
            {
                if (tDlg.TimerSpeed <= 0)
                {
                    tDlg.TimerSpeed = 1;
                }
                timer.Interval = tDlg.TimerSpeed;
            }

            tDlg.Dispose();
        }

        #endregion


        #region Color Settings

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.BackColor = Color.White;
            cellColor = Color.DarkGray;
            gridColor = Color.Gray;

            graphicsPanel1.Invalidate();
        }
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = graphicsPanel1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
            dlg.Dispose();
        }

        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
            dlg.Dispose();
        }

        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = gridColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                gridColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }

            dlg.Dispose();
        }




        #endregion


        #region Save/SaveAs

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "All Files|*.*|Cells|*.cells";
            saveDlg.FilterIndex = 2;
            saveDlg.DefaultExt = "cells";

            if (DialogResult.OK == saveDlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(saveDlg.FileName);

                writer.WriteLine("!Test Glider");
                for (int y = 0; y < universe.GetLength(0); y++)
                {
                    String currentRow = string.Empty;
                    for (int x = 0; x < universe.GetLength(1); x++)
                    {
                        if (x >= universe.GetLength(0) || y >= universe.GetLength(1))
                        {
                            currentRow += ".";
                        }
                        if (universe[x, y])
                        {
                            currentRow += "O";
                        }
                        else
                        {
                            currentRow += ".";
                        }
                    }

                    writer.WriteLine(currentRow);
                }

                fileName = saveDlg.FileName;
                writer.Close();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                StreamWriter writer = new StreamWriter(fileName);

                writer.WriteLine(@"!{fileName}");
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String currentRow = string.Empty;
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (x >= universe.GetLength(0) || y >= universe.GetLength(1))
                        {
                            currentRow += ".";
                        }
                        if (universe[x, y])
                        {
                            currentRow += "O";
                        }
                        else
                        {
                            currentRow += ".";
                        }
                    }

                    writer.WriteLine(currentRow);
                }

                writer.Close();
            }
        }

        #endregion


        #region Open

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All Files|*.*|Cells|*.cells";
            openDlg.FilterIndex = 2;

            if (DialogResult.OK == openDlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(openDlg.FileName);

                float maxWidth = 0.0f;
                float maxHeight = 0.0f;
                int yCount = 0;

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else
                    {
                        maxHeight++;
                        maxWidth = row.Length;
                    }
                }

                SetUniverseSize(maxWidth, maxHeight);

                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else
                    {
                        for (int x = 0; x < row.Length; x++)
                        {
                            if (row[x] == 'O')
                            {
                                universe[x, yCount] = true;
                            }
                            else if (row[x] == '.')
                            {
                                universe[x, yCount] = false;
                            }
                        }
                        yCount++;
                    }
                }

                fileName = openDlg.FileName;
                reader.Close();
            }

            ShowLivingCells();
            graphicsPanel1.Invalidate();
        }

        #endregion


        #region Show Neighbors

        private void neighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (neighborCountToolStripMenuItem.Checked || showNeighborsToolStripMenuItem.Checked || showNeighbors)
            {
                showNeighbors = false;
                neighborCountToolStripMenuItem.Checked = false;
                showNeighborsToolStripMenuItem.Checked = false;
            }
            else if (!neighborCountToolStripMenuItem.Checked || !showNeighbors)
            {
                showNeighbors = true;
                neighborCountToolStripMenuItem.Checked = true;
                showNeighborsToolStripMenuItem.Checked = true;
            }

            graphicsPanel1.Invalidate();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridToolStripMenuItem.Checked || gridToolStripMenuItem1.Checked || showGrid)
            {
                showGrid = false;
                gridToolStripMenuItem.Checked = false;
                gridToolStripMenuItem1.Checked = false;
            }
            else if (!gridToolStripMenuItem.Checked || !gridToolStripMenuItem1.Checked || !showGrid)
            {
                showGrid = true;
                gridToolStripMenuItem.Checked = true;
                gridToolStripMenuItem1.Checked = true;
            }

            graphicsPanel1.Invalidate();
        }

        #endregion


        #region Reset/Reload
        private void resetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            graphicsPanel1.BackColor = Color.White;
            Properties.Settings.Default.BackColor = Color.White;

            gridColor = Color.Gray;
            Properties.Settings.Default.GridColor = Color.Gray;

            cellColor = Color.DarkGray;
            Properties.Settings.Default.CellColor = Color.DarkGray;

            SetUniverseSize(20.0f, 20.0f);
            universeWidth = 20.0f;
            universeHeight = 20.0f;
            Properties.Settings.Default.UniverseWidth = 20;
            Properties.Settings.Default.UniverseHeight = 20;

            timer.Interval = 100;
            Properties.Settings.Default.TimerSpeed = timer.Interval;

            graphicsPanel1.Invalidate();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.BackColor = Properties.Settings.Default.BackColor;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            SetUniverseSize(Properties.Settings.Default.UniverseWidth, Properties.Settings.Default.UniverseHeight);
            timer.Interval = Properties.Settings.Default.TimerSpeed;

            graphicsPanel1.Invalidate();
        }

        #endregion


    }
}