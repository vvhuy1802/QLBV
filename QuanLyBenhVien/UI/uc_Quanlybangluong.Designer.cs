﻿
namespace QuanLyBenhVien.UI
{
    partial class uc_Quanlybangluong
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
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSupportMoney = new System.Windows.Forms.TextBox();
            this.btnEditSalary = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.txbCalculateSalary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbRate = new System.Windows.Forms.TextBox();
            this.txbSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSalary.Location = new System.Drawing.Point(25, 61);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.Size = new System.Drawing.Size(362, 388);
            this.dgvSalary.TabIndex = 0;
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CMND";
            this.Column1.HeaderText = "CMND";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LuongCB";
            this.Column3.HeaderText = "Lương cơ bản";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HeSo";
            this.Column4.HeaderText = "Hệ số";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TroCap";
            this.Column5.HeaderText = "Trợ cấp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lương cơ bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trợ cấp:";
            // 
            // txbCMND
            // 
            this.txbCMND.Location = new System.Drawing.Point(130, 14);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(100, 20);
            this.txbCMND.TabIndex = 5;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(130, 43);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 6;
            // 
            // txbSupportMoney
            // 
            this.txbSupportMoney.Location = new System.Drawing.Point(130, 137);
            this.txbSupportMoney.Name = "txbSupportMoney";
            this.txbSupportMoney.Size = new System.Drawing.Size(100, 20);
            this.txbSupportMoney.TabIndex = 8;
            // 
            // btnEditSalary
            // 
            this.btnEditSalary.Location = new System.Drawing.Point(130, 173);
            this.btnEditSalary.Name = "btnEditSalary";
            this.btnEditSalary.Size = new System.Drawing.Size(75, 23);
            this.btnEditSalary.TabIndex = 9;
            this.btnEditSalary.Text = "Sửa";
            this.btnEditSalary.UseVisualStyleBackColor = true;
            this.btnEditSalary.Click += new System.EventHandler(this.btnEditSalary_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tính lương:";
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(130, 252);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateSalary.TabIndex = 15;
            this.btnCalculateSalary.Text = "Tính";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbCalculateSalary
            // 
            this.txbCalculateSalary.Location = new System.Drawing.Point(130, 216);
            this.txbCalculateSalary.Name = "txbCalculateSalary";
            this.txbCalculateSalary.Size = new System.Drawing.Size(100, 20);
            this.txbCalculateSalary.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbRate);
            this.panel1.Controls.Add(this.txbSalary);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.txbCalculateSalary);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCalculateSalary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbCMND);
            this.panel1.Controls.Add(this.txbSupportMoney);
            this.panel1.Controls.Add(this.btnEditSalary);
            this.panel1.Location = new System.Drawing.Point(392, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 388);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "vnđ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hệ số:";
            // 
            // txbRate
            // 
            this.txbRate.Location = new System.Drawing.Point(130, 107);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(100, 20);
            this.txbRate.TabIndex = 20;
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(130, 75);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(100, 20);
            this.txbSalary.TabIndex = 6;
            // 
            // uc_Quanlybangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSalary);
            this.Name = "uc_Quanlybangluong";
            this.Size = new System.Drawing.Size(1030, 472);
            this.Load += new System.EventHandler(this.uc_Quanlybangluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSupportMoney;
        private System.Windows.Forms.Button btnEditSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.TextBox txbCalculateSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}