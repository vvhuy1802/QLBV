
namespace QuanLyBenhVien.UI
{
    partial class uc_Quanlybenh
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
            this.txbbenh = new System.Windows.Forms.RichTextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxbenh = new System.Windows.Forms.ComboBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.dtgvbenh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbenh)).BeginInit();
            this.SuspendLayout();
            // 
            // txbbenh
            // 
            this.txbbenh.Location = new System.Drawing.Point(544, 234);
            this.txbbenh.Name = "txbbenh";
            this.txbbenh.Size = new System.Drawing.Size(207, 73);
            this.txbbenh.TabIndex = 153;
            this.txbbenh.Text = "";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(772, 187);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 152;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 151;
            this.label4.Text = "Tìm Kiếm";
            // 
            // txbcmnd
            // 
            this.txbcmnd.Location = new System.Drawing.Point(604, 122);
            this.txbcmnd.Name = "txbcmnd";
            this.txbcmnd.Size = new System.Drawing.Size(147, 20);
            this.txbcmnd.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 149;
            this.label3.Text = "CMND";
            // 
            // txbten
            // 
            this.txbten.Location = new System.Drawing.Point(604, 58);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(147, 20);
            this.txbten.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 147;
            this.label1.Text = "Tên Bệnh Nhân";
            // 
            // cbxbenh
            // 
            this.cbxbenh.FormattingEnabled = true;
            this.cbxbenh.Location = new System.Drawing.Point(604, 187);
            this.cbxbenh.Name = "cbxbenh";
            this.cbxbenh.Size = new System.Drawing.Size(147, 21);
            this.cbxbenh.TabIndex = 146;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(676, 334);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 145;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 144;
            this.label2.Text = "Tên loại bệnh";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(517, 334);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 143;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.Location = new System.Drawing.Point(213, 21);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(180, 24);
            this.txbtimkiem.TabIndex = 142;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // dtgvbenh
            // 
            this.dtgvbenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbenh.Location = new System.Drawing.Point(83, 63);
            this.dtgvbenh.Name = "dtgvbenh";
            this.dtgvbenh.RowHeadersWidth = 45;
            this.dtgvbenh.Size = new System.Drawing.Size(370, 321);
            this.dtgvbenh.TabIndex = 141;
            // 
            // uc_Quanlybenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbbenh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbcmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxbenh);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.dtgvbenh);
            this.Name = "uc_Quanlybenh";
            this.Size = new System.Drawing.Size(931, 495);
            this.Load += new System.EventHandler(this.uc_Quanlybenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbbenh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxbenh;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.DataGridView dtgvbenh;
    }
}
