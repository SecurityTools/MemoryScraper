namespace MemoryScraper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGO = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.creditCardBtn = new System.Windows.Forms.Button();
            this.emailBtn = new System.Windows.Forms.Button();
            this.IpAddressScan = new System.Windows.Forms.Button();
            this.urlScanBtn = new System.Windows.Forms.Button();
            this.LabelEnterString = new System.Windows.Forms.Label();
            this.stropScanBtn = new System.Windows.Forms.Button();
            this.scanStatusLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.titleLbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGO
            // 
            this.buttonGO.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGO.Location = new System.Drawing.Point(361, 229);
            this.buttonGO.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(107, 26);
            this.buttonGO.TabIndex = 0;
            this.buttonGO.Text = "Start scan";
            this.buttonGO.UseVisualStyleBackColor = false;
            this.buttonGO.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(31, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 22);
            this.textBox1.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(32, 279);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.MaximumSize = new System.Drawing.Size(333, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(111, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Search results";
            // 
            // textBoxResult
            // 
            this.textBoxResult.AcceptsReturn = true;
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResult.Location = new System.Drawing.Point(31, 303);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(437, 237);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.WordWrap = false;
            // 
            // creditCardBtn
            // 
            this.creditCardBtn.BackColor = System.Drawing.SystemColors.Control;
            this.creditCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.creditCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creditCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.creditCardBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.creditCardBtn.Location = new System.Drawing.Point(31, 144);
            this.creditCardBtn.Margin = new System.Windows.Forms.Padding(4);
            this.creditCardBtn.Name = "creditCardBtn";
            this.creditCardBtn.Size = new System.Drawing.Size(92, 26);
            this.creditCardBtn.TabIndex = 7;
            this.creditCardBtn.Text = "Credit cards";
            this.creditCardBtn.UseVisualStyleBackColor = false;
            this.creditCardBtn.Click += new System.EventHandler(this.creditCardBtn_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.BackColor = System.Drawing.SystemColors.Control;
            this.emailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.emailBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailBtn.Location = new System.Drawing.Point(131, 144);
            this.emailBtn.Margin = new System.Windows.Forms.Padding(4);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(92, 26);
            this.emailBtn.TabIndex = 8;
            this.emailBtn.Text = "E-mails";
            this.emailBtn.UseVisualStyleBackColor = false;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // IpAddressScan
            // 
            this.IpAddressScan.BackColor = System.Drawing.SystemColors.Control;
            this.IpAddressScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpAddressScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IpAddressScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.IpAddressScan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IpAddressScan.Location = new System.Drawing.Point(331, 144);
            this.IpAddressScan.Margin = new System.Windows.Forms.Padding(4);
            this.IpAddressScan.Name = "IpAddressScan";
            this.IpAddressScan.Size = new System.Drawing.Size(101, 26);
            this.IpAddressScan.TabIndex = 9;
            this.IpAddressScan.Text = "IP Addresses";
            this.IpAddressScan.UseVisualStyleBackColor = false;
            this.IpAddressScan.Click += new System.EventHandler(this.IpAddressScan_Click);
            // 
            // urlScanBtn
            // 
            this.urlScanBtn.BackColor = System.Drawing.SystemColors.Control;
            this.urlScanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urlScanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.urlScanBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urlScanBtn.Location = new System.Drawing.Point(231, 144);
            this.urlScanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.urlScanBtn.Name = "urlScanBtn";
            this.urlScanBtn.Size = new System.Drawing.Size(92, 26);
            this.urlScanBtn.TabIndex = 10;
            this.urlScanBtn.Text = "URLs";
            this.urlScanBtn.UseVisualStyleBackColor = false;
            this.urlScanBtn.Click += new System.EventHandler(this.urlScanBtn_Click);
            // 
            // LabelEnterString
            // 
            this.LabelEnterString.AutoSize = true;
            this.LabelEnterString.BackColor = System.Drawing.Color.Transparent;
            this.LabelEnterString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelEnterString.ForeColor = System.Drawing.Color.Black;
            this.LabelEnterString.Location = new System.Drawing.Point(28, 94);
            this.LabelEnterString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEnterString.Name = "LabelEnterString";
            this.LabelEnterString.Size = new System.Drawing.Size(440, 16);
            this.LabelEnterString.TabIndex = 11;
            this.LabelEnterString.Text = "Enter a regular expression or choose a pre-defined expression";
            this.LabelEnterString.Click += new System.EventHandler(this.LabelEnterString_Click);
            // 
            // stropScanBtn
            // 
            this.stropScanBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stropScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stropScanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.stropScanBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stropScanBtn.Location = new System.Drawing.Point(246, 229);
            this.stropScanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stropScanBtn.Name = "stropScanBtn";
            this.stropScanBtn.Size = new System.Drawing.Size(107, 26);
            this.stropScanBtn.TabIndex = 16;
            this.stropScanBtn.Text = "Stop scan";
            this.stropScanBtn.UseVisualStyleBackColor = false;
            this.stropScanBtn.Click += new System.EventHandler(this.stropScanBtn_Click);
            // 
            // scanStatusLbl
            // 
            this.scanStatusLbl.AutoSize = true;
            this.scanStatusLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scanStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scanStatusLbl.ForeColor = System.Drawing.Color.White;
            this.scanStatusLbl.Location = new System.Drawing.Point(32, 232);
            this.scanStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanStatusLbl.Name = "scanStatusLbl";
            this.scanStatusLbl.Size = new System.Drawing.Size(126, 20);
            this.scanStatusLbl.TabIndex = 17;
            this.scanStatusLbl.Text = "Scan status: idle";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackBtn.Location = new System.Drawing.Point(388, 558);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 32);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // titleLbl1
            // 
            this.titleLbl1.AutoSize = true;
            this.titleLbl1.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titleLbl1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLbl1.Location = new System.Drawing.Point(103, 31);
            this.titleLbl1.Name = "titleLbl1";
            this.titleLbl1.Size = new System.Drawing.Size(267, 37);
            this.titleLbl1.TabIndex = 19;
            this.titleLbl1.Text = "Memory Scraping";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 612);
            this.Controls.Add(this.titleLbl1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.scanStatusLbl);
            this.Controls.Add(this.stropScanBtn);
            this.Controls.Add(this.LabelEnterString);
            this.Controls.Add(this.urlScanBtn);
            this.Controls.Add(this.IpAddressScan);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.creditCardBtn);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGO);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 650);
            this.MinimumSize = new System.Drawing.Size(510, 650);
            this.Name = "Form1";
            this.Text = "Memory Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button creditCardBtn;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.Button IpAddressScan;
        private System.Windows.Forms.Button urlScanBtn;
        private System.Windows.Forms.Label LabelEnterString;
        private System.Windows.Forms.Button stropScanBtn;
        private System.Windows.Forms.Label scanStatusLbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label titleLbl1;
    }
}

