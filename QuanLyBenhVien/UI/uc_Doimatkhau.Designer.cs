﻿
namespace QuanLyBenhVien.UI
{
    partial class uc_Doimatkhau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpassnew2 = new System.Windows.Forms.TextBox();
            this.txtpassnew1 = new System.Windows.Forms.TextBox();
            this.txtpassold = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassnew2
            // 
            this.txtpassnew2.Location = new System.Drawing.Point(574, 394);
            this.txtpassnew2.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassnew2.Name = "txtpassnew2";
            this.txtpassnew2.Size = new System.Drawing.Size(265, 22);
            this.txtpassnew2.TabIndex = 38;
            // 
            // txtpassnew1
            // 
            this.txtpassnew1.Location = new System.Drawing.Point(574, 322);
            this.txtpassnew1.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassnew1.Name = "txtpassnew1";
            this.txtpassnew1.Size = new System.Drawing.Size(265, 22);
            this.txtpassnew1.TabIndex = 37;
            // 
            // txtpassold
            // 
            this.txtpassold.Location = new System.Drawing.Point(574, 242);
            this.txtpassold.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.Size = new System.Drawing.Size(265, 22);
            this.txtpassold.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(322, 242);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 29);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(261, 397);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(265, 29);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(362, 322);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 29);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyBenhVien.Properties.Resources._352084_save_guardar_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(711, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 39;
            this.button1.Text = "Lưu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassnew2);
            this.Controls.Add(this.txtpassnew1);
            this.Controls.Add(this.txtpassold);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_Doimatkhau";
            this.Size = new System.Drawing.Size(1180, 800);
            this.Load += new System.EventHandler(this.uc_Doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpassnew2;
        private System.Windows.Forms.TextBox txtpassnew1;
        private System.Windows.Forms.TextBox txtpassold;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
