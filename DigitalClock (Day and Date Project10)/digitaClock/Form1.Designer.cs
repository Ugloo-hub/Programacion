namespace digitaClock
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
            hourMinuteLabel = new Label();
            secondsLabel = new Label();
            dateLabel = new Label();
            weekdayLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hourMinuteLabel
            // 
            hourMinuteLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hourMinuteLabel.ForeColor = SystemColors.ButtonHighlight;
            hourMinuteLabel.Location = new Point(366, 254);
            hourMinuteLabel.Name = "hourMinuteLabel";
            hourMinuteLabel.Size = new Size(678, 178);
            hourMinuteLabel.TabIndex = 0;
            hourMinuteLabel.Text = "19 : 25";
            hourMinuteLabel.Click += hourMinuteLabel_Click;
            // 
            // secondsLabel
            // 
            secondsLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondsLabel.ForeColor = SystemColors.ButtonHighlight;
            secondsLabel.Location = new Point(708, 254);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(170, 178);
            secondsLabel.TabIndex = 1;
            secondsLabel.Text = "47";
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = SystemColors.ButtonHighlight;
            dateLabel.Location = new Point(49, 76);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(678, 178);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Jan 03 2017";
            // 
            // weekdayLabel
            // 
            weekdayLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weekdayLabel.ForeColor = SystemColors.ButtonHighlight;
            weekdayLabel.Location = new Point(733, 76);
            weekdayLabel.Name = "weekdayLabel";
            weekdayLabel.Size = new Size(460, 178);
            weekdayLabel.TabIndex = 3;
            weekdayLabel.Text = "Tuesday";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1295, 671);
            Controls.Add(weekdayLabel);
            Controls.Add(dateLabel);
            Controls.Add(secondsLabel);
            Controls.Add(hourMinuteLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label hourMinuteLabel;
        private Label secondsLabel;
        private Label dateLabel;
        private Label weekdayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
