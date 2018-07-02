namespace PhotoViewer {
    partial class Fullscreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbl_message = new System.Windows.Forms.Label();
            this.pnl_image = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.slideSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowSpeedMediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowSpeedFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.image = new System.Windows.Forms.PictureBox();
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.pnl_image.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(160, 210);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(46, 17);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "label1";
            this.lbl_message.Visible = false;
            // 
            // pnl_image
            // 
            this.pnl_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_image.ContextMenuStrip = this.contextMenuStrip1;
            this.pnl_image.Controls.Add(this.image);
            this.pnl_image.Controls.Add(this.lbl_message);
            this.pnl_image.Location = new System.Drawing.Point(0, 0);
            this.pnl_image.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_image.Name = "pnl_image";
            this.pnl_image.Size = new System.Drawing.Size(379, 322);
            this.pnl_image.TabIndex = 2;
            this.pnl_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.backToolStripMenuItem,
            this.toolStripSeparator1,
            this.shuffleToolStripMenuItem,
            this.loopToolStripMenuItem,
            this.toolStripSeparator2,
            this.slideSpeedToolStripMenuItem,
            this.slideShowSpeedMediumToolStripMenuItem,
            this.slideShowSpeedFastToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(271, 282);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Enabled = false;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.loopToolStripMenuItem.Text = "Loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // slideSpeedToolStripMenuItem
            // 
            this.slideSpeedToolStripMenuItem.Name = "slideSpeedToolStripMenuItem";
            this.slideSpeedToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.slideSpeedToolStripMenuItem.Text = "Slide Show Speed - Slow";
            this.slideSpeedToolStripMenuItem.Click += new System.EventHandler(this.slideSpeedToolStripMenuItem_Click);
            // 
            // slideShowSpeedMediumToolStripMenuItem
            // 
            this.slideShowSpeedMediumToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;
            this.slideShowSpeedMediumToolStripMenuItem.Name = "slideShowSpeedMediumToolStripMenuItem";
            this.slideShowSpeedMediumToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.slideShowSpeedMediumToolStripMenuItem.Text = "Slide Show Speed - Medium";
            this.slideShowSpeedMediumToolStripMenuItem.Click += new System.EventHandler(this.slideShowSpeedMediumToolStripMenuItem_Click);
            // 
            // slideShowSpeedFastToolStripMenuItem
            // 
            this.slideShowSpeedFastToolStripMenuItem.Name = "slideShowSpeedFastToolStripMenuItem";
            this.slideShowSpeedFastToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.slideShowSpeedFastToolStripMenuItem.Text = "Slide Show Speed - Fast";
            this.slideShowSpeedFastToolStripMenuItem.Click += new System.EventHandler(this.slideShowSpeedFastToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // image
            // 
            this.image.Image = global::PhotoViewer.Properties.Resources._blank;
            this.image.Location = new System.Drawing.Point(120, 116);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(133, 62);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            this.image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // mouseTimer
            // 
            this.mouseTimer.Enabled = true;
            this.mouseTimer.Interval = 200;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_Tick);
            // 
            // Fullscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.pnl_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::PhotoViewer.Properties.Resources.favicon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fullscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fullscreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fullscreen_FormClosing);
            this.Load += new System.EventHandler(this.Fullscreen_Load);
            this.pnl_image.ResumeLayout(false);
            this.pnl_image.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Panel pnl_image;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem slideSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowSpeedMediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowSpeedFastToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer mouseTimer;
    }
}