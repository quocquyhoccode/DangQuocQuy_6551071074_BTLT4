namespace BTb3
{
    partial class Example1
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
            txtb_Exmaple1 = new TextBox();
            SuspendLayout();
            // 
            // txtb_Exmaple1
            // 
            txtb_Exmaple1.Dock = DockStyle.Fill;
            txtb_Exmaple1.Location = new Point(0, 0);
            txtb_Exmaple1.Multiline = true;
            txtb_Exmaple1.Name = "txtb_Exmaple1";
            txtb_Exmaple1.ScrollBars = ScrollBars.Vertical;
            txtb_Exmaple1.Size = new Size(669, 327);
            txtb_Exmaple1.TabIndex = 0;
            txtb_Exmaple1.Text = "hhhh";
            // 
            // Example1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 327);
            Controls.Add(txtb_Exmaple1);
            Name = "Example1";
            Text = "Example1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_Exmaple1;
    }
}