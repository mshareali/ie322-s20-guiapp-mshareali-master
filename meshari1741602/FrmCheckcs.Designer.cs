namespace meshari1741602
{
    partial class FrmCheckcs
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.Chkcoffe = new System.Windows.Forms.CheckBox();
            this.chkDounat = new System.Windows.Forms.CheckBox();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(93, 59);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(136, 67);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Chkcoffe
            // 
            this.Chkcoffe.AutoSize = true;
            this.Chkcoffe.Location = new System.Drawing.Point(75, 156);
            this.Chkcoffe.Name = "Chkcoffe";
            this.Chkcoffe.Size = new System.Drawing.Size(71, 21);
            this.Chkcoffe.TabIndex = 1;
            this.Chkcoffe.Text = "Coffee";
            this.Chkcoffe.UseVisualStyleBackColor = true;
            // 
            // chkDounat
            // 
            this.chkDounat.AutoSize = true;
            this.chkDounat.Location = new System.Drawing.Point(75, 225);
            this.chkDounat.Name = "chkDounat";
            this.chkDounat.Size = new System.Drawing.Size(68, 21);
            this.chkDounat.TabIndex = 2;
            this.chkDounat.Text = "Dount";
            this.chkDounat.UseVisualStyleBackColor = true;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(75, 287);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(80, 21);
            this.chkBrownie.TabIndex = 3;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCheckcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkBrownie);
            this.Controls.Add(this.chkDounat);
            this.Controls.Add(this.Chkcoffe);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheckcs";
            this.Text = "FrmCheckcs";
            this.Load += new System.EventHandler(this.FrmCheckcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox Chkcoffe;
        private System.Windows.Forms.CheckBox chkDounat;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.Button button2;
    }
}