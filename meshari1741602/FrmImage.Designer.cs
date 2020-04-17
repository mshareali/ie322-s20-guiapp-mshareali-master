namespace meshari1741602
{
    partial class FrmImage
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
            this.BtnImage = new System.Windows.Forms.Button();
            this.PicTry1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(59, 39);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(142, 44);
            this.BtnImage.TabIndex = 0;
            this.BtnImage.Text = "Image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // PicTry1
            // 
            this.PicTry1.Location = new System.Drawing.Point(62, 89);
            this.PicTry1.Name = "PicTry1";
            this.PicTry1.Size = new System.Drawing.Size(680, 344);
            this.PicTry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry1.TabIndex = 1;
            this.PicTry1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicTry1);
            this.Controls.Add(this.BtnImage);
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.PictureBox PicTry1;
        private System.Windows.Forms.Button button1;
    }
}