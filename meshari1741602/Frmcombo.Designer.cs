﻿namespace meshari1741602
{
    partial class FrmCombo
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnBackCombo = new System.Windows.Forms.Button();
            this.BtnRemoveLastitem = new System.Windows.Forms.Button();
            this.BtnRemove2ndItem = new System.Windows.Forms.Button();
            this.BtnRemoveName = new System.Windows.Forms.Button();
            this.BtnRemoveInd = new System.Windows.Forms.Button();
            this.BtnMethood2 = new System.Windows.Forms.Button();
            this.BtnMethood1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(92, 106);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(195, 24);
            this.CmbDays.TabIndex = 0;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnBackCombo
            // 
            this.BtnBackCombo.Location = new System.Drawing.Point(501, 282);
            this.BtnBackCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackCombo.Name = "BtnBackCombo";
            this.BtnBackCombo.Size = new System.Drawing.Size(67, 26);
            this.BtnBackCombo.TabIndex = 3;
            this.BtnBackCombo.Text = "Back";
            this.BtnBackCombo.UseVisualStyleBackColor = true;
            this.BtnBackCombo.Click += new System.EventHandler(this.BtnBackCombo_Click);
            // 
            // BtnRemoveLastitem
            // 
            this.BtnRemoveLastitem.Location = new System.Drawing.Point(457, 66);
            this.BtnRemoveLastitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveLastitem.Name = "BtnRemoveLastitem";
            this.BtnRemoveLastitem.Size = new System.Drawing.Size(111, 52);
            this.BtnRemoveLastitem.TabIndex = 4;
            this.BtnRemoveLastitem.Text = "Remove Last Item";
            this.BtnRemoveLastitem.UseVisualStyleBackColor = true;
            this.BtnRemoveLastitem.Click += new System.EventHandler(this.BtnRemoveLastitem_Click);
            // 
            // BtnRemove2ndItem
            // 
            this.BtnRemove2ndItem.Location = new System.Drawing.Point(457, 145);
            this.BtnRemove2ndItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemove2ndItem.Name = "BtnRemove2ndItem";
            this.BtnRemove2ndItem.Size = new System.Drawing.Size(111, 52);
            this.BtnRemove2ndItem.TabIndex = 5;
            this.BtnRemove2ndItem.Text = "Remove 2nd Last Item";
            this.BtnRemove2ndItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndItem.Click += new System.EventHandler(this.BtnRemove2ndItem_Click);
            // 
            // BtnRemoveName
            // 
            this.BtnRemoveName.Location = new System.Drawing.Point(175, 172);
            this.BtnRemoveName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveName.Name = "BtnRemoveName";
            this.BtnRemoveName.Size = new System.Drawing.Size(111, 52);
            this.BtnRemoveName.TabIndex = 6;
            this.BtnRemoveName.Text = "Remove By Name";
            this.BtnRemoveName.UseVisualStyleBackColor = true;
            this.BtnRemoveName.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnRemoveInd
            // 
            this.BtnRemoveInd.Location = new System.Drawing.Point(36, 172);
            this.BtnRemoveInd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveInd.Name = "BtnRemoveInd";
            this.BtnRemoveInd.Size = new System.Drawing.Size(111, 52);
            this.BtnRemoveInd.TabIndex = 7;
            this.BtnRemoveInd.Text = "Remove By index";
            this.BtnRemoveInd.UseVisualStyleBackColor = true;
            this.BtnRemoveInd.Click += new System.EventHandler(this.BtnRemoveInd_Click);
            // 
            // BtnMethood2
            // 
            this.BtnMethood2.Location = new System.Drawing.Point(175, 14);
            this.BtnMethood2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMethood2.Name = "BtnMethood2";
            this.BtnMethood2.Size = new System.Drawing.Size(139, 78);
            this.BtnMethood2.TabIndex = 8;
            this.BtnMethood2.Text = "Show selected Methoode 2";
            this.BtnMethood2.UseVisualStyleBackColor = true;
            this.BtnMethood2.Click += new System.EventHandler(this.BtnMethood2_Click);
            // 
            // BtnMethood1
            // 
            this.BtnMethood1.Location = new System.Drawing.Point(36, 23);
            this.BtnMethood1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMethood1.Name = "BtnMethood1";
            this.BtnMethood1.Size = new System.Drawing.Size(111, 52);
            this.BtnMethood1.TabIndex = 9;
            this.BtnMethood1.Text = "Show slected methood 1";
            this.BtnMethood1.UseVisualStyleBackColor = true;
            this.BtnMethood1.Click += new System.EventHandler(this.BtnMethood1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Days";
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMethood1);
            this.Controls.Add(this.BtnMethood2);
            this.Controls.Add(this.BtnRemoveInd);
            this.Controls.Add(this.BtnRemoveName);
            this.Controls.Add(this.BtnRemove2ndItem);
            this.Controls.Add(this.BtnRemoveLastitem);
            this.Controls.Add(this.BtnBackCombo);
            this.Controls.Add(this.CmbDays);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.Load += new System.EventHandler(this.FrmCombo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnBackCombo;
        private System.Windows.Forms.Button BtnRemoveLastitem;
        private System.Windows.Forms.Button BtnRemove2ndItem;
        private System.Windows.Forms.Button BtnRemoveName;
        private System.Windows.Forms.Button BtnRemoveInd;
        private System.Windows.Forms.Button BtnMethood2;
        private System.Windows.Forms.Button BtnMethood1;
        private System.Windows.Forms.Label label1;
    }
}