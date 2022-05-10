
namespace QuanLyBenhVien.UI
{
    partial class uc_Quanlyloaibenh
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.loaiBenhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbgia = new System.Windows.Forms.TextBox();
            this.txbten = new System.Windows.Forms.TextBox();
            this.txbidbenh = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvbenh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBenhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbenh)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tìm Kiếm";
            // 
            // loaiBenhBindingSource
            // 
            this.loaiBenhBindingSource.DataMember = "LoaiBenh";
            // 
            // txbgia
            // 
            this.txbgia.Location = new System.Drawing.Point(580, 200);
            this.txbgia.Name = "txbgia";
            this.txbgia.Size = new System.Drawing.Size(100, 20);
            this.txbgia.TabIndex = 35;
            // 
            // txbten
            // 
            this.txbten.Location = new System.Drawing.Point(580, 139);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(100, 20);
            this.txbten.TabIndex = 34;
            // 
            // txbidbenh
            // 
            this.txbidbenh.Location = new System.Drawing.Point(580, 77);
            this.txbidbenh.Name = "txbidbenh";
            this.txbidbenh.Size = new System.Drawing.Size(100, 20);
            this.txbidbenh.TabIndex = 33;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(662, 265);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 32;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(564, 265);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(451, 265);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 30;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giá Khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên loại bệnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Loại bênh";
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Location = new System.Drawing.Point(115, 21);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(198, 20);
            this.txbtimkiem.TabIndex = 26;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gia";
            this.Column3.HeaderText = "Giá Khám Bệnh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // dtgvbenh
            // 
            this.dtgvbenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvbenh.Location = new System.Drawing.Point(7, 77);
            this.dtgvbenh.Name = "dtgvbenh";
            this.dtgvbenh.RowHeadersWidth = 45;
            this.dtgvbenh.Size = new System.Drawing.Size(438, 376);
            this.dtgvbenh.TabIndex = 25;
            // 
            // uc_Quanlyloaibenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbgia);
            this.Controls.Add(this.txbten);
            this.Controls.Add(this.txbidbenh);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.dtgvbenh);
            this.Name = "uc_Quanlyloaibenh";
            this.Size = new System.Drawing.Size(745, 475);
            this.Load += new System.EventHandler(this.uc_Quanlyloaibenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiBenhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource loaiBenhBindingSource;
        private System.Windows.Forms.TextBox txbgia;
        private System.Windows.Forms.TextBox txbten;
        private System.Windows.Forms.TextBox txbidbenh;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dtgvbenh;
    }
}
