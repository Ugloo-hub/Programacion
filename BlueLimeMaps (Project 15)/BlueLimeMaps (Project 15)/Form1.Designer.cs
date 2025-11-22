namespace BlueLimeMaps__Project_15_
{
    partial class frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.zipCodeLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.streetLbl = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zipCodeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.stateLbl);
            this.splitContainer1.Panel1.Controls.Add(this.cityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.streetLbl);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxZip);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxStreet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(45, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // zipCodeLbl
            // 
            this.zipCodeLbl.AutoSize = true;
            this.zipCodeLbl.Location = new System.Drawing.Point(12, 196);
            this.zipCodeLbl.Name = "zipCodeLbl";
            this.zipCodeLbl.Size = new System.Drawing.Size(50, 13);
            this.zipCodeLbl.TabIndex = 7;
            this.zipCodeLbl.Text = "Zip Code";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(27, 136);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(29, 13);
            this.stateLbl.TabIndex = 6;
            this.stateLbl.Text = "Sate";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(27, 76);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(24, 13);
            this.cityLbl.TabIndex = 5;
            this.cityLbl.Text = "City";
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(27, 25);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(35, 13);
            this.streetLbl.TabIndex = 4;
            this.streetLbl.Text = "Street";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(68, 73);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCity.TabIndex = 3;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(68, 133);
            this.txtBoxState.Multiline = true;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(100, 20);
            this.txtBoxState.TabIndex = 2;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(68, 193);
            this.txtBoxZip.Multiline = true;
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(100, 20);
            this.txtBoxZip.TabIndex = 1;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(68, 22);
            this.txtBoxStreet.Multiline = true;
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStreet.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowExternalDrop = true;
            this.webBrowser1.CreationProperties = null;
            this.webBrowser1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webBrowser1.Location = new System.Drawing.Point(3, 0);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(527, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ZoomFactor = 1D;

            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm";
            this.Text = "Blue Lime Maps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label zipCodeLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label streetLbl;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser1;
    }
}

