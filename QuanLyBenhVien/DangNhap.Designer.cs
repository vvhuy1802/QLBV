
namespace QuanLyBenhVien
{
    partial class DangNhap
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
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            DevExpress.Sparkline.LineSparklineView lineSparklineView2 = new DevExpress.Sparkline.LineSparklineView();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.sparklineEdit2 = new DevExpress.XtraEditors.SparklineEdit();
            this.sparklineEdit1 = new DevExpress.XtraEditors.SparklineEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btndangnhap.FlatAppearance.BorderSize = 0;
            this.btndangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.Black;
            this.btndangnhap.Location = new System.Drawing.Point(197, 300);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(278, 46);
            this.btndangnhap.TabIndex = 11;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // sparklineEdit2
            // 
            this.sparklineEdit2.Location = new System.Drawing.Point(185, 266);
            this.sparklineEdit2.Name = "sparklineEdit2";
            this.sparklineEdit2.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.sparklineEdit2.Properties.Appearance.Options.UseBackColor = true;
            lineSparklineView1.ScaleFactor = 1F;
            this.sparklineEdit2.Properties.View = lineSparklineView1;
            this.sparklineEdit2.Size = new System.Drawing.Size(278, 1);
            this.sparklineEdit2.TabIndex = 16;
            // 
            // sparklineEdit1
            // 
            this.sparklineEdit1.Location = new System.Drawing.Point(185, 216);
            this.sparklineEdit1.Name = "sparklineEdit1";
            this.sparklineEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.sparklineEdit1.Properties.Appearance.Options.UseBackColor = true;
            lineSparklineView2.ScaleFactor = 1F;
            this.sparklineEdit1.Properties.View = lineSparklineView2;
            this.sparklineEdit1.Size = new System.Drawing.Size(278, 1);
            this.sparklineEdit1.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(217, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 32);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Quản lý bệnh viện";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(197, 244);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(278, 19);
            this.password.TabIndex = 14;
            this.password.Text = "PASSWORD";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(197, 195);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(278, 19);
            this.username.TabIndex = 13;
            this.username.Text = "USERNAME";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLyBenhVien.Properties.Resources.camila_vignoni_fondo_hospital;
            this.ClientSize = new System.Drawing.Size(655, 451);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.sparklineEdit2);
            this.Controls.Add(this.sparklineEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.DangNhap_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangnhap;
        private DevExpress.XtraEditors.SparklineEdit sparklineEdit2;
        private DevExpress.XtraEditors.SparklineEdit sparklineEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
    }
}

