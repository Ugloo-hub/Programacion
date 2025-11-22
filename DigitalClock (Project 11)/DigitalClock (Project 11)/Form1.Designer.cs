namespace DigitalClock__Project_11_
{
    partial class clock
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 100F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(1244, 361);
            label1.TabIndex = 0;
            label1.Text = "00:00:00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1268, 641);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "clock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Clock";
            Load += clock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
