namespace mathsQ
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
            timeLabel = new Label();
            timeLeftTextBox = new Label();
            plusLeftLabel = new Label();
            plusSign = new Label();
            equalSign = new Label();
            sum = new NumericUpDown();
            plusRightLabel = new Label();
            minusRightLabel = new Label();
            difference = new NumericUpDown();
            equalSignTwo = new Label();
            minusSign = new Label();
            minusLeftLabel = new Label();
            timesRightLabel = new Label();
            product = new NumericUpDown();
            equalSignThree = new Label();
            multiplySign = new Label();
            timesLeftLabel = new Label();
            dividedRightLabel = new Label();
            quotient = new NumericUpDown();
            equalSignFour = new Label();
            dividedSign = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(1024, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // timeLeftTextBox
            // 
            timeLeftTextBox.AutoSize = true;
            timeLeftTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLeftTextBox.Location = new Point(819, 9);
            timeLeftTextBox.Name = "timeLeftTextBox";
            timeLeftTextBox.Size = new Size(126, 37);
            timeLeftTextBox.TabIndex = 1;
            timeLeftTextBox.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 15.75F);
            plusLeftLabel.Location = new Point(226, 119);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(100, 30);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            plusSign.AutoSize = true;
            plusSign.Font = new Font("Segoe UI", 15.75F);
            plusSign.Location = new Point(365, 119);
            plusSign.Name = "plusSign";
            plusSign.Size = new Size(27, 30);
            plusSign.TabIndex = 3;
            plusSign.Text = "+";
            // 
            // equalSign
            // 
            equalSign.AutoSize = true;
            equalSign.Font = new Font("Segoe UI", 15.75F);
            equalSign.Location = new Point(526, 123);
            equalSign.Name = "equalSign";
            equalSign.Size = new Size(27, 30);
            equalSign.TabIndex = 5;
            equalSign.Text = "=";
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sum.Location = new Point(573, 125);
            sum.Name = "sum";
            sum.Size = new Size(120, 27);
            sum.TabIndex = 2;
            sum.Enter += answer_Enter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 15.75F);
            plusRightLabel.Location = new Point(420, 119);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(100, 34);
            plusRightLabel.TabIndex = 7;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 15.75F);
            minusRightLabel.Location = new Point(420, 184);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(100, 34);
            minusRightLabel.TabIndex = 12;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difference.Location = new Point(573, 190);
            difference.Name = "difference";
            difference.Size = new Size(120, 27);
            difference.TabIndex = 3;
            // 
            // equalSignTwo
            // 
            equalSignTwo.AutoSize = true;
            equalSignTwo.Font = new Font("Segoe UI", 15.75F);
            equalSignTwo.Location = new Point(526, 188);
            equalSignTwo.Name = "equalSignTwo";
            equalSignTwo.Size = new Size(27, 30);
            equalSignTwo.TabIndex = 10;
            equalSignTwo.Text = "=";
            // 
            // minusSign
            // 
            minusSign.AutoSize = true;
            minusSign.Font = new Font("Segoe UI", 15.75F);
            minusSign.Location = new Point(363, 186);
            minusSign.Name = "minusSign";
            minusSign.Size = new Size(21, 30);
            minusSign.TabIndex = 9;
            minusSign.Text = "-";
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 15.75F);
            minusLeftLabel.Location = new Point(226, 184);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(100, 30);
            minusLeftLabel.TabIndex = 8;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 15.75F);
            timesRightLabel.Location = new Point(420, 240);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(100, 34);
            timesRightLabel.TabIndex = 17;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product.Location = new Point(573, 246);
            product.Name = "product";
            product.Size = new Size(120, 27);
            product.TabIndex = 4;
            // 
            // equalSignThree
            // 
            equalSignThree.AutoSize = true;
            equalSignThree.Font = new Font("Segoe UI", 15.75F);
            equalSignThree.Location = new Point(526, 244);
            equalSignThree.Name = "equalSignThree";
            equalSignThree.Size = new Size(27, 30);
            equalSignThree.TabIndex = 15;
            equalSignThree.Text = "=";
            // 
            // multiplySign
            // 
            multiplySign.AutoSize = true;
            multiplySign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiplySign.Location = new Point(363, 240);
            multiplySign.Name = "multiplySign";
            multiplySign.Size = new Size(17, 21);
            multiplySign.TabIndex = 14;
            multiplySign.Text = "x";
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 15.75F);
            timesLeftLabel.Location = new Point(226, 240);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(100, 30);
            timesLeftLabel.TabIndex = 13;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 15.75F);
            dividedRightLabel.Location = new Point(420, 295);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(100, 34);
            dividedRightLabel.TabIndex = 22;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quotient.Location = new Point(573, 301);
            quotient.Name = "quotient";
            quotient.Size = new Size(120, 27);
            quotient.TabIndex = 5;
            // 
            // equalSignFour
            // 
            equalSignFour.AutoSize = true;
            equalSignFour.Font = new Font("Segoe UI", 15.75F);
            equalSignFour.Location = new Point(526, 299);
            equalSignFour.Name = "equalSignFour";
            equalSignFour.Size = new Size(27, 30);
            equalSignFour.TabIndex = 20;
            equalSignFour.Text = "=";
            // 
            // dividedSign
            // 
            dividedSign.AutoSize = true;
            dividedSign.Font = new Font("Segoe UI", 15.75F);
            dividedSign.Location = new Point(359, 295);
            dividedSign.Name = "dividedSign";
            dividedSign.Size = new Size(27, 30);
            dividedSign.TabIndex = 19;
            dividedSign.Text = "÷";
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 15.75F);
            dividedLeftLabel.Location = new Point(226, 295);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(100, 30);
            dividedLeftLabel.TabIndex = 18;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(226, 372);
            startButton.Name = "startButton";
            startButton.Size = new Size(467, 41);
            startButton.TabIndex = 1;
            startButton.Text = "Start The Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 571);
            Controls.Add(startButton);
            Controls.Add(dividedRightLabel);
            Controls.Add(quotient);
            Controls.Add(equalSignFour);
            Controls.Add(dividedSign);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(product);
            Controls.Add(equalSignThree);
            Controls.Add(multiplySign);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(difference);
            Controls.Add(equalSignTwo);
            Controls.Add(minusSign);
            Controls.Add(minusLeftLabel);
            Controls.Add(plusRightLabel);
            Controls.Add(sum);
            Controls.Add(equalSign);
            Controls.Add(plusSign);
            Controls.Add(plusLeftLabel);
            Controls.Add(timeLeftTextBox);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label timeLeftTextBox;
        private Label plusLeftLabel;
        private Label plusSign;
        private Label equalSign;
        private NumericUpDown sum;
        private Label plusRightLabel;
        private Label minusRightLabel;
        private NumericUpDown difference;
        private Label equalSignTwo;
        private Label minusSign;
        private Label minusLeftLabel;
        private Label timesRightLabel;
        private NumericUpDown product;
        private Label equalSignThree;
        private Label multiplySign;
        private Label timesLeftLabel;
        private Label dividedRightLabel;
        private NumericUpDown quotient;
        private Label equalSignFour;
        private Label dividedSign;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
