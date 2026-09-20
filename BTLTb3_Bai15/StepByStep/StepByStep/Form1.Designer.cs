namespace StepByStep
{
    partial class frmStepByStep
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
            lblColor = new Label();
            lblSize = new Label();
            lblSampleText = new Label();
            dudColor = new DomainUpDown();
            nudSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(75, 145);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(75, 235);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 20F);
            lblSampleText.Location = new Point(161, 344);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(200, 46);
            lblSampleText.TabIndex = 2;
            lblSampleText.Text = "Sample Text";
            // 
            // dudColor
            // 
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Yellow");
            dudColor.Items.Add("Black");
            dudColor.Location = new Point(330, 143);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(150, 27);
            dudColor.TabIndex = 3;
            dudColor.UpDownAlign = LeftRightAlignment.Left;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // nudSize
            // 
            nudSize.Location = new Point(330, 233);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(150, 27);
            nudSize.TabIndex = 4;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // frmStepByStep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 456);
            Controls.Add(nudSize);
            Controls.Add(dudColor);
            Controls.Add(lblSampleText);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            Name = "frmStepByStep";
            Text = "StepByStep2_12";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private Label lblSize;
        private Label lblSampleText;
        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
    }
}
