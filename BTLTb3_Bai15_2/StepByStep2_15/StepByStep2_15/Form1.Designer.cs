namespace StepByStep2_15
{
    partial class frmStepByStep2_15
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
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            lblProgressIndicator = new Label();
            lblPercentageComplete = new Label();
            lblSlide = new Label();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(133, 329);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(452, 56);
            trackBar1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(133, 147);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(455, 29);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 45;
            // 
            // lblProgressIndicator
            // 
            lblProgressIndicator.AutoSize = true;
            lblProgressIndicator.Location = new Point(133, 79);
            lblProgressIndicator.Name = "lblProgressIndicator";
            lblProgressIndicator.Size = new Size(131, 20);
            lblProgressIndicator.TabIndex = 2;
            lblProgressIndicator.Text = "Progress Indicator:";
            // 
            // lblPercentageComplete
            // 
            lblPercentageComplete.AutoSize = true;
            lblPercentageComplete.Location = new Point(133, 191);
            lblPercentageComplete.Name = "lblPercentageComplete";
            lblPercentageComplete.Size = new Size(186, 20);
            lblPercentageComplete.TabIndex = 3;
            lblPercentageComplete.Text = "Percentage Complete: 45%";
            // 
            // lblSlide
            // 
            lblSlide.AutoSize = true;
            lblSlide.Location = new Point(133, 289);
            lblSlide.Name = "lblSlide";
            lblSlide.Size = new Size(343, 20);
            lblSlide.TabIndex = 4;
            lblSlide.Text = "Slide the TrackBar to control the processing speed:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 450);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // frmStepByStep2_15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(lblSlide);
            Controls.Add(lblPercentageComplete);
            Controls.Add(lblProgressIndicator);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Name = "frmStepByStep2_15";
            Text = "StepByStep2_15";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private Label lblProgressIndicator;
        private Label lblPercentageComplete;
        private Label lblSlide;
        private Splitter splitter1;
    }
}
