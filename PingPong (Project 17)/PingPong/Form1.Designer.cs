namespace PingPong
{
    partial class gameForm
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
            this.components = new System.ComponentModel.Container();
            this.playGround = new System.Windows.Forms.Panel();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.score_Lbl = new System.Windows.Forms.Label();
            this.points_Lbl = new System.Windows.Forms.Label();
            this.gameOver_Lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameOver_Lbl);
            this.playGround.Controls.Add(this.points_Lbl);
            this.playGround.Controls.Add(this.score_Lbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(1262, 624);
            this.playGround.TabIndex = 0;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(292, 395);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 26);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Firebrick;
            this.ball.Location = new System.Drawing.Point(12, 212);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // score_Lbl
            // 
            this.score_Lbl.AutoSize = true;
            this.score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_Lbl.Location = new System.Drawing.Point(9, 22);
            this.score_Lbl.Name = "score_Lbl";
            this.score_Lbl.Size = new System.Drawing.Size(46, 16);
            this.score_Lbl.TabIndex = 2;
            this.score_Lbl.Text = "Score:";
            // 
            // points_Lbl
            // 
            this.points_Lbl.AutoSize = true;
            this.points_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_Lbl.Location = new System.Drawing.Point(61, 22);
            this.points_Lbl.Name = "points_Lbl";
            this.points_Lbl.Size = new System.Drawing.Size(14, 16);
            this.points_Lbl.TabIndex = 3;
            this.points_Lbl.Text = "0";
            this.points_Lbl.Click += new System.EventHandler(this.points_Lbl_Click);
            // 
            // gameOver_Lbl
            // 
            this.gameOver_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver_Lbl.Location = new System.Drawing.Point(268, 78);
            this.gameOver_Lbl.Name = "gameOver_Lbl";
            this.gameOver_Lbl.Size = new System.Drawing.Size(311, 259);
            this.gameOver_Lbl.TabIndex = 4;
            this.gameOver_Lbl.Text = "Game Over!\r\n\r\nF1 -> Restart Game\r\n\r\nEsc -> Exit Game\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 624);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label score_Lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label gameOver_Lbl;
        private System.Windows.Forms.Label points_Lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

