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

        // Toolbar/Settings options
        bool isFinite = false;
        bool showNeighbors = false;
        bool showGrid = true;
        bool hudEnabled = true;
        int currentSeed = 1234567890;

        // Drawing colors
        Color gridColor = Color.Gray;
        Color cellColor = Color.Black;

        // The Timer class
        Timer timer = new Timer();

        // Universe Size
        float universeWidth = 20.0f;
        float universeHeight = 20.0f;
        // Generation count
        int generations = 0;
        int liveCellCount = 0;

        // File properties
        string fileName = "Untitled";

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
            timer.Enabled = false;

        }
        
        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // Copy universe to scratchpad
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
            else // Toroidal logic
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

            // Update status strip Finite/Toroidal
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
        
        // Counts total cells to display on status strip.
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


        #region Graphic Panel/Mouse

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

                    // Outline the cell with a pen (if showGrid is enabled)
                    if (showGrid)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }

                    // Fill with Neighbor Count   (if showNeighbors is enabled
                    if (showNeighbors)
                    {
                        Font font = new Font("Arial", 8.0f);

                        // Allign text in center
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        if (isFinite)
                        {
                            // Count cells neighbors
                            int neighbors = CountNeighborsFinite(x, y);

                            // checks to see if cell is alive or has at least 1 neighbor
                            if (universe[x, y] || neighbors > 0)
                            {
                                if (neighbors == 2 || neighbors == 3)   // change color to green if cell will be alive next generation
                                {

                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Green, cellRect, stringFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Red, cellRect, stringFormat);
                                }
                            }
                        }
                        else if (!isFinite)
                        {
                            // count cells neighbors
                            int neighbors = CountNeighborsToroidal(x, y);

                            // checks to see if cell is alive or has at least 1 neighbor
                            if (universe[x, y] || neighbors > 0)
                            {
                                if (neighbors == 2 || neighbors == 3)   // change color to green if cell will be alive next generation
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Green, cellRect, stringFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Red, cellRect, stringFormat);
                                }
                            }
                        }
                    }

                    

                }
            }
            // Draw the HUD
            if (hudEnabled)
            {
                // Allign text in Bottom left corner
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Near;
                stringFormat.LineAlignment = StringAlignment.Far;

                Font font = new Font("Arial", 10f, FontStyle.Bold);
                e.Graphics.DrawString($"Generations = {generations}" +
                    $"\nCell Count = {liveCellCount} " +
                    $"\nFinite = {isFinite} " +
                    $"\nUniverse Size: (Width: {universeWidth}, Height: {universeHeight})", font, Brushes.Black, graphicsPanel1.ClientRectangle, stringFormat);
            }
            // Cleaning up pens and brushes
            gridPen.Dispose();
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

                // Update living cell status strip
                ShowLivingCells();

                graphicsPanel1.Invalidate();
            }
        }

        #endregion


        #region Start/Stop/Next

        // Play Button
        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        // Stop Button
        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        // Next Generation Button
        private void toolStripButtonNextGeneration_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        #endregion


        #region New Template

        // New File menu option / Button
        private void newToolStripFileNew_Click(object sender, EventArgs e)
        {
            // stop timer
            timer.Stop();

            // Set settings back to default
            resetToolStripMenuItem2_Click(sender, e);

            // clear the universe
            for (int y = 0; y < universe.GetLength(0); y++)
            {
                for (int x = 0; x < universe.GetLength(1); x++)
                {
                    universe[x, y] = false;
                }
            }

            // Update status strips
            ShowLivingCells();
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            graphicsPanel1.Invalidate();
        }


        #endregion


        #region Exit

        // Exit menu option
        private void exitToolStripFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Redefines settings at exit.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.BackColor = graphicsPanel1.BackColor;
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.UniverseWidth = universeWidth;
            Properties.Settings.Default.UniverseHeight = universeHeight;
            Properties.Settings.Default.TimerSpeed = timer.Interval;

            Properties.Settings.Default.Save();
        }

        #endregion


        #region Finite/Toroidal Settings

        // Drop Down Finite selection
        private void FiniteBorderMenuChoice_Click(object sender, EventArgs e)
        {
            FiniteBorderMenuChoice.Checked = true;
            isFinite = true;
            ToroidalBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Finite";
            graphicsPanel1.Invalidate();
        }

        // Drop down Toroidal Selection
        private void ToroidalBorderMenuChoice_Click(object sender, EventArgs e)
        {
            ToroidalBorderMenuChoice.Checked = true;

            isFinite = false;

            FiniteBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
            graphicsPanel1.Invalidate();
        }

        // Finite/Toroidal Toggle Button
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

        // Resizes universe.
        private void SetUniverseSize(float widthSize, float heightSize)
        {
            // create temp universe with desired size
            bool[,] newUniverse = new bool[(int)widthSize, (int)heightSize];

            // Iterate through new universe to define cells
            for (int y = 0; y < newUniverse.GetLength(1); y++)
            {
                for (int x = 0; x < newUniverse.GetLength(0); x++)
                {
                    // check for out of bounds in Universe
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

            // Adjust Setting Selections
            universeWidth = widthSize;
            universeHeight = heightSize;

            // Redefine universe/scratchpad to new Universe
            universe = newUniverse.Clone() as bool[,];
            scratchPad = universe.Clone() as bool[,];

            // Update living cells status
            ShowLivingCells();

            graphicsPanel1.Invalidate();
        }

        // Opens GridDialog box to set Universe Size
        private void GridSettingsButton_Click(object sender, EventArgs e)
        {
            GridSizeDialog gridDlg = new GridSizeDialog();
            gridDlg.GridWidth = universe.GetLength(0);
            gridDlg.GridHeight = universe.GetLength(1);

            // Open grid Dialog
            if (DialogResult.OK == gridDlg.ShowDialog())
            {
                SetUniverseSize(gridDlg.GridWidth, gridDlg.GridHeight);
                graphicsPanel1.Invalidate();
            }
            gridDlg.Dispose();
        }

        #endregion


        #region Timer Settings

        // Opens Time Dialog Box to adjust generation speed.
        private void toolStripButtonTimerDialog_Click(object sender, EventArgs e)
        {
            TimerDialog tDlg = new TimerDialog();
            tDlg.TimerSpeed = timer.Interval;

            if (DialogResult.OK == tDlg.ShowDialog())
            {
                // Check for 0 or negative, switch to 1 millisecond.
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

        // Reset to basic colors
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsPanel1.BackColor = Color.White;
            cellColor = Color.Black;
            gridColor = Color.Gray;

            graphicsPanel1.Invalidate();
        }

        // Background Color dialog box
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

        // CellColor dialog box
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

        // GridColor diaolog box
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

        // Save-As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "All Files|*.*|Cells|*.cells";
            saveDlg.FilterIndex = 2;
            saveDlg.DefaultExt = "cells";

            if (DialogResult.OK == saveDlg.ShowDialog())
            {
                // Write to new file
                StreamWriter writer = new StreamWriter(saveDlg.FileName);

                // Add Name to File
                writer.WriteLine("!" + saveDlg.FileName);

                // Iterate through universe and write to file
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

                // Set local fileName for other operations
                fileName = saveDlg.FileName;
                writer.Close();
            }
            saveDlg.Dispose();
        }

        // Save Function (Save As if no fileName)
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Runs Save As if not saved
            if (fileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // Starts writing to current file
                StreamWriter writer = new StreamWriter(fileName);

                // Writes file name to .txt file
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
                // Starts reading chosen file
                StreamReader reader = new StreamReader(openDlg.FileName);

                float maxWidth = 0.0f;
                float maxHeight = 0.0f;
                int yCount = 0;

                // Reads size of incoming universe
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    // Checks for name/comments
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else     // Sets Width and increments height
                    {
                        maxHeight++;
                        maxWidth = row.Length;
                    }
                }

                // Sends incoming file size to Universe
                SetUniverseSize(maxWidth, maxHeight);

                // Start from Files beginning
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Reiterate, filling universe with files cells
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    // ignore name/comments
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else
                    {
                        //iterate through each row, filling each live cell, then increment y
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

                // Sets current fileName for other operations
                fileName = openDlg.FileName;
                reader.Close();
            }

            openDlg.Dispose();

            //Update Status strip
            ShowLivingCells();

            graphicsPanel1.Invalidate();
        }

        #endregion


        #region Show Neighbors / Show Grid

        // Checkbox logic
        private void neighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Unchecks all neighbor toolstrips if clicked and any are Checked
            if (neighborCountToolStripMenuItem.Checked || showNeighborsToolStripMenuItem.Checked || showNeighbors)
            {
                // Set showNeighbors to false
                showNeighbors = false;
                // uncheck boxes
                neighborCountToolStripMenuItem.Checked = false;
                showNeighborsToolStripMenuItem.Checked = false;
            }

            // Checks all neighbor toolstrips if clicked and any are unchecked
            else if (!neighborCountToolStripMenuItem.Checked|| !showNeighborsToolStripMenuItem.Checked || !showNeighbors)
            {
                // set showNeighbors to true
                showNeighbors = true;
                // check boxes
                neighborCountToolStripMenuItem.Checked = true;
                showNeighborsToolStripMenuItem.Checked = true;
            }

            graphicsPanel1.Invalidate();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // unchecks all showGrid toolstrips if clicked and any are checked
            if (gridToolStripMenuItem.Checked || gridToolStripMenuItem1.Checked || showGrid)
            {
                // set showGrid to false
                showGrid = false;
                // uncheck boxes
                gridToolStripMenuItem.Checked = false;
                gridToolStripMenuItem1.Checked = false;
            }

            // checks all showGrid toolstrips if clicked and any are unchecked
            else if (!gridToolStripMenuItem.Checked || !gridToolStripMenuItem1.Checked || !showGrid)
            {
                // set showGrid to true
                showGrid = true;
                // check boxes
                gridToolStripMenuItem.Checked = true;
                gridToolStripMenuItem1.Checked = true;
            }

            graphicsPanel1.Invalidate();
        }

        #endregion


        #region Reset/Reload

        // Resets settings back to defaults
        private void resetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            graphicsPanel1.BackColor = Properties.Settings.Default.BackColor;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            SetUniverseSize(Properties.Settings.Default.UniverseWidth, Properties.Settings.Default.UniverseHeight);
            timer.Interval = Properties.Settings.Default.TimerSpeed;

            graphicsPanel1.Invalidate();
        }

        // Reloads settings from most recent launch
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            graphicsPanel1.BackColor = Properties.Settings.Default.BackColor;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            SetUniverseSize(Properties.Settings.Default.UniverseWidth, Properties.Settings.Default.UniverseHeight);
            timer.Interval = Properties.Settings.Default.TimerSpeed;

            graphicsPanel1.Invalidate();
        }

        #endregion


        #region Randomize Universe


        // Randomize univerese method (no seed)
        private void Randomize()
        {
            Random rng = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // Clear each cell, then randomize
                    universe[x, y] = false;

                    // 1:3 ratio
                    int rand = rng.Next(0, 2);
                    if (rand == 1)
                    {
                        universe[x, y] = true;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
        }

        // Randomize universe with seed
        private void RandomizeWithSeed(int seedNum)
        {
            Random rng = new Random(seedNum);
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    int rand = rng.Next(0, 2);
                    if (rand == 1)
                    {
                        universe[x, y] = true;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
        }

        // Basic Randomizing
        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randomize();
            graphicsPanel1.Invalidate();
        }

        // Randomize from Chosen Seed
        private void fromSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomSeedDialog RngDialog = new RandomSeedDialog();

            // Sets dialog speed to current
            RngDialog.RngSeed = currentSeed;
            if (DialogResult.OK == RngDialog.ShowDialog())
            {
                // sets current seed for other operations
                currentSeed = RngDialog.RngSeed;

                RandomizeWithSeed(currentSeed);
            }

            RngDialog.Dispose();
            graphicsPanel1.Invalidate();
        }

        // Randomize With the current seed.
        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomizeWithSeed(currentSeed);
            graphicsPanel1.Invalidate();
        }

        #endregion

        #region HUD Options

        private void hUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if hud is on or menu items are checked
            if (hudEnabled || hUDToolStripMenuItem.Checked || hUDToolStripMenuItem1.Checked)
            {
                // diable HUD
                hudEnabled = false;
                // uncheck toostrips
                hUDToolStripMenuItem.Checked = false;
                hUDToolStripMenuItem1.Checked = false;
            }
            // check if hud is off or menu items are not checked
            else if (!hudEnabled || !hUDToolStripMenuItem.Checked || !hUDToolStripMenuItem1.Checked)
            {
                // enabel hud
                hudEnabled = true;
                // check toolstrips
                hUDToolStripMenuItem.Checked = true;
                hUDToolStripMenuItem1.Checked = true;
            }
        }

        #endregion


    }
}