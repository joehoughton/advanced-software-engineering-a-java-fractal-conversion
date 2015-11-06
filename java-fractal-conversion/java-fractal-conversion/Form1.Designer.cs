namespace java_fractal_conversion
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTv = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.colourPaletteTitle = new System.Windows.Forms.Label();
            this.colourPaletteRed = new System.Windows.Forms.Button();
            this.colourPaletteOrange = new System.Windows.Forms.Button();
            this.colourPaletteTurquoise = new System.Windows.Forms.Button();
            this.colourPaletteYellow = new System.Windows.Forms.Button();
            this.colourPaletteGreen = new System.Windows.Forms.Button();
            this.colourPaletteBlue = new System.Windows.Forms.Button();
            this.colourPalettePurple = new System.Windows.Forms.Button();
            this.colourPaletteLabel = new System.Windows.Forms.Label();
            this.trackBarColourCycle = new System.Windows.Forms.TrackBar();
            this.checkBoxColourCycle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerColourCycle = new System.Windows.Forms.Timer(this.components);
            this.colourCycleSpeedLabel = new System.Windows.Forms.Label();
            this.checkBoxPaletteCycle = new System.Windows.Forms.CheckBox();
            this.timerPaletteColourCycle = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageAnimation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColourCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(126, 248);
            this.picture.Margin = new System.Windows.Forms.Padding(6);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(920, 650);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseEnter += new System.EventHandler(this.picture_MouseEnter);
            this.picture.MouseLeave += new System.EventHandler(this.picture_MouseLeave);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1478, 57);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(81, 49);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.fileToolStripMenuItem1.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(255, 50);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            this.saveAsToolStripMenuItem.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.saveAsToolStripMenuItem.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(255, 50);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStateToolStripMenuItem,
            this.loadStateToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(103, 49);
            this.fileToolStripMenuItem.Text = "State";
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(274, 50);
            this.saveStateToolStripMenuItem.Text = "Save State";
            this.saveStateToolStripMenuItem.Click += new System.EventHandler(this.saveStateToolStripMenuItem_Click);
            this.saveStateToolStripMenuItem.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.saveStateToolStripMenuItem.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // loadStateToolStripMenuItem
            // 
            this.loadStateToolStripMenuItem.Name = "loadStateToolStripMenuItem";
            this.loadStateToolStripMenuItem.Size = new System.Drawing.Size(274, 50);
            this.loadStateToolStripMenuItem.Text = "Load State";
            this.loadStateToolStripMenuItem.Click += new System.EventHandler(this.loadStateToolStripMenuItem_Click);
            this.loadStateToolStripMenuItem.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.loadStateToolStripMenuItem.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(274, 50);
            this.resetToolStripMenuItem.Text = "Restart";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.reset_Click);
            this.resetToolStripMenuItem.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.resetToolStripMenuItem.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // imageTv
            // 
            this.imageTv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageTv.BackgroundImage = global::java_fractal_conversion.Properties.Resources.tv;
            this.imageTv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageTv.Location = new System.Drawing.Point(-116, 96);
            this.imageTv.Margin = new System.Windows.Forms.Padding(6);
            this.imageTv.Name = "imageTv";
            this.imageTv.Size = new System.Drawing.Size(1680, 1027);
            this.imageTv.TabIndex = 2;
            this.imageTv.TabStop = false;
            this.imageTv.MouseEnter += new System.EventHandler(this.picture_MouseLeave);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonReset.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(1093, 858);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(260, 69);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Restart";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.reset_Click);
            this.buttonReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.buttonReset.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.message.ForeColor = System.Drawing.Color.DarkGreen;
            this.message.Location = new System.Drawing.Point(24, 56);
            this.message.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(145, 45);
            this.message.TabIndex = 4;
            this.message.Text = "message";
            // 
            // colourPaletteTitle
            // 
            this.colourPaletteTitle.AutoSize = true;
            this.colourPaletteTitle.BackColor = System.Drawing.Color.Black;
            this.colourPaletteTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.colourPaletteTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colourPaletteTitle.Location = new System.Drawing.Point(1104, 521);
            this.colourPaletteTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colourPaletteTitle.Name = "colourPaletteTitle";
            this.colourPaletteTitle.Size = new System.Drawing.Size(275, 45);
            this.colourPaletteTitle.TabIndex = 6;
            this.colourPaletteTitle.Text = "Colour Palette      ";
            // 
            // colourPaletteRed
            // 
            this.colourPaletteRed.BackColor = System.Drawing.Color.Red;
            this.colourPaletteRed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteRed.Location = new System.Drawing.Point(1112, 604);
            this.colourPaletteRed.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteRed.Name = "colourPaletteRed";
            this.colourPaletteRed.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteRed.TabIndex = 8;
            this.colourPaletteRed.UseVisualStyleBackColor = false;
            this.colourPaletteRed.Click += new System.EventHandler(this.colourPaletteRed_Click);
            this.colourPaletteRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteRed.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteRed.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteOrange
            // 
            this.colourPaletteOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.colourPaletteOrange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteOrange.Location = new System.Drawing.Point(1180, 604);
            this.colourPaletteOrange.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteOrange.Name = "colourPaletteOrange";
            this.colourPaletteOrange.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteOrange.TabIndex = 9;
            this.colourPaletteOrange.UseVisualStyleBackColor = false;
            this.colourPaletteOrange.Click += new System.EventHandler(this.colourPaletteOrange_Click);
            this.colourPaletteOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteOrange.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteOrange.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteTurquoise
            // 
            this.colourPaletteTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.colourPaletteTurquoise.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteTurquoise.Location = new System.Drawing.Point(1112, 668);
            this.colourPaletteTurquoise.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteTurquoise.Name = "colourPaletteTurquoise";
            this.colourPaletteTurquoise.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteTurquoise.TabIndex = 10;
            this.colourPaletteTurquoise.UseVisualStyleBackColor = false;
            this.colourPaletteTurquoise.Click += new System.EventHandler(this.colourPaletteTurquoise_Click);
            this.colourPaletteTurquoise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteTurquoise.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteTurquoise.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteYellow
            // 
            this.colourPaletteYellow.BackColor = System.Drawing.Color.Yellow;
            this.colourPaletteYellow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteYellow.Location = new System.Drawing.Point(1248, 604);
            this.colourPaletteYellow.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteYellow.Name = "colourPaletteYellow";
            this.colourPaletteYellow.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteYellow.TabIndex = 11;
            this.colourPaletteYellow.UseVisualStyleBackColor = false;
            this.colourPaletteYellow.Click += new System.EventHandler(this.colourPaletteYellow_Click);
            this.colourPaletteYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteYellow.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteYellow.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteGreen
            // 
            this.colourPaletteGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.colourPaletteGreen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteGreen.Location = new System.Drawing.Point(1316, 604);
            this.colourPaletteGreen.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteGreen.Name = "colourPaletteGreen";
            this.colourPaletteGreen.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteGreen.TabIndex = 12;
            this.colourPaletteGreen.UseVisualStyleBackColor = false;
            this.colourPaletteGreen.Click += new System.EventHandler(this.colourPaletteGreen_Click);
            this.colourPaletteGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteGreen.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteGreen.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteBlue
            // 
            this.colourPaletteBlue.BackColor = System.Drawing.Color.Blue;
            this.colourPaletteBlue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteBlue.Location = new System.Drawing.Point(1180, 668);
            this.colourPaletteBlue.Margin = new System.Windows.Forms.Padding(6);
            this.colourPaletteBlue.Name = "colourPaletteBlue";
            this.colourPaletteBlue.Size = new System.Drawing.Size(56, 54);
            this.colourPaletteBlue.TabIndex = 13;
            this.colourPaletteBlue.UseVisualStyleBackColor = false;
            this.colourPaletteBlue.Click += new System.EventHandler(this.colourPaletteBlue_Click);
            this.colourPaletteBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPaletteBlue.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPaletteBlue.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPalettePurple
            // 
            this.colourPalettePurple.BackColor = System.Drawing.Color.Purple;
            this.colourPalettePurple.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPalettePurple.Location = new System.Drawing.Point(1248, 668);
            this.colourPalettePurple.Margin = new System.Windows.Forms.Padding(6);
            this.colourPalettePurple.Name = "colourPalettePurple";
            this.colourPalettePurple.Size = new System.Drawing.Size(56, 54);
            this.colourPalettePurple.TabIndex = 14;
            this.colourPalettePurple.UseVisualStyleBackColor = false;
            this.colourPalettePurple.Click += new System.EventHandler(this.colourPalettePurple_Click);
            this.colourPalettePurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.colourPalettePurple.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.colourPalettePurple.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // colourPaletteLabel
            // 
            this.colourPaletteLabel.AutoSize = true;
            this.colourPaletteLabel.BackColor = System.Drawing.Color.Black;
            this.colourPaletteLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteLabel.ForeColor = System.Drawing.Color.White;
            this.colourPaletteLabel.Location = new System.Drawing.Point(1104, 562);
            this.colourPaletteLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colourPaletteLabel.Name = "colourPaletteLabel";
            this.colourPaletteLabel.Size = new System.Drawing.Size(196, 37);
            this.colourPaletteLabel.TabIndex = 16;
            this.colourPaletteLabel.Text = "Select a colour:";
            // 
            // trackBarColourCycle
            // 
            this.trackBarColourCycle.BackColor = System.Drawing.Color.Black;
            this.trackBarColourCycle.Location = new System.Drawing.Point(1154, 775);
            this.trackBarColourCycle.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarColourCycle.Maximum = 2;
            this.trackBarColourCycle.Name = "trackBarColourCycle";
            this.trackBarColourCycle.Size = new System.Drawing.Size(212, 90);
            this.trackBarColourCycle.SmallChange = 100;
            this.trackBarColourCycle.TabIndex = 17;
            this.trackBarColourCycle.Scroll += new System.EventHandler(this.trackBarColourCycle_Scroll);
            this.trackBarColourCycle.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.trackBarColourCycle.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // checkBoxColourCycle
            // 
            this.checkBoxColourCycle.AutoSize = true;
            this.checkBoxColourCycle.BackColor = System.Drawing.Color.Black;
            this.checkBoxColourCycle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxColourCycle.Location = new System.Drawing.Point(1112, 780);
            this.checkBoxColourCycle.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxColourCycle.Name = "checkBoxColourCycle";
            this.checkBoxColourCycle.Padding = new System.Windows.Forms.Padding(10);
            this.checkBoxColourCycle.Size = new System.Drawing.Size(48, 47);
            this.checkBoxColourCycle.TabIndex = 18;
            this.checkBoxColourCycle.UseVisualStyleBackColor = false;
            this.checkBoxColourCycle.CheckedChanged += new System.EventHandler(this.checkBoxColourCycle_CheckedChanged);
            this.checkBoxColourCycle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.checkBoxColourCycle.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.checkBoxColourCycle.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1114, 734);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "Colour Cycle       ";
            // 
            // timerColourCycle
            // 
            this.timerColourCycle.Interval = 600;
            this.timerColourCycle.Tick += new System.EventHandler(this.timerColourCycle_Tick);
            // 
            // colourCycleSpeedLabel
            // 
            this.colourCycleSpeedLabel.AutoSize = true;
            this.colourCycleSpeedLabel.BackColor = System.Drawing.Color.Black;
            this.colourCycleSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourCycleSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.colourCycleSpeedLabel.Location = new System.Drawing.Point(1320, 735);
            this.colourCycleSpeedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colourCycleSpeedLabel.Name = "colourCycleSpeedLabel";
            this.colourCycleSpeedLabel.Size = new System.Drawing.Size(44, 37);
            this.colourCycleSpeedLabel.TabIndex = 20;
            this.colourCycleSpeedLabel.Text = "x1";
            // 
            // checkBoxPaletteCycle
            // 
            this.checkBoxPaletteCycle.AutoSize = true;
            this.checkBoxPaletteCycle.BackColor = System.Drawing.Color.Black;
            this.checkBoxPaletteCycle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxPaletteCycle.Location = new System.Drawing.Point(1102, 479);
            this.checkBoxPaletteCycle.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxPaletteCycle.Name = "checkBoxPaletteCycle";
            this.checkBoxPaletteCycle.Padding = new System.Windows.Forms.Padding(10);
            this.checkBoxPaletteCycle.Size = new System.Drawing.Size(48, 47);
            this.checkBoxPaletteCycle.TabIndex = 21;
            this.checkBoxPaletteCycle.UseVisualStyleBackColor = false;
            this.checkBoxPaletteCycle.CheckedChanged += new System.EventHandler(this.checkBoxPaletteCycle_CheckedChanged);
            this.checkBoxPaletteCycle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cursor_MouseClick);
            this.checkBoxPaletteCycle.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.checkBoxPaletteCycle.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // timerPaletteColourCycle
            // 
            this.timerPaletteColourCycle.Tick += new System.EventHandler(this.timerPaletteCycle_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1104, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "Palette Cycle         ";
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.BackColor = System.Drawing.Color.Black;
            this.checkBoxAnimation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxAnimation.Location = new System.Drawing.Point(1102, 394);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Padding = new System.Windows.Forms.Padding(10);
            this.checkBoxAnimation.Size = new System.Drawing.Size(48, 47);
            this.checkBoxAnimation.TabIndex = 23;
            this.checkBoxAnimation.UseVisualStyleBackColor = false;
            this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.checkBoxAnimation_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1103, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 45);
            this.label3.TabIndex = 24;
            this.label3.Text = "Animation     ";
            // 
            // messageAnimation
            // 
            this.messageAnimation.AutoSize = true;
            this.messageAnimation.BackColor = System.Drawing.Color.YellowGreen;
            this.messageAnimation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.messageAnimation.ForeColor = System.Drawing.Color.DarkGreen;
            this.messageAnimation.Location = new System.Drawing.Point(243, 9);
            this.messageAnimation.Name = "messageAnimation";
            this.messageAnimation.Size = new System.Drawing.Size(245, 45);
            this.messageAnimation.TabIndex = 25;
            this.messageAnimation.Text = "                         ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1104, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 74);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select multiple\r\nstates:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1478, 1117);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageAnimation);
            this.Controls.Add(this.checkBoxAnimation);
            this.Controls.Add(this.checkBoxPaletteCycle);
            this.Controls.Add(this.colourCycleSpeedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxColourCycle);
            this.Controls.Add(this.trackBarColourCycle);
            this.Controls.Add(this.colourPaletteLabel);
            this.Controls.Add(this.colourPalettePurple);
            this.Controls.Add(this.colourPaletteBlue);
            this.Controls.Add(this.colourPaletteGreen);
            this.Controls.Add(this.colourPaletteYellow);
            this.Controls.Add(this.colourPaletteTurquoise);
            this.Controls.Add(this.colourPaletteOrange);
            this.Controls.Add(this.colourPaletteRed);
            this.Controls.Add(this.colourPaletteTitle);
            this.Controls.Add(this.message);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.imageTv);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColourCycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStateToolStripMenuItem;
        private System.Windows.Forms.PictureBox imageTv;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label colourPaletteTitle;
        private System.Windows.Forms.Button colourPaletteRed;
        private System.Windows.Forms.Button colourPaletteOrange;
        private System.Windows.Forms.Button colourPaletteTurquoise;
        private System.Windows.Forms.Button colourPaletteYellow;
        private System.Windows.Forms.Button colourPaletteGreen;
        private System.Windows.Forms.Button colourPaletteBlue;
        private System.Windows.Forms.Button colourPalettePurple;
        private System.Windows.Forms.Label colourPaletteLabel;
        private System.Windows.Forms.TrackBar trackBarColourCycle;
        private System.Windows.Forms.CheckBox checkBoxColourCycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerColourCycle;
        private System.Windows.Forms.Label colourCycleSpeedLabel;
        private System.Windows.Forms.CheckBox checkBoxPaletteCycle;
        private System.Windows.Forms.Timer timerPaletteColourCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAnimation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageAnimation;
        private System.Windows.Forms.Label label4;

    }
}

