using DevExpress.XtraBars;
using QuanLyBenhVien.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class LeTan : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public LeTan()
        {
            InitializeComponent();
        }
        uc_BenhNhan ucKhachHang;
        uc_Doimatkhau ucDoimatkhau;
        uc_ThanhToan ucThanhToan;
        uc_Thongtincanhan ucThongtincanhan;
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void mnthongtinkhachhang_Click(object sender, EventArgs e)
        {
            if(ucKhachHang==null)
            {
                ucKhachHang = new uc_BenhNhan();
                ucKhachHang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucKhachHang);
                ucKhachHang.BringToFront();
            }    
            else
            {
                ucKhachHang.BringToFront();
            }
            lbltieude.Caption = mnQuanlybenhnhan.Text;
        }

        private void mnThanhtoanhoadon_Click(object sender, EventArgs e)
        {
            if (ucThanhToan == null)
            {
                ucThanhToan = new uc_ThanhToan();
                ucThanhToan.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThanhToan);
                ucThanhToan.BringToFront();
            }
            else
            {
                ucThanhToan.BringToFront();
            }
            lbltieude.Caption = mnThanhtoanhoadon.Text;
        }

        private void mnTennhanvien_Click(object sender, EventArgs e)
        {
            if (ucThongtincanhan == null)
            {
                ucThongtincanhan = new uc_Thongtincanhan();
                ucThongtincanhan.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThongtincanhan);
                ucThongtincanhan.BringToFront();
            }
            else
            {
                ucThongtincanhan.BringToFront();
            }
            lbltieude.Caption = "Thông tin cá nhân";
        }

        private void mcDoimatkhau_Click(object sender, EventArgs e)
        {
            if (ucDoimatkhau == null)
            {
                ucDoimatkhau = new uc_Doimatkhau();
                ucDoimatkhau.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucDoimatkhau);
                ucDoimatkhau.BringToFront();
            }
            else
            {
                ucDoimatkhau.BringToFront();
            }
            lbltieude.Caption = mcDoimatkhau.Text;
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            Cons.Cons.loginnhanvien = null;
            this.Close();
            mnTennhanvien.Text = "";
        }

        private void mainContainer_Click(object sender, EventArgs e)
        {

        }

        private void LeTan_Load(object sender, EventArgs e)
        {
            mnTennhanvien.Text = Cons.Cons.loginnhanvien.Ten;
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
