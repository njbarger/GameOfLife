﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFiniteOrToroidal = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphicsPanel1 = new GameOfLife2.GraphicsPanel();
            this.TimerButton = new System.Windows.Forms.ToolStripSplitButton();
            this.TimerSelection1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelection500 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelection250 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelection100 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelection40 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelection10 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextGeneration = new System.Windows.Forms.ToolStripButton();
            this.EdgesSettingsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.FiniteBorderMenuChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToroidalBorderMenuChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSettingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.GridSetting10x10 = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSetting15x15 = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSetting20x20 = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSetting25x25 = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSetting30x30 = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSetting35x35 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripFileExit
            // 
            this.exitToolStripFileExit.Name = "exitToolStripFileExit";
            this.exitToolStripFileExit.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripFileExit.Text = "E&xit";
            this.exitToolStripFileExit.Click += new System.EventHandler(this.exitToolStripFileExit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgesToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // edgesToolStripMenuItem
            // 
            this.edgesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toroidalToolStripMenuItem,
            this.finiteToolStripMenuItem});
            this.edgesToolStripMenuItem.Name = "edgesToolStripMenuItem";
            this.edgesToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.edgesToolStripMenuItem.Text = "Edges";
            // 
            // toroidalToolStripMenuItem
            // 
            this.toroidalToolStripMenuItem.Checked = true;
            this.toroidalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toroidalToolStripMenuItem.Name = "toroidalToolStripMenuItem";
            this.toroidalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.toroidalToolStripMenuItem.Text = "Toroidal";
            this.toroidalToolStripMenuItem.Click += new System.EventHandler(this.ToroidalBorderMenuChoice_Click);
            // 
            // finiteToolStripMenuItem
            // 
            this.finiteToolStripMenuItem.Name = "finiteToolStripMenuItem";
            this.finiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.finiteToolStripMenuItem.Text = "Finite";
            this.finiteToolStripMenuItem.Click += new System.EventHandler(this.FiniteBorderMenuChoice_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
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
            this.GridSettingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimerButton,
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelFiniteOrToroidal});
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
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 274);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // TimerButton
            // 
            this.TimerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TimerButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimerSelection1000,
            this.TimerSelection500,
            this.TimerSelection250,
            this.TimerSelection100,
            this.TimerSelection40,
            this.TimerSelection10});
            this.TimerButton.Image = global::GameOfLife2.Properties.Resources.TimerButton;
            this.TimerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(32, 20);
            this.TimerButton.Text = "toolStripSplitButton1";
            // 
            // TimerSelection1000
            // 
            this.TimerSelection1000.Name = "TimerSelection1000";
            this.TimerSelection1000.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection1000.Text = "1";
            this.TimerSelection1000.Click += new System.EventHandler(this.TimerSelection1000_Click);
            // 
            // TimerSelection500
            // 
            this.TimerSelection500.Name = "TimerSelection500";
            this.TimerSelection500.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection500.Text = "1/2";
            this.TimerSelection500.Click += new System.EventHandler(this.TimerSelection500_Click);
            // 
            // TimerSelection250
            // 
            this.TimerSelection250.Name = "TimerSelection250";
            this.TimerSelection250.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection250.Text = "1/4";
            this.TimerSelection250.Click += new System.EventHandler(this.TimerSelection250_Click);
            // 
            // TimerSelection100
            // 
            this.TimerSelection100.Checked = true;
            this.TimerSelection100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TimerSelection100.Name = "TimerSelection100";
            this.TimerSelection100.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection100.Text = "1/10";
            this.TimerSelection100.Click += new System.EventHandler(this.TimerSelection100_Click);
            // 
            // TimerSelection40
            // 
            this.TimerSelection40.Name = "TimerSelection40";
            this.TimerSelection40.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection40.Text = "1/25";
            this.TimerSelection40.Click += new System.EventHandler(this.TimerSelection40_Click);
            // 
            // TimerSelection10
            // 
            this.TimerSelection10.Name = "TimerSelection10";
            this.TimerSelection10.Size = new System.Drawing.Size(180, 22);
            this.TimerSelection10.Text = "1/100";
            this.TimerSelection10.Click += new System.EventHandler(this.TimerSelection10_Click);
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
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlay.Text = "toolStripButton1";
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
            this.toolStripButtonNextGeneration.Click += new System.EventHandler(this.toolStripButtonNextGeneration_Click);
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
            this.GridSettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridSetting10x10,
            this.GridSetting15x15,
            this.GridSetting20x20,
            this.GridSetting25x25,
            this.GridSetting30x30,
            this.GridSetting35x35});
            this.GridSettingsButton.Image = global::GameOfLife2.Properties.Resources.GridSize;
            this.GridSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GridSettingsButton.Name = "GridSettingsButton";
            this.GridSettingsButton.Size = new System.Drawing.Size(29, 22);
            this.GridSettingsButton.Text = "Grid Size";
            this.GridSettingsButton.ToolTipText = "Grid Size";
            // 
            // GridSetting10x10
            // 
            this.GridSetting10x10.Name = "GridSetting10x10";
            this.GridSetting10x10.Size = new System.Drawing.Size(110, 22);
            this.GridSetting10x10.Text = "10 x 10";
            this.GridSetting10x10.Click += new System.EventHandler(this.GridSetting10x10_Click);
            // 
            // GridSetting15x15
            // 
            this.GridSetting15x15.Name = "GridSetting15x15";
            this.GridSetting15x15.Size = new System.Drawing.Size(110, 22);
            this.GridSetting15x15.Text = "15 x 15";
            this.GridSetting15x15.Click += new System.EventHandler(this.GridSetting15x15_Click);
            // 
            // GridSetting20x20
            // 
            this.GridSetting20x20.Checked = true;
            this.GridSetting20x20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridSetting20x20.Name = "GridSetting20x20";
            this.GridSetting20x20.Size = new System.Drawing.Size(110, 22);
            this.GridSetting20x20.Text = "20 x 20";
            this.GridSetting20x20.Click += new System.EventHandler(this.GridSetting20x20_Click);
            // 
            // GridSetting25x25
            // 
            this.GridSetting25x25.Name = "GridSetting25x25";
            this.GridSetting25x25.Size = new System.Drawing.Size(110, 22);
            this.GridSetting25x25.Text = "25 x 25";
            this.GridSetting25x25.Click += new System.EventHandler(this.GridSetting25x25_Click);
            // 
            // GridSetting30x30
            // 
            this.GridSetting30x30.Name = "GridSetting30x30";
            this.GridSetting30x30.Size = new System.Drawing.Size(110, 22);
            this.GridSetting30x30.Text = "30 x 30";
            this.GridSetting30x30.Click += new System.EventHandler(this.GridSetting30x30_Click);
            // 
            // GridSetting35x35
            // 
            this.GridSetting35x35.Name = "GridSetting35x35";
            this.GridSetting35x35.Size = new System.Drawing.Size(110, 22);
            this.GridSetting35x35.Text = "35 x 35";
            this.GridSetting35x35.Click += new System.EventHandler(this.GridSetting35x35_Click);
            // 
            // newToolStripFileNew
            // 
            this.newToolStripFileNew.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripFileNew.Image")));
            this.newToolStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripFileNew.Name = "newToolStripFileNew";
            this.newToolStripFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripFileNew.Size = new System.Drawing.Size(146, 22);
            this.newToolStripFileNew.Text = "&New";
            this.newToolStripFileNew.Click += new System.EventHandler(this.newToolStripFileNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButtonNew;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextGeneration;
        private System.Windows.Forms.ToolStripMenuItem edgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiniteOrToroidal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton EdgesSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem FiniteBorderMenuChoice;
        private System.Windows.Forms.ToolStripMenuItem ToroidalBorderMenuChoice;
        private System.Windows.Forms.ToolStripDropDownButton GridSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem GridSetting10x10;
        private System.Windows.Forms.ToolStripMenuItem GridSetting15x15;
        private System.Windows.Forms.ToolStripMenuItem GridSetting20x20;
        private System.Windows.Forms.ToolStripMenuItem GridSetting25x25;
        private System.Windows.Forms.ToolStripMenuItem GridSetting30x30;
        private System.Windows.Forms.ToolStripMenuItem GridSetting35x35;
        private System.Windows.Forms.ToolStripSplitButton TimerButton;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection1000;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection500;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection250;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection100;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection40;
        private System.Windows.Forms.ToolStripMenuItem TimerSelection10;
    }
}

