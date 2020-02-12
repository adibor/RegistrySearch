namespace SearchForm
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
            this.TermLbl = new System.Windows.Forms.Label();
            this.optionLbl = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.resLbl = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resList = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusLbl = new System.Windows.Forms.Label();
            this.clrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TermLbl
            // 
            this.TermLbl.AutoSize = true;
            this.TermLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TermLbl.Location = new System.Drawing.Point(93, 35);
            this.TermLbl.Name = "TermLbl";
            this.TermLbl.Size = new System.Drawing.Size(67, 13);
            this.TermLbl.TabIndex = 0;
            this.TermLbl.Text = "Search term:";
            this.TermLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // optionLbl
            // 
            this.optionLbl.AutoSize = true;
            this.optionLbl.Location = new System.Drawing.Point(93, 75);
            this.optionLbl.Name = "optionLbl";
            this.optionLbl.Size = new System.Drawing.Size(81, 13);
            this.optionLbl.TabIndex = 1;
            this.optionLbl.Text = "Search options:";
            this.optionLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(167, 35);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(542, 20);
            this.termTextBox.TabIndex = 2;
            this.termTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resLbl
            // 
            this.resLbl.AutoSize = true;
            this.resLbl.Location = new System.Drawing.Point(93, 109);
            this.resLbl.Name = "resLbl";
            this.resLbl.Size = new System.Drawing.Size(45, 13);
            this.resLbl.TabIndex = 4;
            this.resLbl.Text = "Results:";
            this.resLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(246, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Value";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton2.Location = new System.Drawing.Point(182, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Key";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(742, 35);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resList
            // 
            this.resList.FormattingEnabled = true;
            this.resList.Location = new System.Drawing.Point(167, 109);
            this.resList.Name = "resList";
            this.resList.Size = new System.Drawing.Size(650, 212);
            this.resList.TabIndex = 8;
            this.resList.SelectedIndexChanged += new System.EventHandler(this.resList_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.Red;
            this.statusLbl.Location = new System.Drawing.Point(164, 9);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 10;
            this.statusLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clrBtn.Location = new System.Drawing.Point(742, 65);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 11;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 396);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.resList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.resLbl);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.optionLbl);
            this.Controls.Add(this.TermLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TermLbl;
        private System.Windows.Forms.Label optionLbl;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.Label resLbl;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox resList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button clrBtn;
    }
}

