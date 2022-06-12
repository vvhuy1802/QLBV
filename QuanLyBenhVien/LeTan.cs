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
        uc_Benhvien ucBlank;
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
            ucBlank = new uc_Benhvien();
            ucBlank.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(ucBlank);
            ucBlank.BringToFront();
            if (ucThongtincanhan == null)
            {
                ucThongtincanhan = new uc_Thongtincanhan();
                ucThongtincanhan.Dock = DockStyle.Fill;
                ucThongtincanhan.Location = new Point(
                mainContainer.ClientSize.Width / 2 - ucThongtincanhan.Size.Width / 2,
                  mainContainer.ClientSize.Height / 2 - ucThongtincanhan.Size.Height / 2);
                ucThongtincanhan.Anchor = AnchorStyles.None;
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
            if (ucBlank == null)
            {
                ucBlank = new uc_Benhvien();
                ucBlank.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucBlank);
                ucBlank.BringToFront();
            }
            else
                ucBlank.BringToFront();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
