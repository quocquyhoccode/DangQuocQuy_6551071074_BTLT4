namespace BTb3
{
    partial class frm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            menuStrip1 = new MenuStrip();
            mnu_File = new ToolStripMenuItem();
            mnuIt_Example1 = new ToolStripMenuItem();
            mnuIt_Example2 = new ToolStripMenuItem();
            mnuIt_Example3 = new ToolStripMenuItem();
            mnu_Format = new ToolStripMenuItem();
            exampleToolStripMenuItem1 = new ToolStripMenuItem();
            mnu_Window = new ToolStripMenuItem();
            mnuIt_TileVertical = new ToolStripMenuItem();
            mnuIt_TileHorizontal = new ToolStripMenuItem();
            mnuIt_Cascade = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            example3ToolStripMenuItem = new ToolStripMenuItem();
            mnu_Help = new ToolStripMenuItem();
            exampleToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnSp_New = new ToolStripButton();
            btnSp_Save = new ToolStripButton();
            btnSp_Cut = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_File, mnu_Format, mnu_Window, mnu_Help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(407, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            mnu_File.DropDownItems.AddRange(new ToolStripItem[] { mnuIt_Example1, mnuIt_Example2, mnuIt_Example3 });
            mnu_File.Name = "mnu_File";
            mnu_File.Size = new Size(46, 24);
            mnu_File.Text = "File";
            // 
            // mnuIt_Example1
            // 
            mnuIt_Example1.Name = "mnuIt_Example1";
            mnuIt_Example1.Size = new Size(157, 26);
            mnuIt_Example1.Text = "Example1";
            mnuIt_Example1.Click += mnuIt_Example1_Click;
            // 
            // mnuIt_Example2
            // 
            mnuIt_Example2.Name = "mnuIt_Example2";
            mnuIt_Example2.Size = new Size(157, 26);
            mnuIt_Example2.Text = "Example2";
            mnuIt_Example2.Click += mnuIt_Example2_Click;
            // 
            // mnuIt_Example3
            // 
            mnuIt_Example3.Name = "mnuIt_Example3";
            mnuIt_Example3.Size = new Size(157, 26);
            mnuIt_Example3.Text = "Example3";
            mnuIt_Example3.Click += mnuIt_Example3_Click;
            // 
            // mnu_Format
            // 
            mnu_Format.DropDownItems.AddRange(new ToolStripItem[] { exampleToolStripMenuItem1 });
            mnu_Format.Name = "mnu_Format";
            mnu_Format.Size = new Size(70, 24);
            mnu_Format.Text = "Format";
            // 
            // exampleToolStripMenuItem1
            // 
            exampleToolStripMenuItem1.Name = "exampleToolStripMenuItem1";
            exampleToolStripMenuItem1.Size = new Size(149, 26);
            exampleToolStripMenuItem1.Text = "Example";
            // 
            // mnu_Window
            // 
            mnu_Window.Checked = true;
            mnu_Window.CheckState = CheckState.Checked;
            mnu_Window.DropDownItems.AddRange(new ToolStripItem[] { mnuIt_TileVertical, mnuIt_TileHorizontal, mnuIt_Cascade, toolStripSeparator1, toolStripTextBox1, toolStripTextBox2, example3ToolStripMenuItem });
            mnu_Window.Name = "mnu_Window";
            mnu_Window.Size = new Size(78, 24);
            mnu_Window.Text = "Window";
            // 
            // mnuIt_TileVertical
            // 
            mnuIt_TileVertical.Name = "mnuIt_TileVertical";
            mnuIt_TileVertical.Size = new Size(224, 26);
            mnuIt_TileVertical.Text = "Tile Vertical";
            mnuIt_TileVertical.Click += mnuIt_TileVertical_Click;
            // 
            // mnuIt_TileHorizontal
            // 
            mnuIt_TileHorizontal.Name = "mnuIt_TileHorizontal";
            mnuIt_TileHorizontal.Size = new Size(224, 26);
            mnuIt_TileHorizontal.Text = "Tile Horizontal";
            mnuIt_TileHorizontal.Click += mnuIt_TileHorizontal_Click;
            // 
            // mnuIt_Cascade
            // 
            mnuIt_Cascade.Name = "mnuIt_Cascade";
            mnuIt_Cascade.Size = new Size(224, 26);
            mnuIt_Cascade.Text = "Cascade";
            mnuIt_Cascade.Click += mnuIt_Cascade_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "Example1";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "Example2";
            // 
            // example3ToolStripMenuItem
            // 
            example3ToolStripMenuItem.Checked = true;
            example3ToolStripMenuItem.CheckState = CheckState.Checked;
            example3ToolStripMenuItem.Name = "example3ToolStripMenuItem";
            example3ToolStripMenuItem.Size = new Size(224, 26);
            example3ToolStripMenuItem.Text = "Example3";
            // 
            // mnu_Help
            // 
            mnu_Help.DropDownItems.AddRange(new ToolStripItem[] { exampleToolStripMenuItem });
            mnu_Help.Name = "mnu_Help";
            mnu_Help.Size = new Size(55, 24);
            mnu_Help.Text = "Help";
            // 
            // exampleToolStripMenuItem
            // 
            exampleToolStripMenuItem.Name = "exampleToolStripMenuItem";
            exampleToolStripMenuItem.Size = new Size(149, 26);
            exampleToolStripMenuItem.Text = "Example";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSp_New, btnSp_Save, btnSp_Cut });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(100, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSp_New
            // 
            btnSp_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSp_New.Image = (Image)resources.GetObject("btnSp_New.Image");
            btnSp_New.ImageTransparentColor = Color.Magenta;
            btnSp_New.Name = "btnSp_New";
            btnSp_New.Size = new Size(29, 24);
            btnSp_New.Text = "toolStripButton1";
            btnSp_New.ToolTipText = "New";
            // 
            // btnSp_Save
            // 
            btnSp_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSp_Save.Image = (Image)resources.GetObject("btnSp_Save.Image");
            btnSp_Save.ImageTransparentColor = Color.Magenta;
            btnSp_Save.Name = "btnSp_Save";
            btnSp_Save.Size = new Size(29, 24);
            btnSp_Save.Text = "toolStripButton1";
            btnSp_Save.ToolTipText = "Save";
            // 
            // btnSp_Cut
            // 
            btnSp_Cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSp_Cut.Image = (Image)resources.GetObject("btnSp_Cut.Image");
            btnSp_Cut.ImageTransparentColor = Color.Magenta;
            btnSp_Cut.Name = "btnSp_Cut";
            btnSp_Cut.Size = new Size(29, 24);
            btnSp_Cut.Text = "toolStripButton1";
            btnSp_Cut.ToolTipText = "Cut";
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 497);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frm_main";
            Text = "StepByStep2_22";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_File;
        private ToolStripMenuItem mnuIt_Example1;
        private ToolStripMenuItem mnuIt_Example2;
        private ToolStripMenuItem mnuIt_Example3;
        private ToolStripMenuItem mnu_Format;
        private ToolStripMenuItem exampleToolStripMenuItem1;
        private ToolStripMenuItem mnu_Window;
        private ToolStripMenuItem mnuIt_TileVertical;
        private ToolStripMenuItem mnuIt_TileHorizontal;
        private ToolStripMenuItem mnuIt_Cascade;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripMenuItem example3ToolStripMenuItem;
        private ToolStripMenuItem mnu_Help;
        private ToolStripMenuItem exampleToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSp_New;
        private ToolStripButton btnSp_Save;
        private ToolStripButton btnSp_Cut;
    }
}
