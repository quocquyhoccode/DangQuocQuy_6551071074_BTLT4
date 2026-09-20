namespace StepByStep2_19
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            mnuMainMenu = new MenuStrip();
            contextMenuToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            mnuContext = new ContextMenuStrip(components);
            mnuMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.ImageScalingSize = new Size(20, 20);
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { contextMenuToolStripMenuItem });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(800, 28);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "mnuMainMenu";
            // 
            // contextMenuToolStripMenuItem
            // 
            contextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuToolStripMenuItem.Name = "contextMenuToolStripMenuItem";
            contextMenuToolStripMenuItem.Size = new Size(115, 24);
            contextMenuToolStripMenuItem.Text = "Context Menu";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(224, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(224, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(20, 20);
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(211, 32);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMainMenu);
            MainMenuStrip = mnuMainMenu;
            Name = "Form1";
            Text = "StepByStep2_19";
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMainMenu;
        private ToolStripMenuItem contextMenuToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
        private ContextMenuStrip mnuContext;
    }
}
