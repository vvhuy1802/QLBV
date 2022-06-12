
namespace QuanLyBenhVien
{
    partial class QuanLy
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
            this.mainContainer2 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnQuanlynhansu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlynhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlybangluong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlydichvu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyloaibenh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyloaithuoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyhethong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyletan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlybacsi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThongtinquanly = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTennhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoimatkhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbltieude2 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer2
            // 
            this.mainContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer2.Location = new System.Drawing.Point(260, 31);
            this.mainContainer2.Name = "mainContainer2";
            this.mainContainer2.Size = new System.Drawing.Size(853, 608);
            this.mainContainer2.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlynhansu,
            this.mnQuanlydichvu,
            this.mnQuanlyhethong,
            this.mnThongtinquanly});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 608);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnQuanlynhansu
            // 
            this.mnQuanlynhansu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlynhanvien,
            this.mnQuanlybangluong});
            this.mnQuanlynhansu.Expanded = true;
            this.mnQuanlynhansu.Name = "mnQuanlynhansu";
            this.mnQuanlynhansu.Text = "Quản lý nhân sự";
            this.mnQuanlynhansu.Click += new System.EventHandler(this.mnQuanlynhansu_Click);
            // 
            // mnQuanlynhanvien
            // 
            this.mnQuanlynhanvien.Name = "mnQuanlynhanvien";
            this.mnQuanlynhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlynhanvien.Text = "Quản lý nhân viên";
            this.mnQuanlynhanvien.Click += new System.EventHandler(this.mnQuanlynhanvien_Click);
            // 
            // mnQuanlybangluong
            // 
            this.mnQuanlybangluong.Name = "mnQuanlybangluong";
            this.mnQuanlybangluong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlybangluong.Text = "Quản lý bảng lương";
            this.mnQuanlybangluong.Click += new System.EventHandler(this.mnQuanlybangluong_Click);
            // 
            // mnQuanlydichvu
            // 
            this.mnQuanlydichvu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlyloaibenh,
            this.mnQuanlyloaithuoc});
            this.mnQuanlydichvu.Expanded = true;
            this.mnQuanlydichvu.Name = "mnQuanlydichvu";
            this.mnQuanlydichvu.Text = "Quản lý dịch vụ";
            // 
            // mnQuanlyloaibenh
            // 
            this.mnQuanlyloaibenh.Name = "mnQuanlyloaibenh";
            this.mnQuanlyloaibenh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyloaibenh.Text = "Quản lý loại bệnh";
            this.mnQuanlyloaibenh.Click += new System.EventHandler(this.mnQuanlyloaibenh_Click_2);
            // 
            // mnQuanlyloaithuoc
            // 
            this.mnQuanlyloaithuoc.Name = "mnQuanlyloaithuoc";
            this.mnQuanlyloaithuoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyloaithuoc.Text = "Quản lý loại thuốc";
            this.mnQuanlyloaithuoc.Click += new System.EventHandler(this.mnQuanlyloaithuoc_Click_1);
            // 
            // mnQuanlyhethong
            // 
            this.mnQuanlyhethong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlyletan,
            this.mnQuanlybacsi});
            this.mnQuanlyhethong.Expanded = true;
            this.mnQuanlyhethong.Name = "mnQuanlyhethong";
            this.mnQuanlyhethong.Text = "Quản lý hệ thống";
            this.mnQuanlyhethong.Click += new System.EventHandler(this.mnQuanlyhethong_Click);
            // 
            // mnQuanlyletan
            // 
            this.mnQuanlyletan.Name = "mnQuanlyletan";
            this.mnQuanlyletan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyletan.Text = "Quản lý lễ tân";
            this.mnQuanlyletan.Click += new System.EventHandler(this.mnQuanlyletan_Click);
            // 
            // mnQuanlybacsi
            // 
            this.mnQuanlybacsi.Name = "mnQuanlybacsi";
            this.mnQuanlybacsi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlybacsi.Text = "Quản lý bác sĩ";
            this.mnQuanlybacsi.Click += new System.EventHandler(this.mnQuanlybacsi_Click);
            // 
            // mnThongtinquanly
            // 
            this.mnThongtinquanly.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTennhanvien,
            this.mnDoimatkhau,
            this.mnDangxuat});
            this.mnThongtinquanly.Expanded = true;
            this.mnThongtinquanly.Name = "mnThongtinquanly";
            this.mnThongtinquanly.Text = "Thông tin quản lý";
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
            this.lbltieude2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1113, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lbltieude2);
            // 
            // lbltieude2
            // 
            this.lbltieude2.Caption = "Demo Quản lý";
            this.lbltieude2.Id = 0;
            this.lbltieude2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltieude2.ItemAppearance.Normal.Options.UseFont = true;
            this.lbltieude2.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbltieude2.Name = "lbltieude2";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 639);
            this.ControlContainer = this.mainContainer2;
            this.Controls.Add(this.mainContainer2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLy";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlynhansu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlynhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlybangluong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyhethong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyletan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlybacsi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtinquanly;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTennhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoimatkhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDangxuat;
        private DevExpress.XtraBars.BarStaticItem lbltieude2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlydichvu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyloaibenh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyloaithuoc;
    }
}