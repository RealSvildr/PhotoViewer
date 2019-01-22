namespace PhotoViewer {
    partial class Main {
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
            this.pnl_Image = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.setAsDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_zoom = new System.Windows.Forms.TrackBar();
            this.image = new System.Windows.Forms.PictureBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fullscreen = new System.Windows.Forms.Button();
            this.btn_backward = new System.Windows.Forms.Button();
            this.btn_Zoom = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_clockwise = new System.Windows.Forms.Button();
            this.btn_counterClockwise = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_normalize = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_makecopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsi_properties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_orderprint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_email = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsi_datadisc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi_open = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnl_Image.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Image
            // 
            this.pnl_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Image.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Image.ContextMenuStrip = this.contextMenuStrip1;
            this.pnl_Image.Controls.Add(this.tb_zoom);
            this.pnl_Image.Controls.Add(this.image);
            this.pnl_Image.Controls.Add(this.lbl_message);
            this.pnl_Image.Location = new System.Drawing.Point(0, 36);
            this.pnl_Image.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Image.Name = "pnl_Image";
            this.pnl_Image.Size = new System.Drawing.Size(541, 318);
            this.pnl_Image.TabIndex = 10;
            this.pnl_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Image_MouseDown);
            this.pnl_Image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Image_MouseMove);
            this.pnl_Image.Resize += new System.EventHandler(this.pnl_Image_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripSeparator4,
            this.setAsDesktopToolStripMenuItem,
            this.toolStripSeparator5,
            this.asdToolStripMenuItem,
            this.toolStripSeparator6,
            this.rToolStripMenuItem,
            this.rotateLeftToolStripMenuItem,
            this.toolStripSeparator7,
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator8,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 226);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // setAsDesktopToolStripMenuItem
            // 
            this.setAsDesktopToolStripMenuItem.Enabled = false;
            this.setAsDesktopToolStripMenuItem.Name = "setAsDesktopToolStripMenuItem";
            this.setAsDesktopToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.setAsDesktopToolStripMenuItem.Text = "Set as desktop background";
            this.setAsDesktopToolStripMenuItem.Click += new System.EventHandler(this.setAsDesktopToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(254, 6);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.asdToolStripMenuItem.Text = "Open file location";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(254, 6);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.rToolStripMenuItem.Text = "Rotate right";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rotateRightToolStripMenuItem_Click);
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.rotateLeftToolStripMenuItem.Text = "Rotate left";
            this.rotateLeftToolStripMenuItem.Click += new System.EventHandler(this.rotateLeftToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(254, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(254, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Enabled = false;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // tb_zoom
            // 
            this.tb_zoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_zoom.BackColor = System.Drawing.SystemColors.Control;
            this.tb_zoom.LargeChange = 4;
            this.tb_zoom.Location = new System.Drawing.Point(35, 174);
            this.tb_zoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_zoom.Name = "tb_zoom";
            this.tb_zoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_zoom.Size = new System.Drawing.Size(56, 128);
            this.tb_zoom.TabIndex = 999;
            this.tb_zoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_zoom.Visible = false;
            this.tb_zoom.ValueChanged += new System.EventHandler(this.tb_zoom_ValueChanged);
            this.tb_zoom.Leave += new System.EventHandler(this.tb_zoom_Leave);
            this.tb_zoom.MouseLeave += new System.EventHandler(this.tb_zoom_MouseLeave);
            // 
            // image
            // 
            this.image.ContextMenuStrip = this.contextMenuStrip1;
            this.image.Image = global::PhotoViewer.Properties.Resources._blank;
            this.image.Location = new System.Drawing.Point(152, 62);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(237, 170);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            this.image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_MouseMove);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoEllipsis = true;
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(256, 261);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(46, 17);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "label1";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PhotoViewer.Properties.Resources.bgIcons;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btn_counterClockwise);
            this.panel1.Controls.Add(this.btn_fullscreen);
            this.panel1.Controls.Add(this.btn_Forward);
            this.panel1.Controls.Add(this.btn_backward);
            this.panel1.Controls.Add(this.btn_Zoom);
            this.panel1.Controls.Add(this.btn_clockwise);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_normalize);
            this.panel1.Location = new System.Drawing.Point(72, 354);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 56);
            this.panel1.TabIndex = 11;
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.FlatAppearance.BorderSize = 0;
            this.btn_fullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fullscreen.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.Image = global::PhotoViewer.Properties.Resources.iconFullscreen;
            this.btn_fullscreen.Location = new System.Drawing.Point(178, 2);
            this.btn_fullscreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(56, 52);
            this.btn_fullscreen.TabIndex = 1;
            this.btn_fullscreen.UseVisualStyleBackColor = false;
            this.btn_fullscreen.Click += new System.EventHandler(this.btn_fullscreen_Click);
            // 
            // btn_backward
            // 
            this.btn_backward.BackColor = System.Drawing.Color.Transparent;
            this.btn_backward.FlatAppearance.BorderSize = 0;
            this.btn_backward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_backward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_backward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backward.ForeColor = System.Drawing.Color.Transparent;
            this.btn_backward.Image = global::PhotoViewer.Properties.Resources.iconBackward;
            this.btn_backward.Location = new System.Drawing.Point(117, 9);
            this.btn_backward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_backward.Name = "btn_backward";
            this.btn_backward.Size = new System.Drawing.Size(71, 39);
            this.btn_backward.TabIndex = 3;
            this.btn_backward.UseVisualStyleBackColor = false;
            this.btn_backward.Click += new System.EventHandler(this.btn_backward_Click);
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_Zoom.FlatAppearance.BorderSize = 0;
            this.btn_Zoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Zoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Zoom.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Zoom.Image = global::PhotoViewer.Properties.Resources.iconZoom;
            this.btn_Zoom.Location = new System.Drawing.Point(23, 14);
            this.btn_Zoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.Size = new System.Drawing.Size(45, 28);
            this.btn_Zoom.TabIndex = 0;
            this.btn_Zoom.UseVisualStyleBackColor = false;
            this.btn_Zoom.Click += new System.EventHandler(this.btn_Zoom_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_Forward.FlatAppearance.BorderSize = 0;
            this.btn_Forward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Forward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Forward.Image = global::PhotoViewer.Properties.Resources.iconForward;
            this.btn_Forward.Location = new System.Drawing.Point(220, 10);
            this.btn_Forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(77, 39);
            this.btn_Forward.TabIndex = 3;
            this.btn_Forward.UseVisualStyleBackColor = false;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_clockwise
            // 
            this.btn_clockwise.BackColor = System.Drawing.Color.Transparent;
            this.btn_clockwise.FlatAppearance.BorderSize = 0;
            this.btn_clockwise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_clockwise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_clockwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clockwise.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clockwise.Image = global::PhotoViewer.Properties.Resources.iconClockwise;
            this.btn_clockwise.Location = new System.Drawing.Point(321, 12);
            this.btn_clockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clockwise.Name = "btn_clockwise";
            this.btn_clockwise.Size = new System.Drawing.Size(35, 31);
            this.btn_clockwise.TabIndex = 6;
            this.btn_clockwise.UseVisualStyleBackColor = false;
            this.btn_clockwise.Click += new System.EventHandler(this.btn_clockwise_Click);
            // 
            // btn_counterClockwise
            // 
            this.btn_counterClockwise.BackColor = System.Drawing.Color.Transparent;
            this.btn_counterClockwise.FlatAppearance.BorderSize = 0;
            this.btn_counterClockwise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_counterClockwise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_counterClockwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_counterClockwise.ForeColor = System.Drawing.Color.Transparent;
            this.btn_counterClockwise.Image = global::PhotoViewer.Properties.Resources.iconCounterClockwise;
            this.btn_counterClockwise.Location = new System.Drawing.Point(284, 12);
            this.btn_counterClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_counterClockwise.Name = "btn_counterClockwise";
            this.btn_counterClockwise.Size = new System.Drawing.Size(35, 31);
            this.btn_counterClockwise.TabIndex = 5;
            this.btn_counterClockwise.UseVisualStyleBackColor = false;
            this.btn_counterClockwise.Click += new System.EventHandler(this.btn_counterClockwise_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Image = global::PhotoViewer.Properties.Resources.iconDelete;
            this.btn_delete.Location = new System.Drawing.Point(366, 12);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(35, 31);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_normalize
            // 
            this.btn_normalize.BackColor = System.Drawing.Color.Transparent;
            this.btn_normalize.FlatAppearance.BorderSize = 0;
            this.btn_normalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_normalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_normalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normalize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_normalize.Image = global::PhotoViewer.Properties.Resources.iconNormalize;
            this.btn_normalize.Location = new System.Drawing.Point(76, 15);
            this.btn_normalize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_normalize.Name = "btn_normalize";
            this.btn_normalize.Size = new System.Drawing.Size(35, 28);
            this.btn_normalize.TabIndex = 4;
            this.btn_normalize.UseVisualStyleBackColor = false;
            this.btn_normalize.Click += new System.EventHandler(this.btn_normalize_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.BackgroundImage = global::PhotoViewer.Properties.Resources.menu;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.tsi_email,
            this.toolStripLabel4,
            this.tsi_open,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(541, 54);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_delete,
            this.tsi_makecopy,
            this.toolStripSeparator1,
            this.tsi_copy,
            this.toolStripSeparator2,
            this.tsi_properties,
            this.toolStripSeparator3,
            this.tsi_exit});
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(7, 3, 2, 3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(7, 2, 6, 2);
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 48);
            this.toolStripLabel1.Text = "File";
            // 
            // tsi_delete
            // 
            this.tsi_delete.Name = "tsi_delete";
            this.tsi_delete.Size = new System.Drawing.Size(179, 26);
            this.tsi_delete.Text = "Delete";
            this.tsi_delete.Click += new System.EventHandler(this.tsi_delete_Click);
            // 
            // tsi_makecopy
            // 
            this.tsi_makecopy.Name = "tsi_makecopy";
            this.tsi_makecopy.Size = new System.Drawing.Size(179, 26);
            this.tsi_makecopy.Text = "Make a Copy...";
            this.tsi_makecopy.Click += new System.EventHandler(this.tsi_makecopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // tsi_copy
            // 
            this.tsi_copy.Name = "tsi_copy";
            this.tsi_copy.Size = new System.Drawing.Size(179, 26);
            this.tsi_copy.Text = "Copy";
            this.tsi_copy.Click += new System.EventHandler(this.tsi_copy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // tsi_properties
            // 
            this.tsi_properties.Name = "tsi_properties";
            this.tsi_properties.Size = new System.Drawing.Size(179, 26);
            this.tsi_properties.Text = "Properties";
            this.tsi_properties.Click += new System.EventHandler(this.tsi_properties_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // tsi_exit
            // 
            this.tsi_exit.Name = "tsi_exit";
            this.tsi_exit.Size = new System.Drawing.Size(179, 26);
            this.tsi_exit.Text = "Exit";
            this.tsi_exit.Click += new System.EventHandler(this.tsi_exit_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_print,
            this.tsi_orderprint});
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(5, 3, 2, 3);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 48);
            this.toolStripLabel2.Text = "Print";
            // 
            // tsi_print
            // 
            this.tsi_print.Name = "tsi_print";
            this.tsi_print.Size = new System.Drawing.Size(172, 26);
            this.tsi_print.Text = "Print";
            this.tsi_print.Click += new System.EventHandler(this.tsi_print_Click);
            // 
            // tsi_orderprint
            // 
            this.tsi_orderprint.Name = "tsi_orderprint";
            this.tsi_orderprint.Size = new System.Drawing.Size(172, 26);
            this.tsi_orderprint.Text = "Order prints...";
            this.tsi_orderprint.Click += new System.EventHandler(this.tsi_orderprint_Click);
            // 
            // tsi_email
            // 
            this.tsi_email.Enabled = false;
            this.tsi_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.tsi_email.Margin = new System.Windows.Forms.Padding(5, 3, 2, 3);
            this.tsi_email.Name = "tsi_email";
            this.tsi_email.Padding = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.tsi_email.Size = new System.Drawing.Size(62, 48);
            this.tsi_email.Text = "E-mail";
            this.tsi_email.Click += new System.EventHandler(this.tsi_email_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi_datadisc});
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(5, 3, 2, 3);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Padding = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.toolStripLabel4.Size = new System.Drawing.Size(68, 48);
            this.toolStripLabel4.Text = "Burn";
            // 
            // tsi_datadisc
            // 
            this.tsi_datadisc.Name = "tsi_datadisc";
            this.tsi_datadisc.Size = new System.Drawing.Size(157, 26);
            this.tsi_datadisc.Text = "Data Disc...";
            this.tsi_datadisc.Click += new System.EventHandler(this.tsi_datadisc_Click);
            // 
            // tsi_open
            // 
            this.tsi_open.Enabled = false;
            this.tsi_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.tsi_open.Margin = new System.Windows.Forms.Padding(5, 3, 2, 3);
            this.tsi_open.Name = "tsi_open";
            this.tsi_open.Padding = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.tsi_open.Size = new System.Drawing.Size(74, 48);
            this.tsi_open.Text = "Open";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PhotoViewer.Properties.Resources.iconHelp;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripButton1.Size = new System.Drawing.Size(54, 48);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(541, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Image);
            this.Controls.Add(this.toolStrip1);
            this.Icon = global::PhotoViewer.Properties.Resources.favicon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(553, 432);
            this.Name = "Main";
            this.Text = "Photo Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWhell);
            this.pnl_Image.ResumeLayout(false);
            this.pnl_Image.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zoom;
        private System.Windows.Forms.Button btn_fullscreen;
        private System.Windows.Forms.Button btn_backward;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clockwise;
        private System.Windows.Forms.Button btn_counterClockwise;
        private System.Windows.Forms.Button btn_normalize;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsi_email;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel4;
        private System.Windows.Forms.ToolStripSplitButton tsi_open;
        private System.Windows.Forms.ToolStripMenuItem tsi_print;
        private System.Windows.Forms.ToolStripMenuItem tsi_orderprint;
        private System.Windows.Forms.ToolStripMenuItem tsi_datadisc;
        private System.Windows.Forms.Panel pnl_Image;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tb_zoom;
        private System.Windows.Forms.ToolStripMenuItem tsi_delete;
        private System.Windows.Forms.ToolStripMenuItem tsi_makecopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsi_copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsi_properties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsi_exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setAsDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}

