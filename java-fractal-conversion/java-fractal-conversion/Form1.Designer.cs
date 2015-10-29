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
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTv)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(63, 129);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(460, 338);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseEnter += new System.EventHandler(this.picture_MouseEnter);
            this.picture.MouseLeave += new System.EventHandler(this.picture_MouseLeave);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.fileToolStripMenuItem.Text = "State";
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saveStateToolStripMenuItem.Text = "Save State";
            this.saveStateToolStripMenuItem.Click += new System.EventHandler(this.saveStateToolStripMenuItem_Click);
            // 
            // loadStateToolStripMenuItem
            // 
            this.loadStateToolStripMenuItem.Name = "loadStateToolStripMenuItem";
            this.loadStateToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.loadStateToolStripMenuItem.Text = "Load State";
            this.loadStateToolStripMenuItem.Click += new System.EventHandler(this.loadStateToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.resetToolStripMenuItem.Text = "Restart";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // imageTv
            // 
            this.imageTv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageTv.BackgroundImage = global::java_fractal_conversion.Properties.Resources.tv;
            this.imageTv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageTv.Location = new System.Drawing.Point(-58, 50);
            this.imageTv.Name = "imageTv";
            this.imageTv.Size = new System.Drawing.Size(840, 534);
            this.imageTv.TabIndex = 2;
            this.imageTv.TabStop = false;
            this.imageTv.MouseEnter += new System.EventHandler(this.imageTv_MouseEnter);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonReset.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(556, 420);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 36);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Restart";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            this.buttonReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonReset_MouseClick);
            this.buttonReset.MouseEnter += new System.EventHandler(this.buttonReset_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.buttonReset_MouseLeave);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.message.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.message.Location = new System.Drawing.Point(12, 29);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(71, 21);
            this.message.TabIndex = 4;
            this.message.Text = "message";
            // 
            // colourPaletteTitle
            // 
            this.colourPaletteTitle.AutoSize = true;
            this.colourPaletteTitle.BackColor = System.Drawing.Color.Black;
            this.colourPaletteTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.colourPaletteTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colourPaletteTitle.Location = new System.Drawing.Point(552, 241);
            this.colourPaletteTitle.Name = "colourPaletteTitle";
            this.colourPaletteTitle.Size = new System.Drawing.Size(131, 21);
            this.colourPaletteTitle.TabIndex = 6;
            this.colourPaletteTitle.Text = "Colour Palette      ";
            // 
            // colourPaletteRed
            // 
            this.colourPaletteRed.BackColor = System.Drawing.Color.Red;
            this.colourPaletteRed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteRed.Location = new System.Drawing.Point(556, 284);
            this.colourPaletteRed.Name = "colourPaletteRed";
            this.colourPaletteRed.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteRed.TabIndex = 8;
            this.colourPaletteRed.UseVisualStyleBackColor = false;
            this.colourPaletteRed.Click += new System.EventHandler(this.colourPaletteRed_Click);
            this.colourPaletteRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteRed.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteRed.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteOrange
            // 
            this.colourPaletteOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.colourPaletteOrange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteOrange.Location = new System.Drawing.Point(590, 284);
            this.colourPaletteOrange.Name = "colourPaletteOrange";
            this.colourPaletteOrange.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteOrange.TabIndex = 9;
            this.colourPaletteOrange.UseVisualStyleBackColor = false;
            this.colourPaletteOrange.Click += new System.EventHandler(this.colourPaletteOrange_Click);
            this.colourPaletteOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteOrange.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteOrange.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteTurquoise
            // 
            this.colourPaletteTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.colourPaletteTurquoise.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteTurquoise.Location = new System.Drawing.Point(556, 317);
            this.colourPaletteTurquoise.Name = "colourPaletteTurquoise";
            this.colourPaletteTurquoise.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteTurquoise.TabIndex = 10;
            this.colourPaletteTurquoise.UseVisualStyleBackColor = false;
            this.colourPaletteTurquoise.Click += new System.EventHandler(this.colourPaletteTurquoise_Click);
            this.colourPaletteTurquoise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteTurquoise.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteTurquoise.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteYellow
            // 
            this.colourPaletteYellow.BackColor = System.Drawing.Color.Yellow;
            this.colourPaletteYellow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteYellow.Location = new System.Drawing.Point(658, 284);
            this.colourPaletteYellow.Name = "colourPaletteYellow";
            this.colourPaletteYellow.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteYellow.TabIndex = 11;
            this.colourPaletteYellow.UseVisualStyleBackColor = false;
            this.colourPaletteYellow.Click += new System.EventHandler(this.colourPaletteYellow_Click);
            this.colourPaletteYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteYellow.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteYellow.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteGreen
            // 
            this.colourPaletteGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.colourPaletteGreen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteGreen.Location = new System.Drawing.Point(624, 284);
            this.colourPaletteGreen.Name = "colourPaletteGreen";
            this.colourPaletteGreen.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteGreen.TabIndex = 12;
            this.colourPaletteGreen.UseVisualStyleBackColor = false;
            this.colourPaletteGreen.Click += new System.EventHandler(this.colourPaletteGreen_Click);
            this.colourPaletteGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteGreen.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteGreen.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteBlue
            // 
            this.colourPaletteBlue.BackColor = System.Drawing.Color.Blue;
            this.colourPaletteBlue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteBlue.Location = new System.Drawing.Point(590, 317);
            this.colourPaletteBlue.Name = "colourPaletteBlue";
            this.colourPaletteBlue.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteBlue.TabIndex = 13;
            this.colourPaletteBlue.UseVisualStyleBackColor = false;
            this.colourPaletteBlue.Click += new System.EventHandler(this.colourPaletteBlue_Click);
            this.colourPaletteBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteBlue.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteBlue.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPalettePurple
            // 
            this.colourPalettePurple.BackColor = System.Drawing.Color.Purple;
            this.colourPalettePurple.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPalettePurple.Location = new System.Drawing.Point(624, 317);
            this.colourPalettePurple.Name = "colourPalettePurple";
            this.colourPalettePurple.Size = new System.Drawing.Size(28, 28);
            this.colourPalettePurple.TabIndex = 14;
            this.colourPalettePurple.UseVisualStyleBackColor = false;
            this.colourPalettePurple.Click += new System.EventHandler(this.colourPalettePurple_Click);
            this.colourPalettePurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPalettePurple.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPalettePurple.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteLabel
            // 
            this.colourPaletteLabel.AutoSize = true;
            this.colourPaletteLabel.BackColor = System.Drawing.Color.Black;
            this.colourPaletteLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteLabel.ForeColor = System.Drawing.Color.White;
            this.colourPaletteLabel.Location = new System.Drawing.Point(552, 262);
            this.colourPaletteLabel.Name = "colourPaletteLabel";
            this.colourPaletteLabel.Size = new System.Drawing.Size(89, 19);
            this.colourPaletteLabel.TabIndex = 16;
            this.colourPaletteLabel.Text = "Selected: Red";
            this.colourPaletteLabel.Click += new System.EventHandler(this.colourPaletteLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 607);
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
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imageTv);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
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

    }
}

