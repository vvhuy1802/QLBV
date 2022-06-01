
namespace QuanLyBenhVien.UI
{
    partial class uc_Doimatkhau2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtpassnew2 = new System.Windows.Forms.TextBox();
            this.txtpassnew1 = new System.Windows.Forms.TextBox();
            this.txtpassold = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyBenhVien.Properties.Resources._352084_save_guardar_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(717, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 53);
            this.button1.TabIndex = 53;
            this.button1.Text = "Lưu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpassnew2
            // 
            this.txtpassnew2.Location = new System.Drawing.Point(582, 404);
            this.txtpassnew2.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassnew2.Name = "txtpassnew2";
            this.txtpassnew2.Size = new System.Drawing.Size(267, 22);
            this.txtpassnew2.TabIndex = 52;
            this.txtpassnew2.TextChanged += new System.EventHandler(this.txtpassnew2_TextChanged);
            // 
            // txtpassnew1
            // 
            this.txtpassnew1.Location = new System.Drawing.Point(582, 333);
            this.txtpassnew1.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassnew1.Name = "txtpassnew1";
            this.txtpassnew1.Size = new System.Drawing.Size(267, 22);
            this.txtpassnew1.TabIndex = 51;
            this.txtpassnew1.TextChanged += new System.EventHandler(this.txtpassnew1_TextChanged);
            // 
            // txtpassold
            // 
            this.txtpassold.Location = new System.Drawing.Point(582, 253);
            this.txtpassold.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.Size = new System.Drawing.Size(267, 22);
            this.txtpassold.TabIndex = 50;
            this.txtpassold.TextChanged += new System.EventHandler(this.txtpassold_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(303, 253);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 29);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Mật khẩu hiện tại:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(242, 399);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(265, 29);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(343, 327);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 29);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Mật khẩu mới:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // uc_Doimatkhau2
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
            this.Name = "uc_Doimatkhau2";
            this.Size = new System.Drawing.Size(1180, 800);
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
