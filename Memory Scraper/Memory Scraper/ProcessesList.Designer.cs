namespace MemoryScraper
{
    partial class ProcessesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessesList));
            this.BackBtn = new System.Windows.Forms.Button();
            this.titleLbl1 = new System.Windows.Forms.Label();
            this.comboBoxProcesses = new System.Windows.Forms.ComboBox();
            this.scanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackBtn.Location = new System.Drawing.Point(128, 309);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 32);
            this.BackBtn.TabIndex = 0;
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
            this.titleLbl1.Location = new System.Drawing.Point(59, 46);
            this.titleLbl1.Name = "titleLbl1";
            this.titleLbl1.Size = new System.Drawing.Size(224, 37);
            this.titleLbl1.TabIndex = 5;
            this.titleLbl1.Text = "Processes List";
            // 
            // comboBoxProcesses
            // 
            this.comboBoxProcesses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProcesses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProcesses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxProcesses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxProcesses.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProcesses.FormattingEnabled = true;
            this.comboBoxProcesses.Location = new System.Drawing.Point(66, 120);
            this.comboBoxProcesses.Name = "comboBoxProcesses";
            this.comboBoxProcesses.Size = new System.Drawing.Size(225, 23);
            this.comboBoxProcesses.TabIndex = 9;
            // 
            // scanBtn
            // 
            this.scanBtn.BackColor = System.Drawing.SystemColors.Control;
            this.scanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scanBtn.ForeColor = System.Drawing.Color.Black;
            this.scanBtn.Location = new System.Drawing.Point(86, 176);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(172, 30);
            this.scanBtn.TabIndex = 10;
            this.scanBtn.Text = "Select process";
            this.scanBtn.UseVisualStyleBackColor = false;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(86, 236);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(172, 30);
            this.RefreshBtn.TabIndex = 12;
            this.RefreshBtn.Text = "Refresh process list";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ProcessesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 388);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.comboBoxProcesses);
            this.Controls.Add(this.titleLbl1);
            this.Controls.Add(this.BackBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 426);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 426);
            this.Name = "ProcessesList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Memory Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label titleLbl1;
        private System.Windows.Forms.ComboBox comboBoxProcesses;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshBtn;
    }
}