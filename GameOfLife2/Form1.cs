using System;
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

        // Drawing colors
        Color gridColor = Color.Gray;
        Color cellColor = Color.Black;

        // The Timer class
        Timer timer = new Timer();

        // Universe Size
        float universeSize = 20.0f;
        // Generation count
        int generations = 0;

        #region Properties



        #endregion

        public Form1()
        {
            InitializeComponent();
            // Initialize Universe Size
            universe = new bool[(int)universeSize, (int)universeSize];
            // Setup the timer
            timer.Interval = 100; // milliseconds
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
                for (int y = 0; y < universe.GetLength(0); y++)
                {
                    for (int x = 0; x < universe.GetLength(1); x++)
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
                for (int y = 0; y < universe.GetLength(0); y++)
                {
                    for (int x = 0; x < universe.GetLength(1); x++)
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
            //copy from scratchPad to universe
            universe = scratchPad.Clone() as bool[,];

            graphicsPanel1.Invalidate();
        }

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

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

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
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
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
                float cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                float x = (float)e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                float y = (float)e.Y / cellHeight;

                // Toggle the cell's state
                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

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


        #region NewTemplateButtons

        private void newToolStripFileNew_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        #endregion


        #region Finite/Toroidal Settings

        private void FiniteBorderMenuChoice_Click(object sender, EventArgs e)
        {
            FiniteBorderMenuChoice.Checked = true;
            finiteToolStripMenuItem.Checked = true;
            isFinite = true;
            toroidalToolStripMenuItem.Checked = false;
            ToroidalBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Finite";
            graphicsPanel1.Invalidate();
        }

        private void ToroidalBorderMenuChoice_Click(object sender, EventArgs e)
        {
            toroidalToolStripMenuItem.Checked = true;
            ToroidalBorderMenuChoice.Checked = true;

            isFinite = false;

            finiteToolStripMenuItem.Checked = false;
            FiniteBorderMenuChoice.Checked = false;
            toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
            graphicsPanel1.Invalidate();
        }

        private void EdgesSettingsButton_ButtonClick(object sender, EventArgs e)
        {
            if (isFinite)
            {
                toroidalToolStripMenuItem.Checked = true;
                ToroidalBorderMenuChoice.Checked = true;

                isFinite = false;

                finiteToolStripMenuItem.Checked = false;
                FiniteBorderMenuChoice.Checked = false;
                toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
                graphicsPanel1.Invalidate();
            }
            else if (!isFinite)
            {
                FiniteBorderMenuChoice.Checked = true;
                finiteToolStripMenuItem.Checked = true;
                isFinite = true;
                toroidalToolStripMenuItem.Checked = false;
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
            for (int y = 0; y < newUniverse.GetLength(0); y++)
            {
                for (int x = 0; x < newUniverse.GetLength(1); x++)
                {
                    if (x >= universe.GetLength(0) || y >= universe.GetLength(1))
                    {
                        continue;
                    }
                    else if (x >= newUniverse.GetLength(0) || y >= newUniverse.GetLength(1))
                    {
                        continue;
                    }
                    newUniverse[x, y] = universe[x, y];
                }
            }
            universe = newUniverse.Clone() as bool[,];
            graphicsPanel1.Invalidate();
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
            cellColor = Color.Black;
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

        private void GridSettingsButton_Click(object sender, EventArgs e)
        {
            GridSizeDialog gridDlg = new GridSizeDialog();
            gridDlg.Width = universe.GetLength(0);
            gridDlg.Height = universe.GetLength(1);

            if (DialogResult.OK == gridDlg.ShowDialog())
            {
                SetUniverseSize(gridDlg.Width, gridDlg.Height);
                graphicsPanel1.Invalidate();
            }
            gridDlg.Dispose();
        }
    }
}