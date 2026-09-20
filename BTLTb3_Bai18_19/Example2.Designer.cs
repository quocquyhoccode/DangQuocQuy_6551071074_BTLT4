namespace BTb3
{
    partial class Example2
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
            txtb_Example2 = new TextBox();
            SuspendLayout();
            // 
            // txtb_Example2
            // 
            txtb_Example2.Dock = DockStyle.Fill;
            txtb_Example2.Location = new Point(0, 0);
            txtb_Example2.Multiline = true;
            txtb_Example2.Name = "txtb_Example2";
            txtb_Example2.ScrollBars = ScrollBars.Vertical;
            txtb_Example2.Size = new Size(717, 391);
            txtb_Example2.TabIndex = 0;
            txtb_Example2.Text = "rywyw";
            // 
            // Example2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 391);
            Controls.Add(txtb_Example2);
            Name = "Example2";
            Text = "Example2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_Example2;
    }
}