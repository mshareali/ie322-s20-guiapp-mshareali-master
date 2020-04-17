namespace meshari1741602
{
    partial class FrmRandomCombo
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
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.RdoGrater500 = new System.Windows.Forms.RadioButton();
            this.RdoLess500 = new System.Windows.Forms.RadioButton();
            this.BtnGenrate1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RdoGrater50 = new System.Windows.Forms.RadioButton();
            this.RdoLess50 = new System.Windows.Forms.RadioButton();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.BtnGenrate2 = new System.Windows.Forms.Button();
            this.Btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(5, 61);
            this.CmbRandom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(108, 24);
            this.CmbRandom1.TabIndex = 0;
            this.CmbRandom1.SelectedIndexChanged += new System.EventHandler(this.CmbRandom1_SelectedIndexChanged);
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(22, 38);
            this.CmbRandom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(108, 24);
            this.CmbRandom2.TabIndex = 1;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.RdoGrater500);
            this.groupBox1.Controls.Add(this.RdoLess500);
            this.groupBox1.Controls.Add(this.BtnGenrate1);
            this.groupBox1.Controls.Add(this.CmbRandom1);
            this.groupBox1.Location = new System.Drawing.Point(55, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(287, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(64, 150);
            this.BtnReset1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(67, 27);
            this.BtnReset1.TabIndex = 4;
            this.BtnReset1.Text = "reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // RdoGrater500
            // 
            this.RdoGrater500.AutoSize = true;
            this.RdoGrater500.Location = new System.Drawing.Point(97, 119);
            this.RdoGrater500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoGrater500.Name = "RdoGrater500";
            this.RdoGrater500.Size = new System.Drawing.Size(138, 21);
            this.RdoGrater500.TabIndex = 3;
            this.RdoGrater500.TabStop = true;
            this.RdoGrater500.Text = "Greater than 500";
            this.RdoGrater500.UseVisualStyleBackColor = true;
            // 
            // RdoLess500
            // 
            this.RdoLess500.AutoSize = true;
            this.RdoLess500.Location = new System.Drawing.Point(97, 95);
            this.RdoLess500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoLess500.Name = "RdoLess500";
            this.RdoLess500.Size = new System.Drawing.Size(119, 21);
            this.RdoLess500.TabIndex = 2;
            this.RdoLess500.TabStop = true;
            this.RdoLess500.Text = "Less than 500";
            this.RdoLess500.UseVisualStyleBackColor = true;
            this.RdoLess500.CheckedChanged += new System.EventHandler(this.RdoLess500_CheckedChanged);
            // 
            // BtnGenrate1
            // 
            this.BtnGenrate1.Location = new System.Drawing.Point(168, 61);
            this.BtnGenrate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenrate1.Name = "BtnGenrate1";
            this.BtnGenrate1.Size = new System.Drawing.Size(86, 30);
            this.BtnGenrate1.TabIndex = 1;
            this.BtnGenrate1.Text = "Generate";
            this.BtnGenrate1.UseVisualStyleBackColor = true;
            this.BtnGenrate1.Click += new System.EventHandler(this.BtnGenrate1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RdoGrater50);
            this.groupBox2.Controls.Add(this.RdoLess50);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.BtnGenrate2);
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Location = new System.Drawing.Point(348, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(258, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "count";
            // 
            // RdoGrater50
            // 
            this.RdoGrater50.AutoSize = true;
            this.RdoGrater50.Location = new System.Drawing.Point(92, 90);
            this.RdoGrater50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoGrater50.Name = "RdoGrater50";
            this.RdoGrater50.Size = new System.Drawing.Size(130, 21);
            this.RdoGrater50.TabIndex = 6;
            this.RdoGrater50.TabStop = true;
            this.RdoGrater50.Text = "Greater than 50";
            this.RdoGrater50.UseVisualStyleBackColor = true;
            // 
            // RdoLess50
            // 
            this.RdoLess50.AutoSize = true;
            this.RdoLess50.Location = new System.Drawing.Point(92, 66);
            this.RdoLess50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoLess50.Name = "RdoLess50";
            this.RdoLess50.Size = new System.Drawing.Size(111, 21);
            this.RdoLess50.TabIndex = 5;
            this.RdoLess50.TabStop = true;
            this.RdoLess50.Text = "Less than 50";
            this.RdoLess50.UseVisualStyleBackColor = true;
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(107, 122);
            this.BtnReset2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(67, 37);
            this.BtnReset2.TabIndex = 4;
            this.BtnReset2.Text = "reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            // 
            // BtnGenrate2
            // 
            this.BtnGenrate2.Location = new System.Drawing.Point(164, 30);
            this.BtnGenrate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenrate2.Name = "BtnGenrate2";
            this.BtnGenrate2.Size = new System.Drawing.Size(77, 30);
            this.BtnGenrate2.TabIndex = 2;
            this.BtnGenrate2.Text = "Generate";
            this.BtnGenrate2.UseVisualStyleBackColor = true;
            this.BtnGenrate2.Click += new System.EventHandler(this.BtnGenrate2_Click);
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(429, 306);
            this.Btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(67, 28);
            this.Btnback.TabIndex = 4;
            this.Btnback.Text = "back";
            this.Btnback.UseVisualStyleBackColor = true;
            this.Btnback.Click += new System.EventHandler(this.Btnback_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.Btnback);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.Load += new System.EventHandler(this.PicTry1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RdoGrater500;
        private System.Windows.Forms.RadioButton RdoLess500;
        private System.Windows.Forms.Button BtnGenrate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdoGrater50;
        private System.Windows.Forms.RadioButton RdoLess50;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.Button BtnGenrate2;
        private System.Windows.Forms.Button Btnback;
    }
}