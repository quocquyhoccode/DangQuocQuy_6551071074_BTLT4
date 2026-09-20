namespace StepByStep2_13
{
    partial class frmStepByStep2_13
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
            dtP = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            lblSelectDay = new Label();
            lblProductLaunchDate = new Label();
            radbtnLongDate = new RadioButton();
            radbtnShortDate = new RadioButton();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblDateStart = new Label();
            lblDateEnd = new Label();
            SuspendLayout();
            // 
            // dtP
            // 
            dtP.Location = new Point(122, 352);
            dtP.Name = "dtP";
            dtP.Size = new Size(250, 27);
            dtP.TabIndex = 0;
            dtP.Value = new DateTime(2002, 6, 8, 0, 0, 0, 0);
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.MenuText;
            monthCalendar1.Location = new Point(96, 72);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2002, 6, 10, 0, 0, 0, 0), new DateTime(2002, 6, 14, 0, 0, 0, 0));
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TitleBackColor = SystemColors.ActiveCaptionText;
            monthCalendar1.TodayDate = new DateTime(2002, 6, 8, 0, 0, 0, 0);
            // 
            // lblSelectDay
            // 
            lblSelectDay.AutoSize = true;
            lblSelectDay.Location = new Point(96, 32);
            lblSelectDay.Name = "lblSelectDay";
            lblSelectDay.Size = new Size(207, 20);
            lblSelectDay.TabIndex = 2;
            lblSelectDay.Text = "Select the days you will travel:";
            // 
            // lblProductLaunchDate
            // 
            lblProductLaunchDate.AutoSize = true;
            lblProductLaunchDate.Location = new Point(122, 310);
            lblProductLaunchDate.Name = "lblProductLaunchDate";
            lblProductLaunchDate.Size = new Size(149, 20);
            lblProductLaunchDate.TabIndex = 3;
            lblProductLaunchDate.Text = "Product Launch Date:";
            // 
            // radbtnLongDate
            // 
            radbtnLongDate.AutoSize = true;
            radbtnLongDate.Location = new Point(122, 400);
            radbtnLongDate.Name = "radbtnLongDate";
            radbtnLongDate.Size = new Size(99, 24);
            radbtnLongDate.TabIndex = 4;
            radbtnLongDate.TabStop = true;
            radbtnLongDate.Text = "Long Date";
            radbtnLongDate.UseVisualStyleBackColor = true;
            // 
            // radbtnShortDate
            // 
            radbtnShortDate.AutoSize = true;
            radbtnShortDate.Location = new Point(366, 400);
            radbtnShortDate.Name = "radbtnShortDate";
            radbtnShortDate.Size = new Size(101, 24);
            radbtnShortDate.TabIndex = 5;
            radbtnShortDate.TabStop = true;
            radbtnShortDate.Text = "Short Date";
            radbtnShortDate.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(540, 82);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(75, 20);
            lblStartDate.TabIndex = 6;
            lblStartDate.Text = "StartDate:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(540, 154);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(69, 20);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "EndDate:";
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(540, 117);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(77, 20);
            lblDateStart.TabIndex = 8;
            lblDateStart.Text = "6/10/2002";
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(540, 189);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(77, 20);
            lblDateEnd.TabIndex = 9;
            lblDateEnd.Text = "6/14/2002";
            // 
            // frmStepByStep2_13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(radbtnShortDate);
            Controls.Add(radbtnLongDate);
            Controls.Add(lblProductLaunchDate);
            Controls.Add(lblSelectDay);
            Controls.Add(monthCalendar1);
            Controls.Add(dtP);
            Name = "frmStepByStep2_13";
            Text = "StepByStep2_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtP;
        private MonthCalendar monthCalendar1;
        private Label lblSelectDay;
        private Label lblProductLaunchDate;
        private RadioButton radbtnLongDate;
        private RadioButton radbtnShortDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblDateStart;
        private Label lblDateEnd;
    }
}
