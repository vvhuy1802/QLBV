
namespace QuanLyBenhVien
{
    partial class LeTan
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
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnQuanlybenhnhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnthongtinbenhnhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThanhtoanhoadon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mcThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTennhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mcDoimatkhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbltieude = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(303, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(995, 760);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlybenhnhan,
            this.mcThongtincanhan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(303, 760);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnQuanlybenhnhan
            // 
            this.mnQuanlybenhnhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnthongtinbenhnhan,
            this.mnThanhtoanhoadon});
            this.mnQuanlybenhnhan.Expanded = true;
            this.mnQuanlybenhnhan.Name = "mnQuanlybenhnhan";
            this.mnQuanlybenhnhan.Text = "Quản lý bệnh nhân";
            this.mnQuanlybenhnhan.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // mnthongtinbenhnhan
            // 
            this.mnthongtinbenhnhan.Name = "mnthongtinbenhnhan";
            this.mnthongtinbenhnhan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnthongtinbenhnhan.Text = "Thông tin bệnh nhân";
            this.mnthongtinbenhnhan.Click += new System.EventHandler(this.mnthongtinkhachhang_Click);
            // 
            // mnThanhtoanhoadon
            // 
            this.mnThanhtoanhoadon.Name = "mnThanhtoanhoadon";
            this.mnThanhtoanhoadon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnThanhtoanhoadon.Text = "Thanh toán hóa đơn";
            this.mnThanhtoanhoadon.Click += new System.EventHandler(this.mnThanhtoanhoadon_Click);
            // 
            // mcThongtincanhan
            // 
            this.mcThongtincanhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTennhanvien,
            this.mcDoimatkhau,
            this.mnDangxuat});
            this.mcThongtincanhan.Expanded = true;
            this.mcThongtincanhan.Name = "mcThongtincanhan";
            this.mcThongtincanhan.Text = "Thông tin nhân viên";
            // 
            // mnTennhanvien
            // 
            this.mnTennhanvien.Name = "mnTennhanvien";
            this.mnTennhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTennhanvien.Text = "Tên nhân viên";
            this.mnTennhanvien.Click += new System.EventHandler(this.mnTennhanvien_Click);
            // 
            // mcDoimatkhau
            // 
            this.mcDoimatkhau.Name = "mcDoimatkhau";
            this.mcDoimatkhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mcDoimatkhau.Text = "Đổi mật khẩu";
            this.mcDoimatkhau.Click += new System.EventHandler(this.mcDoimatkhau_Click);
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
            this.lbltieude});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1298, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lbltieude);
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // lbltieude
            // 
            this.lbltieude.Caption = "Demo Lễ tân";
            this.lbltieude.Id = 0;
            this.lbltieude.ItemAppearance.Normal.BackColor = System.Drawing.Color.White;
            this.lbltieude.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltieude.ItemAppearance.Normal.Options.UseBackColor = true;
            this.lbltieude.ItemAppearance.Normal.Options.UseFont = true;
            this.lbltieude.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem1_ItemClick);
            // 
            // LeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 799);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeTan";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản lý lễ tân";
            this.Load += new System.EventHandler(this.LeTan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlybenhnhan;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnthongtinbenhnhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThanhtoanhoadon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mcThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTennhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mcDoimatkhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDangxuat;
        private DevExpress.XtraBars.BarStaticItem lbltieude;
    }
}