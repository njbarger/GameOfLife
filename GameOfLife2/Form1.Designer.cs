
namespace GameOfLife2
{
    partial class Form1
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showNeighborsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextGeneration = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EdgesSettingsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.FiniteBorderMenuChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToroidalBorderMenuChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSettingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButtonTimerDialog = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFiniteOrToroidal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLivingCellCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edgesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSizeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNeedSomebodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notJustAnybodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.youKnowINeedSomeOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heeeellpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GameOfLife2.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.randomizeToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripFileNew,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripFileNew
            // 
            this.newToolStripFileNew.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripFileNew.Image")));
            this.newToolStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripFileNew.Name = "newToolStripFileNew";
            this.newToolStripFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripFileNew.Size = new System.Drawing.Size(180, 22);
            this.newToolStripFileNew.Text = "&New";
            this.newToolStripFileNew.Click += new System.EventHandler(this.newToolStripFileNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripFileExit
            // 
            this.exitToolStripFileExit.Name = "exitToolStripFileExit";
            this.exitToolStripFileExit.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripFileExit.Text = "E&xit";
            this.exitToolStripFileExit.Click += new System.EventHandler(this.exitToolStripFileExit_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem1,
            this.showNeighborsToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // gridToolStripMenuItem1
            // 
            this.gridToolStripMenuItem1.Checked = true;
            this.gridToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem1.Name = "gridToolStripMenuItem1";
            this.gridToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gridToolStripMenuItem1.Text = "Grid";
            this.gridToolStripMenuItem1.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // showNeighborsToolStripMenuItem
            // 
            this.showNeighborsToolStripMenuItem.Name = "showNeighborsToolStripMenuItem";
            this.showNeighborsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showNeighborsToolStripMenuItem.Text = "Show Neighbors";
            this.showNeighborsToolStripMenuItem.Click += new System.EventHandler(this.neighborCountToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem2,
            this.gridSizeToolStripMenuItem2,
            this.toolStripSeparator4,
            this.timerSpeedToolStripMenuItem,
            this.toolStripSeparator5,
            this.resetToolStripMenuItem2,
            this.reloadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "&Settings";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButtonNew,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.toolStripButtonPlay,
            this.toolStripButtonStop,
            this.toolStripButtonNextGeneration,
            this.toolStripSeparator3,
            this.EdgesSettingsButton,
            this.GridSettingsButton,
            this.toolStripButtonTimerDialog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButtonNew
            // 
            this.newToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButtonNew.Image")));
            this.newToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButtonNew.Name = "newToolStripButtonNew";
            this.newToolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButtonNew.Text = "&New";
            this.newToolStripButtonNew.Click += new System.EventHandler(this.newToolStripButtonNew_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlay.Text = "toolStripButton1";
            this.toolStripButtonPlay.ToolTipText = "Play";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::GameOfLife2.Properties.Resources.StopButton;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "toolStripButton2";
            this.toolStripButtonStop.ToolTipText = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonNextGeneration
            // 
            this.toolStripButtonNextGeneration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextGeneration.Image = global::GameOfLife2.Properties.Resources.NextButton;
            this.toolStripButtonNextGeneration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextGeneration.Name = "toolStripButtonNextGeneration";
            this.toolStripButtonNextGeneration.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNextGeneration.Text = "toolStripButton3";
            this.toolStripButtonNextGeneration.ToolTipText = "Next Generation";
            this.toolStripButtonNextGeneration.Click += new System.EventHandler(this.toolStripButtonNextGeneration_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // EdgesSettingsButton
            // 
            this.EdgesSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EdgesSettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiniteBorderMenuChoice,
            this.ToroidalBorderMenuChoice});
            this.EdgesSettingsButton.Image = global::GameOfLife2.Properties.Resources.Borders;
            this.EdgesSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EdgesSettingsButton.Name = "EdgesSettingsButton";
            this.EdgesSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EdgesSettingsButton.Size = new System.Drawing.Size(32, 22);
            this.EdgesSettingsButton.Text = "Edges";
            this.EdgesSettingsButton.ToolTipText = "Edges";
            this.EdgesSettingsButton.ButtonClick += new System.EventHandler(this.EdgesSettingsButton_ButtonClick);
            // 
            // FiniteBorderMenuChoice
            // 
            this.FiniteBorderMenuChoice.Name = "FiniteBorderMenuChoice";
            this.FiniteBorderMenuChoice.Size = new System.Drawing.Size(116, 22);
            this.FiniteBorderMenuChoice.Text = "Finite";
            this.FiniteBorderMenuChoice.Click += new System.EventHandler(this.FiniteBorderMenuChoice_Click);
            // 
            // ToroidalBorderMenuChoice
            // 
            this.ToroidalBorderMenuChoice.Checked = true;
            this.ToroidalBorderMenuChoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToroidalBorderMenuChoice.Name = "ToroidalBorderMenuChoice";
            this.ToroidalBorderMenuChoice.Size = new System.Drawing.Size(116, 22);
            this.ToroidalBorderMenuChoice.Text = "Toroidal";
            this.ToroidalBorderMenuChoice.Click += new System.EventHandler(this.ToroidalBorderMenuChoice_Click);
            // 
            // GridSettingsButton
            // 
            this.GridSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GridSettingsButton.Image = global::GameOfLife2.Properties.Resources.GridSize;
            this.GridSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GridSettingsButton.Name = "GridSettingsButton";
            this.GridSettingsButton.ShowDropDownArrow = false;
            this.GridSettingsButton.Size = new System.Drawing.Size(20, 22);
            this.GridSettingsButton.Text = "Grid Size";
            this.GridSettingsButton.ToolTipText = "Grid Size";
            this.GridSettingsButton.Click += new System.EventHandler(this.GridSettingsButton_Click);
            // 
            // toolStripButtonTimerDialog
            // 
            this.toolStripButtonTimerDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTimerDialog.Image = global::GameOfLife2.Properties.Resources.TimerButton;
            this.toolStripButtonTimerDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTimerDialog.Name = "toolStripButtonTimerDialog";
            this.toolStripButtonTimerDialog.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTimerDialog.Text = "toolStripButton1";
            this.toolStripButtonTimerDialog.ToolTipText = "Timer";
            this.toolStripButtonTimerDialog.Click += new System.EventHandler(this.toolStripButtonTimerDialog_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelFiniteOrToroidal,
            this.toolStripStatusLabelLivingCellCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelFiniteOrToroidal
            // 
            this.toolStripStatusLabelFiniteOrToroidal.Name = "toolStripStatusLabelFiniteOrToroidal";
            this.toolStripStatusLabelFiniteOrToroidal.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabelFiniteOrToroidal.Text = "Edges = Toroidal";
            // 
            // toolStripStatusLabelLivingCellCount
            // 
            this.toolStripStatusLabelLivingCellCount.Name = "toolStripStatusLabelLivingCellCount";
            this.toolStripStatusLabelLivingCellCount.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabelLivingCellCount.Text = "Living Cells = 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.edgesToolStripMenuItem1,
            this.gridSizeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 92);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1,
            this.backgroundToolStripMenuItem1,
            this.cellColorToolStripMenuItem1,
            this.gridColorToolStripMenuItem1});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem1
            // 
            this.backgroundToolStripMenuItem1.Name = "backgroundToolStripMenuItem1";
            this.backgroundToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem1.Text = "Background";
            this.backgroundToolStripMenuItem1.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem1
            // 
            this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
            this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.cellColorToolStripMenuItem1.Text = "Cell Color";
            this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem1
            // 
            this.gridColorToolStripMenuItem1.Name = "gridColorToolStripMenuItem1";
            this.gridColorToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.gridColorToolStripMenuItem1.Text = "Grid Color";
            this.gridColorToolStripMenuItem1.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // edgesToolStripMenuItem1
            // 
            this.edgesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finiteToolStripMenuItem1,
            this.toroidalToolStripMenuItem1});
            this.edgesToolStripMenuItem1.Name = "edgesToolStripMenuItem1";
            this.edgesToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.edgesToolStripMenuItem1.Text = "Edges";
            // 
            // finiteToolStripMenuItem1
            // 
            this.finiteToolStripMenuItem1.Name = "finiteToolStripMenuItem1";
            this.finiteToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.finiteToolStripMenuItem1.Text = "Finite";
            this.finiteToolStripMenuItem1.Click += new System.EventHandler(this.FiniteBorderMenuChoice_Click);
            // 
            // toroidalToolStripMenuItem1
            // 
            this.toroidalToolStripMenuItem1.Checked = true;
            this.toroidalToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toroidalToolStripMenuItem1.Name = "toroidalToolStripMenuItem1";
            this.toroidalToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toroidalToolStripMenuItem1.Text = "Toroidal";
            this.toroidalToolStripMenuItem1.Click += new System.EventHandler(this.ToroidalBorderMenuChoice_Click);
            // 
            // gridSizeToolStripMenuItem
            // 
            this.gridSizeToolStripMenuItem.Name = "gridSizeToolStripMenuItem";
            this.gridSizeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.gridSizeToolStripMenuItem.Text = "Grid Size";
            this.gridSizeToolStripMenuItem.Click += new System.EventHandler(this.GridSettingsButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neighborCountToolStripMenuItem,
            this.gridToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // neighborCountToolStripMenuItem
            // 
            this.neighborCountToolStripMenuItem.Name = "neighborCountToolStripMenuItem";
            this.neighborCountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neighborCountToolStripMenuItem.Text = "Neighbor Count";
            this.neighborCountToolStripMenuItem.Click += new System.EventHandler(this.neighborCountToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // timerSpeedToolStripMenuItem
            // 
            this.timerSpeedToolStripMenuItem.Name = "timerSpeedToolStripMenuItem";
            this.timerSpeedToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.timerSpeedToolStripMenuItem.Text = "Timer Speed";
            this.timerSpeedToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonTimerDialog_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.randomizeToolStripMenuItem.Text = "&Randomize";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem2
            // 
            this.resetToolStripMenuItem2.Name = "resetToolStripMenuItem2";
            this.resetToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.resetToolStripMenuItem2.Text = "Reset";
            this.resetToolStripMenuItem2.Click += new System.EventHandler(this.resetToolStripMenuItem2_Click);
            // 
            // colorToolStripMenuItem2
            // 
            this.colorToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.colorToolStripMenuItem2.Name = "colorToolStripMenuItem2";
            this.colorToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.colorToolStripMenuItem2.Text = "Color";
            // 
            // gridSizeToolStripMenuItem2
            // 
            this.gridSizeToolStripMenuItem2.Name = "gridSizeToolStripMenuItem2";
            this.gridSizeToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.gridSizeToolStripMenuItem2.Text = "Grid Size";
            this.gridSizeToolStripMenuItem2.Click += new System.EventHandler(this.GridSettingsButton_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNeedSomebodyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // iNeedSomebodyToolStripMenuItem
            // 
            this.iNeedSomebodyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.iNeedSomebodyToolStripMenuItem.Name = "iNeedSomebodyToolStripMenuItem";
            this.iNeedSomebodyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iNeedSomebodyToolStripMenuItem.Text = "I Need Somebody";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notJustAnybodyToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.helpToolStripMenuItem1.Text = "Help!";
            // 
            // notJustAnybodyToolStripMenuItem
            // 
            this.notJustAnybodyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2});
            this.notJustAnybodyToolStripMenuItem.Name = "notJustAnybodyToolStripMenuItem";
            this.notJustAnybodyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.notJustAnybodyToolStripMenuItem.Text = "Not Just Anybody";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youKnowINeedSomeOneToolStripMenuItem});
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.helpToolStripMenuItem2.Text = "Help!";
            // 
            // youKnowINeedSomeOneToolStripMenuItem
            // 
            this.youKnowINeedSomeOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heeeellpToolStripMenuItem});
            this.youKnowINeedSomeOneToolStripMenuItem.Name = "youKnowINeedSomeOneToolStripMenuItem";
            this.youKnowINeedSomeOneToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.youKnowINeedSomeOneToolStripMenuItem.Text = "You know I need some one!";
            // 
            // heeeellpToolStripMenuItem
            // 
            this.heeeellpToolStripMenuItem.Name = "heeeellpToolStripMenuItem";
            this.heeeellpToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.heeeellpToolStripMenuItem.Text = "Heeeellp!!";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 274);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 345);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripFileNew;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButtonNew;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextGeneration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiniteOrToroidal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton EdgesSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem FiniteBorderMenuChoice;
        private System.Windows.Forms.ToolStripMenuItem ToroidalBorderMenuChoice;
        private System.Windows.Forms.ToolStripDropDownButton GridSettingsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edgesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTimerDialog;
        private System.Windows.Forms.ToolStripMenuItem gridSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLivingCellCount;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showNeighborsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridSizeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNeedSomebodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notJustAnybodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem youKnowINeedSomeOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heeeellpToolStripMenuItem;
    }
}

