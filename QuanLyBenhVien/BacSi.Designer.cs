
namespace QuanLyBenhVien
{
    partial class BacSi
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
            this.mainContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnThongtinkhambenh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlybenh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlydonthuoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTennhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoimatkhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieude1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer1
            // 
            this.mainContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainContainer1.Location = new System.Drawing.Point(260, 31);
            this.mainContainer1.Name = "mainContainer1";
            this.mainContainer1.Size = new System.Drawing.Size(431, 442);
            this.mainContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnThongtinkhambenh,
            this.mnThongtincanhan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnThongtinkhambenh
            // 
            this.mnThongtinkhambenh.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlybenh,
            this.mnQuanlydonthuoc});
            this.mnThongtinkhambenh.Expanded = true;
            this.mnThongtinkhambenh.Name = "mnThongtinkhambenh";
            this.mnThongtinkhambenh.Text = "Quản lý khám bệnh";
            // 
            // mnQuanlybenh
            // 
            this.mnQuanlybenh.Name = "mnQuanlybenh";
            this.mnQuanlybenh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlybenh.Text = "Quản lý bệnh";
            this.mnQuanlybenh.Click += new System.EventHandler(this.mnQuanlybenh_Click);
            // 
            // mnQuanlydonthuoc
            // 
            this.mnQuanlydonthuoc.Name = "mnQuanlydonthuoc";
            this.mnQuanlydonthuoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlydonthuoc.Text = "Quản lý đơn thuốc";
            this.mnQuanlydonthuoc.Click += new System.EventHandler(this.mnQuanlydonthuoc_Click);
            // 
            // mnThongtincanhan
            // 
            this.mnThongtincanhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTennhanvien,
            this.mnDoimatkhau,
            this.mnDangxuat});
            this.mnThongtincanhan.Expanded = true;
            this.mnThongtincanhan.Name = "mnThongtincanhan";
            this.mnThongtincanhan.Text = "Thông tin cá nhân";
            // 
            // mnTennhanvien
            // 
            this.mnTennhanvien.Name = "mnTennhanvien";
            this.mnTennhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTennhanvien.Text = "Tên nhân viên";
            this.mnTennhanvien.Click += new System.EventHandler(this.mnTennhanvien_Click);
            // 
            // mnDoimatkhau
            // 
            this.mnDoimatkhau.Name = "mnDoimatkhau";
            this.mnDoimatkhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDoimatkhau.Text = "Đổi mật khẩu";
            this.mnDoimatkhau.Click += new System.EventHandler(this.mnDoimatkhau_Click);
            // 
            // mnDangxuat
            // 
            this.mnDangxuat.Name = "mnDangxuat";
            this.mnDangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDangxuat.Text = "Đăng xuất";
            this.mnDangxuat.Click += new System.EventHandler(this.mnDangxuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieude1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieude1);
            // 
            // lblTieude1
            // 
            this.lblTieude1.Caption = "Demo Bác sĩ";
            this.lblTieude1.Id = 0;
            this.lblTieude1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTieude1.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieude1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieude1.Name = "lblTieude1";
            // 
            // BacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.mainContainer1;
            this.Controls.Add(this.mainContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "BacSi";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản lý Bác sĩ";
            this.Load += new System.EventHandler(this.BacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtinkhambenh;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlybenh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlydonthuoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTennhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoimatkhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDangxuat;
        private DevExpress.XtraBars.BarStaticItem lblTieude1;
    }
}