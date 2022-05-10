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
    public partial class BacSi : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        uc_Quanlybenh ucQuanlybenh;
        uc_Quanlydonthuoc ucQuanlydonthuoc;
        uc_Thongtincanhan1 ucThongtincanhan1;
        uc_Doimatkhau1 ucDoimatkhau1;
        public BacSi()
        {
            InitializeComponent();
        }

        private void mnQuanlybenh_Click(object sender, EventArgs e)
        {
            if (ucQuanlybenh == null)
            {
                ucQuanlybenh = new uc_Quanlybenh();
                ucQuanlybenh.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucQuanlybenh);
                ucQuanlybenh.BringToFront();
            }
            else
            {
                ucQuanlybenh.BringToFront();
            }
            lblTieude1.Caption = mnQuanlybenh.Text;
        }

        private void mnQuanlydonthuoc_Click(object sender, EventArgs e)
        {
            if (ucQuanlydonthuoc == null)
            {
                ucQuanlydonthuoc = new uc_Quanlydonthuoc();
                ucQuanlydonthuoc.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucQuanlydonthuoc);
                ucQuanlydonthuoc.BringToFront();
            }
            else
            {
                ucQuanlydonthuoc.BringToFront();
            }
            lblTieude1.Caption = mnQuanlydonthuoc.Text;
        }

        private void mnTennhanvien_Click(object sender, EventArgs e)
        {
            if (ucThongtincanhan1 == null)
            {
                ucThongtincanhan1 = new uc_Thongtincanhan1();
                ucThongtincanhan1.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucThongtincanhan1);
                ucThongtincanhan1.BringToFront();
            }
            else
            {
                ucThongtincanhan1.BringToFront();
            }
            lblTieude1.Caption = "Thông tin cá nhân";
        }

        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (ucDoimatkhau1 == null)
            {
                ucDoimatkhau1 = new uc_Doimatkhau1();
                ucDoimatkhau1.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucDoimatkhau1);
                ucDoimatkhau1.BringToFront();
            }
            else
            {
                ucDoimatkhau1.BringToFront();
            }
            lblTieude1.Caption = mnDoimatkhau.Text;
        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            Cons.Cons.loginnhanvien = null;
            this.Close();
            mnTennhanvien.Text = "";
        }

        private void BacSi_Load(object sender, EventArgs e)
        {
            mnTennhanvien.Text = Cons.Cons.loginnhanvien.Ten;
        }
    }
}
