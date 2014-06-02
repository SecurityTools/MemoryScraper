namespace MemoryScraper
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.titleLBL = new System.Windows.Forms.Label();
            this.procsListBtn = new System.Windows.Forms.Button();
            this.creditLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titleLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLBL.Location = new System.Drawing.Point(77, 44);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(261, 37);
            this.titleLBL.TabIndex = 0;
            this.titleLBL.Text = "Memory Scraper ";
            // 
            // procsListBtn
            // 
            this.procsListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.procsListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.procsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.procsListBtn.Location = new System.Drawing.Point(84, 111);
            this.procsListBtn.Name = "procsListBtn";
            this.procsListBtn.Size = new System.Drawing.Size(229, 42);
            this.procsListBtn.TabIndex = 2;
            this.procsListBtn.Text = "Run";
            this.procsListBtn.UseVisualStyleBackColor = false;
            this.procsListBtn.Click += new System.EventHandler(this.procsListBtn_Click);
            // 
            // creditLbl
            // 
            this.creditLbl.AutoSize = true;
            this.creditLbl.BackColor = System.Drawing.Color.Transparent;
            this.creditLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.creditLbl.ForeColor = System.Drawing.Color.Black;
            this.creditLbl.Location = new System.Drawing.Point(167, 191);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(68, 22);
            this.creditLbl.TabIndex = 7;
            this.creditLbl.Text = "Credits";
            this.creditLbl.Click += new System.EventHandler(this.creditLbl_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.procsListBtn);
            this.Controls.Add(this.titleLBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 300);
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "FirstPage";
            this.Text = "Memory Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Button procsListBtn;
        private System.Windows.Forms.Label creditLbl;
    }
}